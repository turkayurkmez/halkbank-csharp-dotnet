using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {

        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(value)} parametresinin değeri negatif olamaz");
            }

            this.price = value;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsStock { get; private set; } = true;

        public void DecreaseStock(int count)
        {
            StockCount -= count;
            if (StockCount <= 0)
            {
                IsStock = false;
            }
        }

        //Yaptığım şey mantıklı değil. Amaç write-only özellik göstermek:
        public string EmailAddress { private get; set; }



    }
}
