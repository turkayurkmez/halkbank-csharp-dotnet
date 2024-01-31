using eshop.Services.DataTransferObjects.Response;

namespace eshop.MVC.Models
{
    public class ProductItemViewModel
    {
        public ProductDisplayResponse Product { get; set; }
        public int Quantity { get; set; }
    }


}
