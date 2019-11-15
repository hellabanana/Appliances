using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Appliances.Models;
using Appliances.ViewModel;

namespace Appliances.Controllers
{
    public class HomeController : Controller
    {
        private IProduct repository;
     public   HomeController(IProduct product)
        {
            repository = product;
        }
        public IActionResult Index()
        {
            return View(repository.Products);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
