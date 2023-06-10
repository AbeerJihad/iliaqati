using liaqati_master.Models;

namespace liaqati_master.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly IRepoCart repoCart;
        private readonly IRepoOrder repoOrder;
        private readonly IRepoOrder_Details repoOrder_Details;
        private readonly UserManager<User> _userManager;
        private readonly IRepoUser _user;



      
     

        public CartModel(IRepoCart repoCart, IRepoOrder repoOrder, IRepoOrder_Details repoOrder_Details, UserManager<User> userManager, IRepoUser user)
        {
            this.repoCart = repoCart;
            this.repoOrder = repoOrder;
            this.repoOrder_Details = repoOrder_Details;
            _userManager = userManager;
            _user = user;
        }

        [BindProperty(SupportsGet = true)]
        public List<CartItem>? CartItems { get; set; }



        [BindProperty(SupportsGet = true)]

        public double? Total { get; set; }
         

        [BindProperty(SupportsGet = true)]

        public string? address { get; set; }

        public async Task OnGetAsync()
        {

            Total = (await repoCart.GetCartItems()).Sum(cart => cart.Quantity * cart.UnitPrice);
            CartItems = await repoCart.GetCartItems();

            var user = await _userManager.GetUserAsync(User);
          //  address = user.address;


        }
        public async Task<IActionResult> OnPostIncreaseAsync(string id)
        {
            await repoCart.AddToCart(id);
            return RedirectToPage();


        }
        public async Task<IActionResult> OnPostDecreaseAsync(string id)
        {
            await repoCart.RemoveItem(id);
            return RedirectToPage();

        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            await repoCart.RemoveItemFromCart(id);
            return RedirectToPage();

        }

        public async Task<IActionResult> OnPostAddOrderAsync()
        {
            CartItems = await repoCart.GetCartItems();

            foreach (CartItem cartItem in CartItems)
            {
                Order order = new Order()
                {
                    Id = CommonMethods.Id_Guid(),
                    UserId = cartItem.UserId,
                    OrderStatus = 0,
                    CreatedDate = DateTime.Now,
                    DiscountCode = "0",
                    OrderDate = DateTime.Now,
                    TotalPrice = (await repoCart.GetCartItems()).Sum(cart => cart.Quantity * cart.UnitPrice),
                    
                };

                await repoOrder.AddEntityAsync(order);


                Order_Details order_Details = new Order_Details()
                {
                    Id = CommonMethods.Id_Guid(),
                    ServiceId = cartItem.ServiceId,
                    CreatedDate = DateTime.Now,
                    OrderId = order.Id,
                    Price = cartItem.UnitPrice,
                    Quantity = cartItem.Quantity,


                };

                await repoOrder_Details.AddEntityAsync(order_Details);

                foreach (CartItem v in CartItems)
                {
                    var n = (await repoOrder_Details.GetAllAsync()).Where(p => p.ServiceId == cartItem.ServiceId);

                    if (n == null)
                    {
                        Order_Details order_Detailss = new Order_Details()
                        {
                            Id = CommonMethods.Id_Guid(),
                            ServiceId = v.ServiceId,
                            CreatedDate = DateTime.Now,
                            OrderId = order.Id,
                            Price = cartItem.UnitPrice,
                            Quantity = cartItem.Quantity,


                        };

                        await repoOrder_Details.AddEntityAsync(order_Detailss);
                    }



                }



                //Tracking tracking = new Tracking()
                //{
                //    Id = CommonMethods.Id_Guid(),
                //    CreatedDate= DateTime.Now,
                //    Iscomplete= false,
                //    Order_DetailsId= order.Id,
                //};









            }



            repoCart.RemoveAllItem(CartItems);


            return RedirectToPage("/orders/index");

        }



        public async Task<IActionResult> OnPostUpdateAddressAsync()
        {

            var user = await _userManager.GetUserAsync(User);

            //user.address= address;
            _user.UpdateEntityAsync(user);
           

        //    _userManager.UpdateAsync(user);

            return RedirectToPage();

        }




    }
}
