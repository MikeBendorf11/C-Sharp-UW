using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace MyVendingMachine
{
    class CoinBox
    {

        private List<Coin> box;

        // constructor to create an empty coin box
        public CoinBox()
        {
            box = new List<Coin>();
        }
        // constructor to create a coin box with some coins in it
        public CoinBox(List<Coin> SeedMoney)
        {
            box = SeedMoney;
            debugShowBox();
        }
        //count the number of coins of an specific denomination
        public int coinCount(Denomination theDenomination)
        {
            Coin c1 = new Coin(theDenomination);
            int q = box.Count(
                c2 => c2.CoinEnumeral == c1.CoinEnumeral);
            return q;
        }
        // put a coin in the coin box
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
            Debug.WriteLine("Added a {0} coin", ACoin.CoinEnumeral, 0);
            debugShowBox();       
        }
       
        
        // take a coin of the specified denomination out of the box
        public Boolean Withdraw(Coin ACoin)
        {
            if (coinCount(ACoin.CoinEnumeral) > 0)
            {
                box.Remove(ACoin);
                Debug.WriteLine("Removed a {0} coin"
                    , ACoin.CoinEnumeral, 0);
                debugShowBox();
                return true;
            }
            else
            {
                Debug.WriteLine("This box doesn't contain any {0}s",
                    ACoin.CoinEnumeral, 0);
                return false;
            }                
        }

        // number of half dollars in the coin box
        public int HalfDollarCount
        {
            get { return coinCount(Denomination.HALFDOLLAR); }
        }
        // number of quarters in the coin box
        public int QuarterCount
        {
            get { return coinCount(Denomination.QUARTER); }
        }
        // number of dimes in the coin box
        public int DimeCount
        {
            get { return coinCount(Denomination.DIME); }
        }
        // number of nickels in the coin box
        public int NickelCount
        {
            get { return coinCount(Denomination.NICKEL); }
        }
        // number of worthless coins in the coin box
        public int SlugCount
        {
            get { return coinCount(Denomination.SLUG); }
        }
        // total amount of money in the coin box
        public decimal ValueOf
        {
            get
            {
                decimal amount = 0;
                foreach (Coin theCoin in box) amount += theCoin.ValueOf;
                return amount;
            }
        }
        public void debugShowBox()
        {
            Debug.Write(String.Format($"Slugs: {SlugCount}, "));
            Debug.Write(String.Format($"Nickels: {NickelCount}, "));
            Debug.Write(String.Format($"Dimes: {DimeCount}, "));
            Debug.Write(String.Format($"Quarters: {QuarterCount}, " ));
            Debug.Write(String.Format($"Halfs: {HalfDollarCount}\n"));
        }
    }
}
