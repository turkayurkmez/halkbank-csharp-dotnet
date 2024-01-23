
using Encapsulation;

Console.WriteLine("Hello, World!");
Product product = new Product();
//product.Price = -5;
product.SetPrice(15);
Console.WriteLine(product.GetPrice());

product.Description = "Test...";
Console.WriteLine($"Açıklama: {product.Description} ");
product.StockCount = 5;
product.DecreaseStock(5);
Console.WriteLine(product.StockCount);
if (!product.IsStock)
{
    Console.WriteLine("Stoktta kalmadı");
}
