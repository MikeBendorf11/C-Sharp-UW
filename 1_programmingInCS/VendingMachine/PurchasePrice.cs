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

        public PurchasePrice() { }

        
        //constructors
        public PurchasePrice(int initialPrice)
        {
            Price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceD = initialPrice;
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
                if (value > 0)
                    _dprice = value;
            }
            get { return _dprice; }
        }
    }
}
