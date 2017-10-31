using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyVendingMachine
{
    public enum Denomination
    { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }
    class Coin
    {
        private const int DUMMYARGUMENT = 0;

        private Denomination _theDenomination;

        // parameterless constructor – coin will be a slug 
        public Coin() 
        {
            Debug.WriteLine("This is a {0} coin", Denomination.SLUG);
           _theDenomination = Denomination.SLUG;
        }

        // parametered constructor – coin will be of appropriate value    
        public Coin(Denomination CoinEnumeral) 
        {
            Debug.WriteLine("This is a {0} coin", CoinEnumeral);
            _theDenomination = CoinEnumeral;
        }

        // takes a string and returns the appropriate enumeral 
        public Coin(string CoinName) 
        {
            Debug.WriteLine("Obtaining value from String");

           CoinName = CoinName.ToUpper();
            if (Enum.IsDefined(typeof(Denomination), CoinName))
                _theDenomination = (Denomination)
                    Enum.Parse(typeof(Denomination), CoinName);
            else
                Debug.WriteLine("Error: {0} is an unknown denomination"
                    , CoinName, DUMMYARGUMENT );
        }

        // parametered constructor – coin will be of appropriate value 
        public Coin(decimal CoinValue)
        {
            Debug.WriteLine("Obtaining value from Decimal");
            int coinInt;
            coinInt = (int)(CoinValue * 100);
            if (Enum.IsDefined(typeof(Denomination), coinInt))
                _theDenomination = (Denomination)coinInt;
            else
                Debug.WriteLine("Error: {0} is an unknown denomination"
                    , CoinValue, DUMMYARGUMENT);
        }

        //  This property will get the monetary value of the coin. 
        public decimal ValueOf
        {
            get { return (decimal)_theDenomination / 100m; }
        }

        //  This property will get the coin name as an enumeral 
        public Denomination CoinEnumeral
        {
            get { return _theDenomination; }
        }

        // Return Enum as a String
        public override string ToString()
        {
            return (Enum.GetName(
                typeof(Denomination), _theDenomination).ToLower());
        }
    }  // end Coin 
}
