using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class PurchasePrice
    {
        // This constructor sets the purchase price to zero 
        public PurchasePrice() {
            Price = 0;
        }

        // This constructor allows a new purchase price to be set by the user 
        public PurchasePrice(int initialPrice) {
            Price = initialPrice;
        }

        //  This property gets and sets the value the purchase price. 
        public int Price;
    }
}
