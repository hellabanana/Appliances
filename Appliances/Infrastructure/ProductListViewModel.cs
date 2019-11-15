using System.Collections.Generic;
using Appliances.Models;
using Appliances.ViewModel;

namespace Appliances.ViewModel
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}