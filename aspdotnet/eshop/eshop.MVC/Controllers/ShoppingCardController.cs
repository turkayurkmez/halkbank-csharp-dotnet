using eshop.MVC.Extensions;
using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace eshop.MVC.Controllers
{
    public class ShoppingCardController : Controller
    {
        private readonly IProductService productService;

        public ShoppingCardController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add(int id)
        {
            //bu id değerinde gerçekten de ürün var mı?
            var product = await productService.GetProductAsync(id);

            if (product != null)
            {

                //sepet, bir koleksiyondur. Buradaki ürün sepete eklenecek elemanı oluşturmalıdır.
                //sepet Session içinde tutulmalı.
                ProductCardCollection productCardCollection = getCardCollectionFromSession();
                var productItem = new ProductItemViewModel { Product = product, Quantity = 1 };
                productCardCollection.Add(productItem);
                saveToSession(productCardCollection);

                return Json(new { message = $"{product.Name} ürünü sepete eklendi!" });
            }

            return NotFound(new { detail = $"{id} id'li ürün db'de bulunamadı" });


        }

        private void saveToSession(ProductCardCollection productCardCollection)
        {
            //HttpContext.Session.SetString("shop", JsonConvert.SerializeObject(productCardCollection));
            HttpContext.Session.SetJson("shop", productCardCollection);
        }

        private ProductCardCollection getCardCollectionFromSession()
        {
            //Session  yoksa; yeni ProductCardCollection instance'i oluştur ve session'a ekle
            //         varsa; içindeki ProductCardCollection instance'ini kullan
            //       

            //if (HttpContext.Session.GetString("shop") == null)
            //{
            //    ProductCardCollection productCardCollection = new ProductCardCollection();
            //    HttpContext.Session.SetString("shop", JsonConvert.SerializeObject(productCardCollection));

            //}


            //var json = HttpContext.Session.GetString("shop");
            //return JsonConvert.DeserializeObject<ProductCardCollection>(json);

            var collection = HttpContext.Session.GetJson<ProductCardCollection>("shop");
            return collection;


        }
    }
}
