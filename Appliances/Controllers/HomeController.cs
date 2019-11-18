using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Appliances.Models;
using Appliances.ViewModel;
using System.Linq;

namespace Appliances.Controllers
{
    public class HomeController : Controller
    {
        private IProduct repository;
        public int PageSize = 4;
        public   HomeController(IProduct product)
        {
            repository = product;
        }

        public ViewResult Index(string Category,int ProductPage = 1) => View(new ProductListViewModel
        {
            Products = repository.Products
              .Where(p => Category == null || p.Category == Category)
              .OrderBy(p => p.Id)
              .Skip((ProductPage - 1) * PageSize)
              .Take(PageSize),
            PagingInfo = new PagingInfo {
                CurrentPage = ProductPage, ItemsPerPage = PageSize, 
                Totalitems = Category==null ? 
                repository.Products.Count(): 
                repository.Products.Where(e=>e.Category==Category).Count() 
            }
            ,CurrentCategory=Category
        });



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
