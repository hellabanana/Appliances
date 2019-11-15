using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appliances.Models;
using Microsoft.AspNetCore.Mvc;

namespace Appliances.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products {get; set;}
        public PagingInfo Paginglnfo { get; set; } 
    }
}