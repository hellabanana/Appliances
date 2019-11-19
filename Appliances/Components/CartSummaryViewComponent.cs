using Appliances.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.Components
{
    public class CartSummaryViewComponent: ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
