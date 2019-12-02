using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appliances.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProduct repository;

        public AdminController(IProduct repo)
        {
            repository = repo;

        }

        public ViewResult Index() => View(repository.Products);

        public ViewResult Edit(int Id) =>
            View(repository.Products
                .FirstOrDefault(p => p.Id == Id));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
               
                return View(product);
            }
        }

        public ViewResult Create() => View("Edit", new Product());

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            Product deletedProduct = repository.DeleteProduct(Id);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}