using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.Controllers
{
    
    public class AdminController : Controller
    {

        public IActionResult Main()
        {
            return View();
        }

        public IActionResult ProductAdd()
        {
            return View();
        }
    }
}