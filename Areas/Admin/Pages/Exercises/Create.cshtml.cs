using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class CreateExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;

        public CreateExerciseModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
            _repoFile = repoFile;
        }

        public IActionResult OnGet()
        {
            TraningTypeStatusList = Database.GetListOfTrainingType();
            BodyFocusStatusList = Database.GetListOfBodyFocus();
            DifficultyStatusList = Database.GetListOfDifficulty();
            EquipmentsTypeStatusList = Database.GetListOfEquipment();
            return Page();
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
        [BindProperty]
        public Exercise Exercise { get; set; }
        [BindProperty]
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "أضف صورة")]
        [AllowedExtensions(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        public IFormFile Images { get; set; }
        [BindProperty]
        [Required(ErrorMessage = " {0} حقل مطلوب")]
        [Display(Name = "أضف فيديو")]
        [AllowedExtensions(new string[] { ".mp4" }, ErrorMessage = " نوع الملف يجب أن يكون mp4")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 5, "حجم الملف يزيد عن 5 ميغا بايت")]
        public IFormFile Video { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            Exercise.Id = CommonMethods.Id_Guid();
            string? oldurl = Exercise.Image;
            string? oldurlvideo = Exercise.Video;

            if (!TraningTypeStatusList.Where(ch => ch.Selected).Any())

            {

                ModelState.AddModelError("Exercise.TraningType", "حدد نوعا غذائيا واحدا على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (!BodyFocusStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("Exercise.BodyFocus", " حدد نوعا  واحدا على الأقل للوجبة");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (DifficultyStatus == 0)
            {
                ModelState.AddModelError("Exercise.Difficulty", "حدد نوعا غذائيا واحدا على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (!EquipmentsTypeStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("Exercise.Equipments", "حدد اداة واحدة على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }


            Exercise.BodyFocus = string.Join(',', BodyFocusStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            Exercise.TraningType = string.Join(',', TraningTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            Exercise.Equipments = string.Join(',', EquipmentsTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            Exercise.Difficulty = DifficultyStatus;
            if (Images != null)
            {
                Exercise.Image = await _repoFile.Upload(Images, "~/images/atricles", "Exercise");
            }
            else
            {
                Exercise.Image = oldurl;
            }
            if (Video != null)
            {
                Exercise.Video = await _repoFile.Upload(Video, "Video", "Exercise");
            }
            else
            {
                Exercise.Video = oldurlvideo;
            }
            var userid = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userid is not null)
            {
                Exercise.UserId = userid;
            }

            await _repoExercise.AddEntityAsync(Exercise);
            return RedirectToPage("./Index");
        }
    }
}
