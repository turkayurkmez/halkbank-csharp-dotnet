namespace eshop.MVC.Models
{
    public class ProductCardCollection
    {
        public List<ProductItemViewModel> ProductItems { get; set; } = new List<ProductItemViewModel>();

        public void Add(ProductItemViewModel productItemViewModel)
        {
            var existingProduct = ProductItems.FirstOrDefault(p => p.Product.Id == productItemViewModel.Product.Id);
            if (existingProduct != null)
            {
                existingProduct.Quantity += productItemViewModel.Quantity;
            }
            else
            {
                ProductItems.Add(productItemViewModel);
            }
        }

        public void Clear() => ProductItems.Clear();

        public void Remove(ProductItemViewModel productItemViewModel) => ProductItems.RemoveAll(p => p.Product.Id == productItemViewModel.Product.Id);

        public decimal GetTotalPrice() => ProductItems.Sum(p => p.Quantity * p.Product.Price);


        public int GetCount() => ProductItems.Sum(p => p.Quantity);




    }
}
