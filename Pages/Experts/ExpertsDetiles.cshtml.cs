using liaqati_master.Services.Repositories;
using liaqati_master.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Experts
{
    public class ExpertsDetilesModel : PageModel
    {
        private readonly IRepoUser repoUser;
        private readonly IRepoHealthyRecipe repoHealthy;
        private readonly IRepoMealPlans repoMeal;
        private readonly IRepoProgram repoProgram;
        private readonly IRepoExercise repoExercise;

        public ExpertsDetilesModel(IRepoUser repoUser,IRepoHealthyRecipe repoHealthy, IRepoMealPlans repoMeal, IRepoProgram repoProgram, IRepoExercise repoExercise)
        {
            this.repoUser = repoUser;
            this.repoHealthy = repoHealthy;
            this.repoMeal = repoMeal;
            this.repoProgram = repoProgram;
            this.repoExercise = repoExercise;
        }

        public User User { get; set; }
        public string Message { get; set; }

        [BindProperty(SupportsGet =true)]
         public string id { get; set; } 
        [BindProperty(SupportsGet =true)]
    
        public  List<MealPlans>? meal { get;set; }
        public List<Exercise>? exercises { get; set; }
        public List<HealthyRecipe>? healthyRecipes { get; set; }
        public List<SportsProgram>? sport  { get; set; }

        public async Task OnGetAsync()
        {
           
            if (id != null)
            {
               User = await repoUser.GetByIDAsync(id);
               meal =await repoMeal.GetbyUserId(id);
               sport =await repoProgram.GetbyUserId(id);
               exercises =await repoExercise.GetbyUserId(id);
               healthyRecipes =await repoHealthy.GetbyUserId(id);


                if (User is null)
                {
                           
                    Message = "NotFound";

                }
               

            }

       
        }


    }
}
