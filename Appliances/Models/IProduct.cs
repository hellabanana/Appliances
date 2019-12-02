using System.Linq;

namespace Appliances.Models
{
    public interface IProduct
    {
        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int Id);
        
    }
}
