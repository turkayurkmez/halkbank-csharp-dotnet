// See https://aka.ms/new-console-template for more information
using AnonymousTypes;

Console.WriteLine("Hello, World!");

var aNumber = 8;
var aWord = "elektrik";

var random = new Random();

var product = new { Ad = "Mouse", Fiyat = 2000 };

var products = new ProductService().GetProducts();

var spesificProducts = from p in products
                       select p;

spesificProducts.ToList().ForEach(p => Console.WriteLine(p.CategoryName));

//select Name, Price from products



showDetails(product);

void showDetails(object product)
{
    Console.WriteLine(product);
    dynamic anonProduct = product;

    Console.WriteLine(anonProduct.Ad);
}