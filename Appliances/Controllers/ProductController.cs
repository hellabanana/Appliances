using Appliances.Models;
using Appliances.ViewModel;
using Appliances.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Appliances.Controllers
{
    public class ProductController:Controller
    {
        private IProduct repository;
        public int PageSize = 4;
        public ProductController(IProduct repos)
        {
            repository = repos;
        }

        public ViewResult ViewProduct(int ProductPage = 1) => View(new ProductListViewModel
        {
            Products = repository.Products
            .OrderBy(p => p.Id)
            .Skip((ProductPage - 1) * PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo { CurrentPage = ProductPage, ItemsPerPage = PageSize, Totalitems = repository.Products.Count() }
        });




    }
}
