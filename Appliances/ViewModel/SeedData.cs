using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Appliances.Models;

namespace Appliances.ViewModel
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder app)
        {
            ApplicationContext context = app.ApplicationServices
                .GetRequiredService<ApplicationContext>();
            context.Database.Migrate();
 
                context.Products.AddRange(
                    new Product
                    {
                       
                        Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                        Name = "Холодильник 1",
                        Price = 156,
                        Description = "Lorem Ipsum"
                        ,Category="Холодильники"
                    },
            new Product
            {
                
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 2",
                Price = 315,
                Description = "Lorem Ipsum",
                Category = "Холодильники"
            }, new Product
            {
                
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 3",
                Price = 156,
                Description = "Lorem Ipsum",
                Category = "Холодильники"
            },
            new Product
            {
                
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 4",
                Price = 315,
                Description = "Lorem Ipsum",
                Category = "Холодильники"
            }, new Product
            {
                
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 5",
                Price = 156,
                Description = "Lorem Ipsum",
                Category = "Холодильники"
            },
            new Product
            {
               
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 6",
                Price = 315,
                Description = "Lorem Ipsum",
                Category = "Холодильники"
            },
            new Product
            {

                Image = "https://tehnoplus.by/image/cache/data/prd/1488495/0-960x720.jpg",
                Name = "Кофеварка Philips EP5040/10 LatteGo Premium Series 5000",
                Price = 1416,
                Description = "Lorem Ipsum",
                Category = "Кофеварки"
            },
            new Product
            {

                Image = "https://tehnoplus.by/image/cache/data/prd/1488495/0-960x720.jpg",
                Name = "Кофеварка Philips EP5040/10 LatteGo Premium Series 5000",
                Price = 1416,
                Description = "Lorem Ipsum",
                Category = "Кофеварки"
            },
            new Product
            {

                Image = "https://tehnoplus.by/image/cache/data/prd/1488495/0-960x720.jpg",
                Name = "Кофеварка Philips EP5040/10 LatteGo Premium Series 5000",
                Price = 1416,
                Description = "Lorem Ipsum",
                Category = "Кофеварки"
            }
                    );
                context.SaveChanges();
            

        }
    }
}
