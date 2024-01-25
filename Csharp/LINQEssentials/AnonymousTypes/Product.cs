using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class ProductService
    {
        public List<Product> GetProducts() =>
            new List<Product>()
            {
                new(){ Name = "UPS", Description="Elektrik kesintisi...", Price=50000, CategoryName="Enerji", Stock=10},
                new(){ Name = "Jeneratör", Description="Elektrik kesintisi...", Price=150000, CategoryName="Enerji", Stock=120},
                new(){ Name = "Sunucu sistemleri", Description="Data center için..", Price=50000, CategoryName="DataCenter", Stock=10},
                new(){ Name = "Oda tipi soğutucu", Description="Soğuk Hava Deposu", Price=25000, CategoryName="Soğuk...", Stock=10}

            };

    }
}
