// See https://aka.ms/new-console-template for more information
using LINQSamples;
using System.Linq.Expressions;
using System.Reflection.Metadata;

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


#region LINQ Örnekleri

var allPoducts = new ProductService().GetProducts();
var cheapestProducts = allPoducts.Where(p => p.Price <= 10500)
                                 .OrderBy(p => p.Price);
Console.WriteLine("10500 TL'den ucuz ürünler:");
Console.WriteLine("---------------------------");
cheapestProducts.ToList().ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Description}\t{p.Category.Name}"));

var product = allPoducts.FirstOrDefault(p => p.Description.Contains("Android"), new Product { Description = "Bu kategoride ürün yok!" });
Console.WriteLine("Açıklamasında Android olan ilk ürün:");
Console.WriteLine("-------------------------------------------");
Console.WriteLine($"{product?.Name}\t{product?.Price}\t{product?.Description}\t{product?.Category?.Name}");

Console.WriteLine();
Console.WriteLine("SingleOrDefault demo");
Console.WriteLine("-----------------------");
var singleProduct = allPoducts.SingleOrDefault(p => p.Id == 3, new Product { Description = "Bu kategoride ürün yok!" });

Console.WriteLine($"{singleProduct?.Name}\t{singleProduct?.Price}\t{singleProduct?.Description}\t{singleProduct?.Category?.Name}");
#endregion


Console.WriteLine("Açıklamasına ve sonra fiyata göre ürünler:");
Console.WriteLine("-----------------------------------------------------");
allPoducts.Where(p => p.Category.Name.Contains("Telefon"))
          .Select(p => new { p.Name, p.Price, p.Description, CategoryName = p?.Category?.Name })
          .OrderByDescending(p => p.Description)
          .ThenByDescending(p => p.Price)

          .ToList()

          .ForEach(p => Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Description}\t{p.CategoryName}"));



/* SELECT * FROM Products 
 * WHERE Products.Category.Name = "Telefon"
 * ORDER BY Description DESC
 * ORDER BY Price ASC
*/

var totalPrice = allPoducts.Sum(p => p.Price);
var averagePrice = allPoducts.Average(p => p.Price);
Console.WriteLine("Toplam Fiyat\tOrtalama Fiyat\tMaksimum\tMinimum");
Console.WriteLine($"{totalPrice}.....\t{Math.Ceiling(averagePrice)}.........\t{allPoducts.Max(p => p.Price)}.....\t{allPoducts.Min(p => p.Price)}");

Console.WriteLine("En pahalı ürün:");
Console.WriteLine("-------------------");
var expensiveProduct = allPoducts.FirstOrDefault(p => p.Price == allPoducts.Max(p => p.Price));
Console.WriteLine($"{expensiveProduct.Name}\t{expensiveProduct.Price}");

var expensiveAfterdotnet6 = allPoducts.MaxBy(p => p.Price);
Console.WriteLine($"{expensiveAfterdotnet6.Name}\t{expensiveAfterdotnet6.Price}");

Console.WriteLine("Maksimum");
Console.WriteLine($"{allPoducts.Max().Price}");

//var categories = new ProductService().GetCategories();

//var anotherAllProducts = new ProductService().GetProducts();


var phone = new Category() { Id = 1, Name = "Phone" };
var wearing = new Category() { Id = 2, Name = "Wearing" };
var electronic = new Category() { Id = 3, Name = "Electronic" };

List<Category> categories = new() { phone, wearing, electronic };
List<Product> anotherProducts = new()
{
      new(){ Id=5, Name ="Telefon A", Description="Android", IsStock= true, Price=8500,  Category = phone, CategoryId=1},
      new(){ Id=6, Name ="Telefon B", Description="Android", IsStock= true, Price=10500, Category = phone,CategoryId=1},
      new(){ Id=7, Name ="Telefon C", Description="IoS", IsStock= true, Price=78500, Category = phone,CategoryId=1},
      new(){ Id= 8, Name ="Telefon D", Description="Android", IsStock= true, Price=12500, Category = phone, CategoryId = 1},
      new(){ Id= 9, Name ="Tekstil X", Description="Tişört", IsStock= true, Price=500, Category = wearing,CategoryId=2},
      new(){ Id= 10, Name ="Tekstil Y", Description="Pantolon", IsStock= true, Price=700, Category = wearing,CategoryId=2},
      new(){ Id= 11, Name ="Isıtıcı", Description="Yağlı petek", IsStock= true, Price=3500, Category = electronic,CategoryId=3},
      new(){ Id= 11, Name ="Isıtıcı", Description="Yağlı petek", IsStock= true, Price=3500, Category = electronic,CategoryId=3}
};


var joinQuery = categories.Join(
                                inner: anotherProducts,
                                outerKeySelector: category => category.Id,
                                innerKeySelector: product => product.CategoryId,
                                resultSelector: (category, product) => new
                                {
                                    KategoriAdi = category.Name,
                                    UrunAdi = product.Name,
                                    Fiyat = product.Price
                                }
                                ).ToList();



Console.WriteLine("JOIN sonucu:");
Console.WriteLine("......................");
foreach (var item in joinQuery)
{
    Console.WriteLine($"{item.KategoriAdi}\t{item.UrunAdi}");
}

Console.WriteLine("Alternatif:");
Console.WriteLine("-------------------------");
anotherProducts.Select(p => new { ProductName = p.Name, CategoryName = p.Category.Name })
               .ToList()
               .ForEach(p => Console.WriteLine($"{p.CategoryName}\t{p.ProductName}"));


/*
 *  Bir musteri nesnesi ve müşteri koleksiyonunuz var.
 *  Eğer hangi ülkede kaç müşteri olduğunu merak ederseniz; 
 *  Group by ile Ülkeye göre iki gruba ayırırsınız.
 *   
 *     Ülke   Müşteri Sayısı
 *    -------------------------
 *    Türkiye      570
 *    Azerbaycan   400
 *    Kırgızistan  30
 */

//Tüm ürünleri, açıklamalarına göre gruplamak istiyorum.
/*
 * SELECT Description, Count(Id) 
 * FROM Products
 * GROUP BY Description
 */

var groupByQuery = anotherProducts.GroupBy(keySelector: p => p.Description,
                                          elementSelector: element => new { element.Name, element.Price },
                                          resultSelector: (key, products) => new
                                          {
                                              Key = key,
                                              Count = products.Count(),
                                              MaxPrice = products.Max(p => p.Price),
                                              Total = products.Sum(p => p.Price),
                                              Average = products.Average(p => p.Price)
                                          });

Console.WriteLine("Açıklamaya göre guplanmış çıktı:");
Console.WriteLine("-----------------------------");
foreach (var grouping in groupByQuery)
{
    Console.WriteLine($"{grouping.Key}\t{grouping.Count}\t{grouping.MaxPrice}\t{grouping.Total}\t{grouping.Average}");
}


var chunkedProducts = anotherProducts.Chunk(3);

Console.WriteLine(chunkedProducts.Count());
var distinctSample = anotherProducts.DistinctBy(x => x.Description);
Console.WriteLine("Distinct result");
distinctSample.ToList().ForEach(p => Console.WriteLine(p.Description));