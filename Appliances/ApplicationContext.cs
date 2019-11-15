using Appliances.Models;
using Microsoft.EntityFrameworkCore;

namespace Appliances
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }

        //public DbSet<Category> Categories { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Product>().HasData(
            //        new Product
            //        {
            //            Id = 1,
            //            Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //            Name = "Холодильник 1",
            //            Price = "156",
            //            Description = "Lorem Ipsum"
            //        },
            //new Product
            //{
            //    Id = 2,
            //    Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //    Name = "Холодильник 2",
            //    Price = "315",
            //    Description = "Lorem Ipsum"
            //}, new Product
            //{
            //    Id = 3,
            //    Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //    Name = "Холодильник 3",
            //    Price = "156",
            //    Description = "Lorem Ipsum"
            //},
            //new Product
            //{
            //    Id = 4,
            //    Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //    Name = "Холодильник 4",
            //    Price = "315",
            //    Description = "Lorem Ipsum"
            //}, new Product
            //{
            //    Id = 5,
            //    Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //    Name = "Холодильник 5",
            //    Price = "156",
            //    Description = "Lorem Ipsum"
            //},
            //new Product
            //{
            //    Id = 6,
            //    Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
            //    Name = "Холодильник 6",
            //    Price = "315",
            //    Description = "Lorem Ipsum"
            //}
            //        );


            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";
            Product product = new Product
            {
                Id = 6,
                Image = "https://tehnoplus.by/image/cache/data/prd/1353114/0-960x720.jpg",
                Name = "Холодильник 6",
                Price = "315",
                Description = "Lorem Ipsum"
            };
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { Id = 1, Email = adminEmail, Password = adminPassword, RoleId = adminRole.Id };
            modelBuilder.Entity<Product>().HasData(new Product[] { product });
            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
     }
}
