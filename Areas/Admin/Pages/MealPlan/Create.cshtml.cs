namespace liaqati_master.Pages.MealPlan
{
    public class CreateModel : PageModel
    {
        private readonly IRepoMealPlans _repoMealPlans;
        private readonly IRepoHealthyRecipe _repoHealthyRecipe;
        private readonly IRepoService _repoService;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoMeal_Healthy _repoMeal_Healthy;
        public CreateModel(IRepoMealPlans repoMealPlans, IRepoHealthyRecipe repoHealthyRecipe, IRepoCategory repoCategory, IRepoService repoService, IRepoMeal_Healthy repoMeal_Healthy)
        {
            _repoMealPlans = repoMealPlans;
            _repoHealthyRecipe = repoHealthyRecipe;
            _repoCategory = repoCategory;
            _repoService = repoService;
            _repoMeal_Healthy = repoMeal_Healthy;
        }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> DietaryTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> MealTypeTypeStatusList { get; set; }

        public SelectList CatogeryName { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBox { get; set; }


        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxDietaryType { get; set; }

        public List<string> MealType { get; set; } = Database.GetListOfMealType().Select(b => b.Value).ToList();
        public List<string> DietaryType { get; set; } = Database.GetListOfDietaryType().Select(b => b.Value).ToList();


        public string Display { get; set; } = "d-block";

        public int btnSave { get; set; }

        public async Task<IActionResult> OnGet()
        {

            DietaryTypeStatusList = Database.GetListOfDietaryType();
            MealTypeTypeStatusList = Database.GetListOfMealType();











            Display = "d-block";
            btnSave = 0;


            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]),
                 nameof(Category.Id), nameof(Category.Name));


            return Page();
        }

        public async Task<HealthyRecipe?> getHealthyRecipe(string id)
        {
            HealthyRecipe? HealthyRecipe = await _repoHealthyRecipe.GetByIDAsync(id);

            return HealthyRecipe;
        }








        [BindProperty(SupportsGet = true)]
        public MealPlans MealPlan { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAddAsync()
        {


            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(
                 c => c.Target == Database.GetListOfTargets()[nameof(MealPlans)]),
                 nameof(Category.Id), nameof(Category.Name));
            if (!ModelState.IsValid)
            {
                return Page();
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

            MealPlan.DietaryType = string.Join(',', DietaryTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            MealPlan.MealType = string.Join(',', MealTypeTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));

            btnSave = 1;
            MealPlan.Id = CommonMethods.Id_Guid();

            MealPlan.Services!.Id = MealPlan.Id;

            MealPlan.Services.CategoryId = MealPlan.Services.CategoryId;
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                MealPlan.Services.UserId = userid;
            }
            await _repoService.AddEntityAsync(MealPlan.Services);
            await _repoMealPlans.AddEntityAsync(MealPlan);
            Display = "d-block";
            return Page();
        }

        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            btnSave = 1;


            MealPlans? meals = await _repoMealPlans.GetByIDAsync(id);
            if (meals is null)
            {
                return NotFound();
            }

            //List<Meal_Healthy> list = new List<Meal_Healthy>();

            //foreach (Meal_Healthy x in _context.TblMeal_Healthy.ToList())
            //{
            //    if (x.MealPlansId == id)
            //    {
            //        list.Add(x);
            //    }

            //}
            MealPlan = meals;
            MealPlan.Meal_Healthy = (await _repoMeal_Healthy.GetByMealPlansIDAsync(id)).ToList();
            MealPlan.Meal_Healthy = MealPlan.Meal_Healthy!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();
            Display = "d-block";
            return Page();
        }




    }
}
