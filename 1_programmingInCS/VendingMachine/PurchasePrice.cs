using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Sets the Price of a Flavor
    class PurchasePrice
    {
        int price;

        public PurchasePrice() {
            Price = 0;
        }

        public PurchasePrice(int initialPrice) {
            Price = initialPrice;
        }

        //Property: A 'price' controlled field 
        public int Price
        {
            set
            {
                if (value > 0)
                price = value;
            }
            get
            {
                return price;
            }
        }
    }
}
