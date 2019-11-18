using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appliances.Infrastructure;
using Appliances.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.Controllers
{
    public class CartController : Controller
    {
        private IProduct repos;

        public CartController(IProduct re)
        {

            repos = re;
        }

        public RedirectToActionResult AddToCart(int productId,string returnUrl)
        {
            Product product = repos.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.AddItem(product, 1);
                SaveCart(cart);

            }
            return RedirectToAction("Index", new { returnUrl });

        }


        public RedirectToActionResult RemoveFromCart (int productId,string returnUrl)
        {
            Product product = repos.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                Cart cart = GetCart();
                cart.RemoveLine(product);
                SaveCart(cart);


            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("Cart") ??
                new Cart();return cart;


        }
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }
    }
}