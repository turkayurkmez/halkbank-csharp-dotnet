using eshop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.DataAccess.DataContext
{
    public class EshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EshopDbContext(DbContextOptions<EshopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API

            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                              .HasMaxLength(150);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Elektronik" },
                new Category() { Id = 2, Name = "Tekstil" },
                new Category() { Id = 3, Name = "Kırtasiye" }

                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Akıllı Saat",
                    CategoryId = 1,
                    Description = "Apple",
                    ImageUrl = "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg",
                    Price = 4000,
                    Stock = 150
                },
                 new Product()
                 {
                     Id = 2,
                     Name = "Samsung A51",
                     CategoryId = 1,
                     Description = "Android",
                     ImageUrl = "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg",
                     Price = 3500,
                     Stock = 120
                 },
                  new Product()
                  {
                      Id = 3,
                      Name = "Tişört",
                      CategoryId = 2,
                      Description = "LCW",
                      ImageUrl = "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg",
                      Price = 4000,
                      Stock = 150
                  },
                   new Product()
                   {
                       Id = 4,
                       Name = "Defter seti",
                       CategoryId = 3,
                       Description = "Defterler",
                       ImageUrl = "https://cdn.dsmcdn.com/ty1005/product/media/images/prod/PIM/20230929/05/970e9a76-4ce0-4aed-81ce-7b4b8123736a/1_org_zoom.jpg",
                       Price = 400,
                       Stock = 150
                   }
                );

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    //Aşağıdaki açık bağlantı cümlesi yerine, appSettings.json dosyasına yazdık.
        //    //optionsBuilder.UseSqlServer("Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=eshopdbForHalkbank;Integrated Security=True");

        //}
    }
}
