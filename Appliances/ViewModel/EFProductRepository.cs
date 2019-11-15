using Appliances.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.ViewModel
{
    public class EFProductRepository :IProduct
    {
        private ApplicationContext context;
        public EFProductRepository(ApplicationContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}
