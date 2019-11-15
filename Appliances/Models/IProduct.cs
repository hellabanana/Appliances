using Appliances.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
 public interface IProduct
    {
        IQueryable<Product> Products { get; }
        
    }
}
