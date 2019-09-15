using Microsoft.EntityFrameworkCore;
using DemoProject.Models;


namespace DemoProject.Entities
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ProductViewModel> Products { get; set; }
        //public DbSet<STORE> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductViewModel>().HasData(
                new ProductViewModel
                {
                    Id = 1,
                    Name = "Intel Core I9-9900K",
                    ProductType= "Processors",
                    Brand="Intel",
                    Price = 500,
                    Stock = 5
                },
                new ProductViewModel
                {
                    Id = 2,
                    Name = "AMD Ryzen 7 3800X",
                    ProductType = "Processors",
                    Brand = "AMD",
                    Price = 399,
                    Stock = 6
                },
                new ProductViewModel
                {
                    Id = 3,
                    Name = "Intel Core I5-9400",
                    ProductType = "Processors",
                    Brand = "Intel",
                    Price = 165,
                    Stock = 15
                },
                 new ProductViewModel
                 {
                     Id = 4,
                     Name = "AMD Ryzen 5 2600X",
                     ProductType = "Processors",
                     Brand = "AMD",
                     Price = 146.40m,
                     Stock = 8
                 },
                  new ProductViewModel
                  {
                      Id = 5,
                      Name = "MSI Gaming GeForce RTX 2070 Super 8GB",
                      ProductType = "Graphic Card",
                      Brand = "MSI",
                      Price = 509.99m,
                      Stock = 2
                  },
                   new ProductViewModel
                   {
                       Id = 6,
                       Name = "MSI Gaming Radeon RX 5700 XT",
                       ProductType = "Graphic Card",
                       Brand = "XFX",
                       Price = 349.99m,
                       Stock = 9
                   }
            );
        }


    }
}
