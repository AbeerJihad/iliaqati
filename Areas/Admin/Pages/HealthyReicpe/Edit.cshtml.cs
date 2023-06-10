using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class EditHealthyModel : PageModel
    {

        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly IRepoFiles _RepoFiles;
        private readonly IFormFileMang _IFormFileMang;
        public EditHealthyModel(IRepoHealthyRecipe repoHealthyRecipe, IRepoFiles repoFiles, IFormFileMang iFormFileMang)
        {

            _repoHealthyRecipe = repoHealthyRecipe;
            _RepoFiles = repoFiles;
            _IFormFileMang = iFormFileMang;
        }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> DietaryTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> MealTypeTypeStatusList { get; set; }

        [BindProperty(SupportsGet = true)]
        public HealthyRecipe HealthyRecipes { get; set; }
        [BindProperty, Required(ErrorMessage = "أضف صورة واحدة على الأقل"), Display(Name = "أصف صور المنتج")]
        [AllowedExtensionsMulti(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSizeMulti(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        public IFormFileCollection Images { get; set; }
        public List<string?>? paths { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            DietaryTypeStatusList = Database.GetListOfDietaryType();
            MealTypeTypeStatusList = Database.GetListOfMealType();


            if (id == null)
            {
                return NotFound();
            }

            HealthyRecipe? healthyRecipes = await _repoHealthyRecipe.GetByIDAsync(id);
            if (healthyRecipes == null)
            {
                return NotFound();
            }

            paths = (await _RepoFiles.GetAllAsync()).Where(file => file.HealthyId == healthyRecipes.Id).Select(fil => fil.Path).ToList();





            if (healthyRecipes.DietaryType != null)
                foreach (var item in DietaryTypeStatusList)
                {
                    if (healthyRecipes.DietaryType.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (healthyRecipes.MealType != null)
                foreach (var item in MealTypeTypeStatusList)
                {
                    if (healthyRecipes.MealType.Contains(item.Value))
                    {
                        item.Selected = true;
                    }
                }



            HealthyRecipes = healthyRecipes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {


            if (!ModelState.IsValid)
            {
                DietaryTypeStatusList = Database.GetListOfDietaryType();
                MealTypeTypeStatusList = Database.GetListOfMealType();
                return Page();
            }
            if (HealthyRecipes.Id is null)
            {
                return NotFound();
            }
            if (!DietaryTypeStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("HealthyRecipes.DietaryType", "حدد نوعا غذائيا واحدا على الأقل");
                DietaryTypeStatusList = Database.GetListOfDietaryType();
                MealTypeTypeStatusList = Database.GetListOfMealType();
                return Page();
            }
            if (!MealTypeTypeStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("HealthyRecipes.MealType", " حدد نوعا  واحدا على الأقل للوجبة");
                DietaryTypeStatusList = Database.GetListOfDietaryType();
                MealTypeTypeStatusList = Database.GetListOfMealType();
                return Page();
            }
            var item = await _repoHealthyRecipe.GetByIDAsync(HealthyRecipes.Id);
            item!.Title = HealthyRecipes.Title;
            item.Price = HealthyRecipes.Price;
            item.Description = HealthyRecipes.Description;
            item.ShortDescription = HealthyRecipes.ShortDescription;
            item.DietaryType = string.Join(',', DietaryTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            item.MealType = string.Join(',', MealTypeTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            item.PrepTime = HealthyRecipes.PrepTime;
            item.Calories = HealthyRecipes.Calories;
            item.Total_Carbohydrate = HealthyRecipes.Total_Carbohydrate;
            item.Protein = HealthyRecipes.Protein;
            item.PreparationMethod = HealthyRecipes.PreparationMethod;
            item.Ingredients = HealthyRecipes.Ingredients;

            if (Images?.Count > 0)
            {
                List<Files> ImagesPaths = new();
                foreach (var formFile in Images)
                {
                    ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), HealthyId = HealthyRecipes.Id, Path = await _IFormFileMang.Upload(formFile, "images", "products") });
                }
                List<Files> images = (await _RepoFiles.GetAllAsync()).Where(file => file.HealthyId == item.Id).ToList();
                foreach (var image in images)
                {
                    await _RepoFiles.DeleteEntityAsync(image);
                    _IFormFileMang.DeleteFile(image.Path);

                }
                await _RepoFiles.AddRangeOfFiles(ImagesPaths);
                await _RepoFiles.SaveAsync();
                if (ImagesPaths.Count > 0)
                {
                    item.Image = ImagesPaths[0].Path;
                }

            }


            await _repoHealthyRecipe.UpdateEntityAsync(item);


            return RedirectToPage("./Index");
        }


    }
}
