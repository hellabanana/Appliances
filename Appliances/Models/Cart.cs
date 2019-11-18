using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Product product,int quantity) {
            CartLine line = lineCollection
                .Where(p => p.product.Id == product.Id).FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    product = product
                ,
                    Quantity = quantity
                });
            }
            else
                line.Quantity += quantity;
        }
        public virtual void RemoveLine(Product product) =>
            lineCollection.RemoveAll(l => l.product.Id == product.Id);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(s => s.product.Price * s.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }

    }
}
