using System.Linq;

namespace Appliances.Models
{
    public interface IProduct
    {
        IQueryable<Product> Products { get; }
        
    }
}
