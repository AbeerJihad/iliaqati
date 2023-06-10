#nullable disable
namespace liaqati_master.Pages.Exercises
{
    public class ExercisesDetilesModel : PageModel
    {
        private readonly IRepoExercise _repoExercise;
        readonly LiaqatiDBContext _context;

     

        public string Message { get; set; }
        public Exercise exercise = new Exercise();
        public List<Comment_Servies> comments { get; set; }

        public ExercisesDetilesModel(IRepoExercise repoExercise, LiaqatiDBContext context)
        {
            _repoExercise = repoExercise;
            _context = context;
        }

        public async Task OnGetAsync(string id)
        {
            if (id != null)
            {
                exercise = await _repoExercise.GetByIDAsync(id);
                comments = _context.TblCommentServies.Take(3).OrderBy(x => x).ToList();

                if (exercise == null)
                {
                    Message = "NotFound";
                }
            }
        }
    }
}
