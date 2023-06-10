using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Orders
{
    public class IndexModel : PageModel
    {

        readonly IRepoOrder _repoOrder;
        readonly IRepoCart _repoCart;
        readonly private  IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;


        public IndexModel(IRepoOrder repoOrder, IRepoCart repoCart, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            _repoOrder = repoOrder;
            _repoCart = repoCart;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }
        [BindProperty(SupportsGet =true)]
        public List<Order> Orders { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<string> titles { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var principal = _httpContextAccessor.HttpContext?.User;
            string userId = _userManager.GetUserId(principal);
            if (userId == null)
            {
                return NotFound();
            }
            else
            {
              Orders=   (await _repoOrder.GetAllAsync()).Where(p=>p.UserId == userId).ToList();

                


            }





            return Page();
        }
    }
}
