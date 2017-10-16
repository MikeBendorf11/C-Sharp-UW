using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //Sets the Price of
    class PurchasePrice
    {
        public PurchasePrice() {
            Price = 0;
        }

        public PurchasePrice(int initialPrice) {
            Price = initialPrice;
        }

        public int Price;
    }
}
