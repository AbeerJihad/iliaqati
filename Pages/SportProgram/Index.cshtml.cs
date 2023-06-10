#nullable disable
using liaqati_master.Services.Repositories;
using Microsoft.AspNetCore.Identity;

namespace liaqati_master.Pages.SportProgram
{
    public class IndexModel : PageModel
    {
        readonly IRepoProgram _context;
        readonly IRepoProgramExercies _repocontext;
        readonly IRepoExercise _repocontextExer;
        readonly IRepoOrder _repoOrder;
        readonly IRepoOrder_Details _repoOrder_Details;
        private readonly UserManager<User> _userManager;


        public IndexModel(IRepoProgram context, IRepoProgramExercies repocontext, IRepoExercise repocontextExer, IRepoOrder repoOrder, IRepoOrder_Details repoOrder_Details, UserManager<User> userManager)
        {
            _context = context;
            _repocontext = repocontext;
            _repocontextExer = repocontextExer;
            BodyFoucs = Database.GetListOfBodyFocus().Select(b => b.Value).ToList();
            TraningType = Database.GetListOfTrainingType().Select(b => b.Value).ToList();
            Equipment = Database.GetListOfEquipment().Select(b => b.Value).ToList();
            Difficulty = Database.GetListOfDifficulty().Select(b => b.Value).ToList();
            Length = Database.GetListOfProgramLength().Select(b => b.Value).ToList();
            _repoOrder = repoOrder;
            _repoOrder_Details = repoOrder_Details;
            _userManager = userManager;
        }



        [BindProperty(SupportsGet = true)]
        public List<SportsProgram> Sports { get; set; }

        public List<string> BodyFoucs { get; set; }
        public List<string> TraningType { get; set; }
        public List<string> Difficulty { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> Length { get; set; }


        public List<SelectListItem> Duration { get; set; } = new List<SelectListItem>() {
            new SelectListItem("43","43"),
            new SelectListItem("26","26"),
            new SelectListItem("45","45"),
            new SelectListItem("37","37")

        };
        public IEnumerable<SelectListItem> SortList { get; set; } = new List<SelectListItem> {
            new SelectListItem(){Value="MinPrice",Text="«·√ﬁ· ”⁄—«"},
            new SelectListItem(){Value="MaxPrice",Text="«·√⁄·Ï ”⁄—«"},
            new SelectListItem(){Value="MaxRatePercentage",Text="«·√⁄·Ï  ﬁÌÌ„«"},
            new SelectListItem(){Value="MinRatePercentage",Text="«·√ﬁ·  ﬁÌÌ„«"},
        };

        [BindProperty(SupportsGet = true)]
        public ExerciseQueryParamters queryParameters { get; set; }

        public async Task<IActionResult> OnGet(string? id)
        {

            if (id is not null)
            {
                var program = await _context.GetProgram(id);
                var user = await _userManager.GetUserAsync(User);

                var item = (await _repoOrder.GetAllAsync()).FirstOrDefault(p => p.UserId == user.Id && p.Order_Details[0].ServiceId == id);

                if (item is null)
                {
                    Order order = new Order()
                    {
                        Id = CommonMethods.Id_Guid(),
                        UserId = user.Id,
                        OrderStatus = 0,
                        CreatedDate = DateTime.Now,
                        DiscountCode = "0",
                        OrderDate = DateTime.Now,
                        TotalPrice = program.Services.Price,

                    };

                    await _repoOrder.AddEntityAsync(order);


                    Order_Details order_Details = new Order_Details()
                    {
                        Id = CommonMethods.Id_Guid(),
                        ServiceId = program.Id,
                        CreatedDate = DateTime.Now,
                        OrderId = order.Id,
                        Price = (double)program.Services.Price,
                        Quantity = 1,
                    };

                    await _repoOrder_Details.AddEntityAsync(order_Details);




                    return RedirectToPage("/sportprogram/ProgramDetails", new { id });

                }







            }


            return Page();


        }
    }
}
