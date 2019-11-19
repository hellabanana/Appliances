using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
    public class EFOrderRepository:IOrderRepository
    {
        private ApplicationContext context;

        public EFOrderRepository(ApplicationContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
