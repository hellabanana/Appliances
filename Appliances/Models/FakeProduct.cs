using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
    public class FakeProduct : IProduct
    {
        public IQueryable<Product> Products => new List<Product>() { new Product {
            Id = 1,
            Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            Name="Холодильник 1",
        Price="156",Description="Lorem Ipsum"},
        new Product {
            Id = 2,
            Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            Name="Холодильник 2",
        Price="315",Description="Lorem Ipsum"}}.AsQueryable<Product>();
    }
}
