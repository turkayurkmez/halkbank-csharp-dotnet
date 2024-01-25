// See https://aka.ms/new-console-template for more information
using LINQSamples;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

List<Product> GetProductsByMoreThan(decimal price)
{
    var availableProducts = new List<Product>();
    var products = new ProductService().GetProducts();
    foreach (var product in products)
    {
        if (product.Price > price)
        {
            availableProducts.Add(product);
        }
    }

    return availableProducts;
}

List<Product> GetProductsByMoreThanLinq(decimal price)
{

    var products = new ProductService().GetProducts();
    return (
             from product in products
             where product.Price > price
             orderby product.Name
             select product

            ).ToList();



}
List<Product> GetProductsByMoreThanExtensions(decimal price)
{

    var products = new ProductService().GetProducts();
    return products.Where(product => product.Price > price)
                   .OrderBy(product => product.Name)
                   .ToList();



}
