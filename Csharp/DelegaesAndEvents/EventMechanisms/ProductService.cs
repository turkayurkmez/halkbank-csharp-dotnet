using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanisms
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductCreatedEventArgs : EventArgs
    {
        public Product Product { get; set; }
        public string User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class ProductService
    {

        // public delegate void CreatedEventHandler(object sender, ProductCreatedEventArgs e);
        public event EventHandler<ProductCreatedEventArgs> Created;
        public void Create(Product product)
        {
            //db'ye eklendikten sonra, olay fırlatmak istiyorsunuz.
            var eventArgs = new ProductCreatedEventArgs
            {
                Product = product,
                CreatedDate = DateTime.Now,
                User = "turkay"
            };

            onCreated(eventArgs);
        }

        private void onCreated(ProductCreatedEventArgs eventArgs)
        {
            if (Created != null)
            {
                Created(this, eventArgs);
            }
        }
    }
}
