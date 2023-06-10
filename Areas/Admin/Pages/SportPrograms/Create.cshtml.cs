using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Pages.Programs
{
    public class CreatProgrameModel : PageModel
    {
        private readonly IRepoProgram _repoProgram;
        private readonly IRepoExercise _repoExercise;
        private readonly IRepoProgramExercies _repoProgramExercies;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoService _repoService;
        private readonly IFormFileMang _repoFile;


        public CreatProgrameModel(IFormFileMang repoFile, IRepoProgram repoProgram, IRepoCategory repoCategory, IRepoExercise repoExercise, IRepoService repoService, IRepoProgramExercies repoProgramExercies)
        {
            _repoFile = repoFile;
            _repoProgram = repoProgram;
            _repoCategory = repoCategory;
            _repoExercise = repoExercise;
            _repoService = repoService;
            _repoProgramExercies = repoProgramExercies;
        }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> TraningTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> EquipmentsTypeStatusList { get; set; }
        public List<SelectListItem> DifficultyStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public int DifficultyStatus { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> BodyFocusStatusList { get; set; }
        public SelectList CatogeryName { get; set; }

        public List<SelectListItem> LstExercies { get; set; }
        [BindProperty]
        public string? text { get; set; }
        public string? imagepath { get; set; }


        public int index { get; set; } = -1;
        [BindProperty]
        public List<Exercies_program> Exercies_program { get; set; }

        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty]
        public Exercise Exercises { get; set; }



        [BindProperty(SupportsGet = true)]
        public List<string> list { get; set; }
        [BindProperty]
        [Display(Name = "أضف صورة")]
        [AllowedExtensions(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 2, "حجم الملف  لا يزيد عن 2 ميغا بايت")]
        public IFormFile? Images { get; set; }
        public string? Display { get; set; } = "d-none";
        public string? ReadOnly { get; set; } = "";

        public int btnSave { get; set; }

        public List<string> BodyFocus { get; set; } = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
        public List<string> TrainingType { get; set; } = Database.GetListOfTrainingType().Select(b => b.Value).ToList();






        public async Task<IActionResult> OnGet([FromRoute] string? Id)
        {
            RenderSelected();



            Display = "d-none";
            btnSave = 0;


            SportsProgram sports = await _repoProgram.GetProgram(Id);
            if (sports != null)
            {
                SportsProgram = sports;
                SportsProgram.Exercies_Programs = SportsProgram.Exercies_Programs!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();

                SportsProgram = sports;
                if (sports.TrainingType != null)
                    foreach (var item in TraningTypeStatusList)
                    {
                        if (sports.TrainingType.Contains(item.Value))
                        {
                            item.Selected = true;

                        }
                    }
                if (sports.BodyFocus != null)
                    foreach (var item in BodyFocusStatusList)
                    {
                        if (sports.BodyFocus.Contains(item.Value))
                        {
                            item.Selected = true;

                        }
                    }
                if (sports.Equipment != null)
                    foreach (var item in EquipmentsTypeStatusList)
                    {
                        if (sports.Equipment.Contains(item.Value))
                        {
                            item.Selected = true;

                        }
                    }
                if (sports.Difficulty != null)
                    foreach (var item in DifficultyStatusList)
                    {
                        if (sports.Difficulty == Convert.ToInt32(item.Value))
                        {
                            DifficultyStatus = Convert.ToInt32(item.Value);
                            item.Selected = true;
                        }
                    }

            }












            //CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(SportsProgram)]), nameof(Category.Id), nameof(Category.Name));


            LstExercies = (await _repoExercise.GetAllAsync()).Select(a => new SelectListItem { Value = a.Id?.ToString(), Text = a.Title }).ToList();
            return Page();
        }


        public async Task<Exercise?> getExercise(string id)
        {
            var exercise = await _repoExercise.GetByIDAsync(id);

            return exercise;
        }





        public async Task<IActionResult> OnPostAddAsync()
        {

            if (!ModelState.IsValid)
            {
                RenderSelected();

                return Page();
            }

            if (!TraningTypeStatusList.Where(ch => ch.Selected).Any())

            {

                ModelState.AddModelError("SportsProgram.TrainingType", "حدد نوعا  واحدا  للتدريب على الأقل");
                RenderSelected();

                return Page();
            }
            if (!BodyFocusStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("SportsProgram.BodyFocus", " حدد نوعا  واحدا على الأقل لتركيز");
                RenderSelected();

                return Page();
            }
            if (DifficultyStatus == 0)
            {
                ModelState.AddModelError("SportsProgram.Difficulty", "حدد نوعا للصعوبة واحدا على الأقل");
                RenderSelected();

                return Page();
            }
            if (!EquipmentsTypeStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("SportsProgram.Equipment", "حدد اداة واحدة على الأقل");
                RenderSelected();

                return Page();
            }


            SportsProgram.BodyFocus = string.Join(',', BodyFocusStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.TrainingType = string.Join(',', TraningTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.Equipment = string.Join(',', EquipmentsTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.Difficulty = DifficultyStatus;

            btnSave = 1;
            ReadOnly = "readonly";

            SportsProgram.Id = CommonMethods.Id_Guid();
            SportsProgram.Services!.Id = SportsProgram.Id;
            SportsProgram.Services.CategoryId = SportsProgram.Services.CategoryId;
            string? oldurl = SportsProgram.Image;

            if (Images != null)
            {
                SportsProgram.Image = await _repoFile.Upload(Images, "Images", "Program");

            }
            else
            {
                SportsProgram.Image = oldurl;
            }
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                SportsProgram.Services.UserId = userid;
            }
            await _repoService.AddEntityAsync(SportsProgram.Services);
            await _repoProgram.AddProgram(SportsProgram);

            Display = "d-block";

            LstExercies = (await _repoExercise.GetAllAsync()).Select(a => new SelectListItem { Value = a.Id?.ToString(), Text = a.Title }).ToList();
            SportsProgram.Exercies_Programs = (await _repoProgramExercies.GetAllExercies_program()).Where(exp => exp.SportsProgramId ==
            SportsProgram.Id).ToList();

            RenderSelected();

            return Page();
        }



        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {
            RenderSelected();

            btnSave = 1;
            SportsProgram? sports = await _repoProgram.GetProgram(id);
            if (sports is null)
            {
                return Page();
            }

            imagepath = sports.Image;
            SportsProgram = sports;
            SportsProgram.Exercies_Programs = (await _repoProgramExercies.GetAllExercies_program()).Where(exp => exp.SportsProgramId == id).ToList();
            Display = "d-block";
            return Page();
        }


        private void RenderSelected()
        {

            TraningTypeStatusList = Database.GetListOfTrainingType();
            BodyFocusStatusList = Database.GetListOfBodyFocus();
            DifficultyStatusList = Database.GetListOfDifficulty();
            EquipmentsTypeStatusList = Database.GetListOfEquipment();
        }


    }
}
