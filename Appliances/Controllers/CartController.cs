using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appliances.Infrastructure;
using Appliances.Models;
using Appliances.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.Controllers
{
    public class CartController : Controller
    {
        private IProduct repository;
        private Cart cart;

        public CartController(IProduct repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);
            if (product != null)
            {
                cart.AddItem(product, 1);
                
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int Id,
                string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id == Id);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}