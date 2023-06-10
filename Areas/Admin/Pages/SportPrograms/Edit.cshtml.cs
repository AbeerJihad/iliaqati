using liaqati_master.Services;

namespace liaqati_master.Pages.Programs
{
    public class EditProgramModel : PageModel
    {


        private readonly IRepoProgram _repoProgram;
        private readonly IRepoExercise _repoExercise;
        private readonly IRepoCategory _repoCategory;
        private readonly IRepoProgramExercies _repoProgramExercies;
        private readonly LiaqatiDBContext _context;
        public EditProgramModel(IRepoProgram repoProgram, IRepoExercise repoExercise, IRepoCategory repoCategory, IRepoProgramExercies repoProgramExercies, LiaqatiDBContext context)
        {
            _repoProgram = repoProgram;
            _repoExercise = repoExercise;
            _repoCategory = repoCategory;
            _repoProgramExercies = repoProgramExercies;
            _context = context;
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
        public async Task<Exercise?> getExercise(string id)
        {
            var exercise = await _repoExercise.GetByIDAsync(id);

            return exercise;
        }


        public SelectList CatogeryName { get; set; }
        public List<SelectListItem> ExerciesName { get; set; }


        [BindProperty(SupportsGet = true)]
        public SportsProgram SportsProgram { get; set; }


        [BindProperty(SupportsGet = true)]
        public Exercies_program Exercies_program { get; set; }



        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxBodyFocus { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<VmCheckBox> lstCheckBoxTrainingType { get; set; }

        public List<string> BodyFocus { get; set; } = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
        public List<string> TrainingType { get; set; } = Database.GetListOfTrainingType().Select(b => b.Value).ToList();


        public async Task OnPostAsync()

        {

        }



        public async Task<IActionResult> OnGetAsync(string? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            TraningTypeStatusList = Database.GetListOfTrainingType();
            BodyFocusStatusList = Database.GetListOfBodyFocus();
            DifficultyStatusList = Database.GetListOfDifficulty();
            EquipmentsTypeStatusList = Database.GetListOfEquipment();
            SportsProgram? sportsProgram = await _repoProgram.GetProgram(id);
            if (sportsProgram == null)
            {
                return NotFound();
            }
            if (sportsProgram.TrainingType != null)
                foreach (var item in TraningTypeStatusList)
                {
                    if (sportsProgram.TrainingType.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (sportsProgram.BodyFocus != null)
                foreach (var item in BodyFocusStatusList)
                {
                    if (sportsProgram.BodyFocus.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (sportsProgram.Equipment != null)
                foreach (var item in EquipmentsTypeStatusList)
                {
                    if (sportsProgram.Equipment.Contains(item.Value))
                    {
                        item.Selected = true;

                    }
                }
            if (sportsProgram.Difficulty != null)
                foreach (var item in DifficultyStatusList)
                {
                    if (sportsProgram.Difficulty == Convert.ToInt32(item.Value))
                    {
                        DifficultyStatus = Convert.ToInt32(item.Value);
                        item.Selected = true;
                    }
                }

            //  SportsProgram sportsProgram =_UnitOfWork.SportsProgramRepository.GetByID(id);


            //foreach(Exercies_program x in  sportsProgram.Exercies_Programs!)
            //{
            //    x.sportsProgram = null;
            //}




            SportsProgram = sportsProgram;

            SportsProgram.Exercies_Programs = SportsProgram.Exercies_Programs!.OrderBy(x => x.Week).ThenBy(y => y.Day).ToList();
            CatogeryName = new SelectList((await _repoCategory.GetAllAsync()).Where(c => c.Target == Database.GetListOfTargets()[nameof(SportsProgram)]), nameof(Category.Id), nameof(Category.Name));
            ExerciesName = (await _repoExercise.GetAllAsync()).Select(a =>
                                       new SelectListItem
                                       {
                                           Value = a.Id?.ToString(),
                                           Text = a.Title
                                       }).ToList();

            //
            return Page();
        }


        public async Task<IActionResult> OnPostEditProgramAsync()
        {

            if (!ModelState.IsValid)
            {
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }

            var id = SportsProgram.Id;
            SportsProgram? item = await _repoProgram.GetProgram(id);
            if (item is null)
            {
                return NotFound();
            }
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

                ModelState.AddModelError("SportsProgram.TrainingType", "حدد نوعا غذائيا واحدا على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (!BodyFocusStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("SportsProgram.BodyFocus", " حدد نوعا  واحدا على الأقل للوجبة");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (DifficultyStatus == 0)
            {
                ModelState.AddModelError("SportsProgram.Difficulty", "حدد نوعا غذائيا واحدا على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }
            if (!EquipmentsTypeStatusList.Where(ch => ch.Selected).Any())
            {
                ModelState.AddModelError("SportsProgram.Equipment", "حدد اداة واحدة على الأقل");
                TraningTypeStatusList = Database.GetListOfTrainingType();
                BodyFocusStatusList = Database.GetListOfBodyFocus();
                DifficultyStatusList = Database.GetListOfDifficulty();
                EquipmentsTypeStatusList = Database.GetListOfEquipment();
                return Page();
            }


            SportsProgram.BodyFocus = string.Join(',', BodyFocusStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.TrainingType = string.Join(',', TraningTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.Equipment = string.Join(',', EquipmentsTypeStatusList.Where(ch => ch.Selected).Select(ch => ch.Value));
            SportsProgram.Difficulty = DifficultyStatus;

            item.Services!.Title = SportsProgram.Services!.Title;
            item.Services.Price = SportsProgram.Services.Price;
            item.Services.Description = SportsProgram.Services.Description;
            item.Length = SportsProgram.Length;
            //item.BodyFocus = SportsProgram.BodyFocus;
            item.Difficulty = SportsProgram.Difficulty;
            item.Equipment = SportsProgram.Equipment;
            //item.TrainingType = SportsProgram.TrainingType;
            item.Services.CategoryId = SportsProgram.Services.CategoryId;


            item.BodyFocus = string.Join(',', lstCheckBoxBodyFocus.Where(ch => ch.IsChecked).Select(ch => ch.Name));
            item.TrainingType = string.Join(',', lstCheckBoxTrainingType.Where(ch => ch.IsChecked).Select(ch => ch.Name));





            for (int x = 0; x < SportsProgram.Exercies_Programs!.Count; x++)
            {
                item.Exercies_Programs![x] = SportsProgram.Exercies_Programs[x];
            }
            await _repoProgram.UpdateProgram(item);
            return RedirectToPage("./Index");
        }


        public async Task<IActionResult> OnPostDeleteProgExer(string id)
        {


            if (id == null)
            {
                return NotFound();
            }

            Exercies_program x =await _repoProgramExercies.GetExercies_program(id);


            SportsProgram sport = await _repoProgram.GetProgram(x.SportsProgramId);



            _repoProgramExercies.DeleteExercies_program(id);
    


            return RedirectToPage("Edit", new { id = sport.Id });
        }


        public async Task<IActionResult> OnPostEditProgExer()
        {
            Exercies_program exercies = await _repoProgramExercies.GetExercies_program(Exercies_program.Id);

            exercies.Day = Exercies_program.Day;
            exercies.Week = Exercies_program.Week;
            exercies.ExerciseId = Exercies_program.ExerciseId;

            await _repoProgramExercies.UpdateExercies_program(exercies);

            return RedirectToPage("Edit", new { id = Exercies_program.SportsProgramId });
        }


        public async Task<IActionResult> OnPostAddSystemAsync(string? id)
        {

            SportsProgram? sports = await _repoProgram.GetProgram(id);

            List<Exercies_program> list = new();

            foreach (Exercies_program x in _context.TblExercies_program.ToList())
            {
                if (x.SportsProgramId == id)
                {
                    list.Add(x);
                }

            }
            if (sports is null)
            {
                return Page();
            }

            SportsProgram = sports;
            SportsProgram.Exercies_Programs = list;

            TraningTypeStatusList = Database.GetListOfTrainingType();
            BodyFocusStatusList = Database.GetListOfBodyFocus();
            DifficultyStatusList = Database.GetListOfDifficulty();
            EquipmentsTypeStatusList = Database.GetListOfEquipment();



            return Page();
        }

        
        




    }
}
