using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace liaqati_master.Pages.Orders
{
    public class AddOrderModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(VmAddCart cart) 
        {
            cart.Total = cart.Total + 20;



        }
    }
}
