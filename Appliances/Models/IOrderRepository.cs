using System.Linq;

namespace Appliances.Models
{
    public interface IOrderRepository
    {

        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
