using AspNetCoreHero.ToastNotification.Abstractions;
using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Pages.HealthyReicpe
{
    public class CreateHealthyModel : PageModel
    {
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly INotyfService _toastNotification;
        private readonly IFormFileMang _IFormFileMang;
        private readonly IRepoFiles _RepoFiles;
        public CreateHealthyModel(IRepoHealthyRecipe repoHealthyRecipe, INotyfService toastNotification, IFormFileMang iFormFileMang, IRepoFiles repoFiles)
        {

            _repoHealthyRecipe = repoHealthyRecipe;
            _toastNotification = toastNotification;
            _IFormFileMang = iFormFileMang;
            _RepoFiles = repoFiles;
        }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> DietaryTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> MealTypeTypeStatusList { get; set; }

        [BindProperty]
        public HealthyRecipe HealthyRecipes { get; set; }

        [AllowedExtensionsMulti(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSizeMulti(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        [BindProperty, Required(ErrorMessage = "أضف صورة واحدة على الأقل"), Display(Name = "أصف صور المنتج")]
        public IFormFileCollection Images { get; set; }

        public IActionResult OnGet()
        {
            DietaryTypeStatusList = Database.GetListOfDietaryType();
            MealTypeTypeStatusList = Database.GetListOfMealType();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                DietaryTypeStatusList = Database.GetListOfDietaryType();
                MealTypeTypeStatusList = Database.GetListOfMealType();
                return Page();
            }
            var guid = CommonMethods.Id_Guid();
            HealthyRecipes.Id = guid;
            HealthyRecipes!.Id = guid;
            //var id = HealthyRecipes.Category?.Id;

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
            HealthyRecipes.DietaryType = string.Join(',', DietaryTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            HealthyRecipes.MealType = string.Join(',', MealTypeTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));

            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                HealthyRecipes.UserId = userid;
            }
            List<Files> ImagesPaths = new();
            foreach (var item in Images)
            {
                ImagesPaths.Add(new Files() { Id = CommonMethods.Id_Guid(), HealthyId = HealthyRecipes.Id, Path = await _IFormFileMang.Upload(item, "images", "HealthyRecipes") });
            }
            if (ImagesPaths.Count > 0)
            {
                HealthyRecipes.Image = ImagesPaths[0].Path;
            }

            await _repoHealthyRecipe.AddEntityAsync(HealthyRecipes);
            return RedirectToPage("./Index");
        }
    }
}
