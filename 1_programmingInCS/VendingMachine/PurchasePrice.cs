using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVendingMachine
{
    //Sets the Price of a Flavor
    class PurchasePrice
    {
        private decimal _price;

        //constructors
        public PurchasePrice() { }

        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //properties
        public int Price
        {
            set { _price = value / 100m; }
            get { return (int)_price * 100; }
        }

        public decimal PriceDecimal
        {
            set
            { _price = value; }
            get { return _price; }
        }
    }
}
