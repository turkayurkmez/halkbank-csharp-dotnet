using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsStock { get; set; }

    }

    public class ProductService
    {

        private List<Category> _categories;
        public ProductService()
        {
            createCategories();
        }
        public List<Product> GetProducts() =>
            new List<Product>()
            {
                new(){ Id=1, Name = "UPS", Description="Elektrik kesintisi...", Price=50000,  Stock=10, IsStock= true, Category= _categories[1]},
                new(){ Id=2, Name = "Jeneratör", Description="Elektrik kesintisi...", Price=150000, Stock=120, IsStock=true,  Category= _categories[1]},
                new(){ Id=3, Name = "Sunucu sistemleri", Description="Data center için..", Price=50000,  Stock=0, IsStock=false, Category= _categories[2]},
                new(){ Id=4, Name = "Oda tipi soğutucu", Description="Soğuk Hava Deposu", Price=25000,  Stock=10,IsStock=true, Category= _categories[2]},
                new(){ Id=5, Name ="Telefon A", Description="Android", IsStock= true, Price=8500, Category = _categories[0]},
                new(){ Id=6, Name ="Telefon B", Description="Android", IsStock= true, Price=10500, Category = _categories[0]},
                new(){ Id=7, Name ="Telefon C", Description="IoS", IsStock= true, Price=78500, Category = _categories[0]},
                new(){ Id= 8, Name ="Telefon D", Description="Android", IsStock= true, Price=12500, Category = _categories[0]},
                new(){ Id= 9, Name ="Tekstil X", Description="Tişört", IsStock= true, Price=500, Category = _categories[4]},



            };

        private void createCategories()
        {
            _categories = new List<Category>()
            {
                new(){ Id=1, Name="Telefon"},
                new(){ Id=2, Name="Enerji"},
                new(){ Id=3, Name="Data Center"},
                new(){ Id=4, Name="Kozmetik"},
                new(){ Id=5, Name="Tekstil"}
            };

        }

    }
}
