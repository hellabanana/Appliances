using Appliances.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Controllers
{
    public class ProductController:Controller
    {
        private IProduct repository;
        public ProductController(IProduct repos)
        {
            repository = repos;
        }

        public IActionResult ViewProduct() => View(repository.Products);

              

    }
}
