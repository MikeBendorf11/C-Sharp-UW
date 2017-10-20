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
        private int _price;
        private decimal _dprice;

        //constructors
        public PurchasePrice() { }

        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        //properties
        public int Price
        {
            set
            {
                if (value > 0)
                    _price = value;
            }
            get { return _price; }
        }

        public decimal PriceD
        {
            set
            { 
              _dprice = _price/100;
            }
            get { return _dprice; }
        }
    }
}
