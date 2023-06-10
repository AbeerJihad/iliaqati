using liaqati_master.Services.CustomValidation;
using liaqati_master.Services.CustomValidationAttribute;

namespace liaqati_master.Areas.Admin.Pages.Exercises
{
    public class EditExerciseModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        private readonly IFormFileMang _repoFile;


        public EditExerciseModel(IRepoExercise repoExercise, IFormFileMang repoFile)
        {
            _repoExercise = repoExercise;
            _repoFile = repoFile;
        }

        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> TraningTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> EquipmentsTypeStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> DifficultyStatusList { get; set; }
        [BindProperty(SupportsGet = true)]
        public List<SelectListItem> BodyFocusStatusList { get; set; }

        [BindProperty(SupportsGet = true)]
        public int DifficultyStatus { get; set; }
        [BindProperty(SupportsGet = true)]
        public Exercise Exercise { get; set; }
        [BindProperty]
        [Display(Name = "أضف صورة")]
        [AllowedExtensions(new string[] { ".png", ".jpg" }, ErrorMessage = " نوع الملف يجب أن يكون jpg , png  ")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 2, "حجم الملف يزيد عن 2 ميغا بايت")]
        public IFormFile? Images { get; set; }
        [BindProperty]
        [Display(Name = "أضف فيديو")]
        [AllowedExtensions(new string[] { ".mp4" }, ErrorMessage = " نوع الملف يجب أن يكون mp4")]
        [FilesMaxSize(maxFileSize: 1024 * 1024 * 5, "حجم الملف يزيد عن 5 ميغا بايت")]
        public IFormFile? Video { get; set; }


        public string imagepath { get; set; }
        public string videopath { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            TraningTypeStatusList = Database.GetListOfTrainingType();
            BodyFocusStatusList = Database.GetListOfBodyFocus();
            DifficultyStatusList = Database.GetListOfDifficulty();
            EquipmentsTypeStatusList = Database.GetListOfEquipment();
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _repoExercise.GetByIDAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }


            if (exercise.TraningType != null)
                foreach (var item in TraningTypeStatusList)
                {
                    if (exercise.TraningType.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (exercise.BodyFocus != null)
                foreach (var item in BodyFocusStatusList)
                {
                    if (exercise.BodyFocus.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (exercise.Equipments != null)
                foreach (var item in EquipmentsTypeStatusList)
                {
                    if (exercise.Equipments.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (exercise.Difficulty != null)
                foreach (var item in DifficultyStatusList)
                {
                    if (exercise.Difficulty == Convert.ToInt32(item.Value))
                    {
                        DifficultyStatus = Convert.ToInt32(item.Value);
                        item.Selected = true;
                    }
                }


            imagepath = exercise.Image;
            videopath = exercise.Video;
            Exercise = exercise;



            return Page();
        }

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

            var id = Exercise.Id;

            var item = await _repoExercise.GetByIDAsync(id);
            if (item is null)
            {

                return NotFound();
            }
            item.BodyFocus = string.Join(',', BodyFocusStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            item.TraningType = string.Join(',', TraningTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            item.Equipments = string.Join(',', EquipmentsTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            item.Difficulty = DifficultyStatus;

            item.Title = Exercise.Title;
            item.Detail = Exercise.Detail;
            item.Duration = Exercise.Duration;
            item.Price = Exercise.Price;
            string? oldurl = item.Image;
            string? oldurlvideo = item.Video;
            if (Images != null)
            {
                item.Image = await _repoFile.Upload(Images, "images", "Exercise");
            }

            if (Video != null)
            {
                item.Video = await _repoFile.Upload(Video, "Video", "Exercise");
            }

            await _repoExercise.UpdateEntityAsync(item);


            //  _context.Attach(MealPlans).State = EntityState.Modified;


            return RedirectToPage("./Index");
        }


    }
}
