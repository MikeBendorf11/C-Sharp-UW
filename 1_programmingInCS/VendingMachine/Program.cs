using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyVendingMachine
{
    class Program
    {
        private const int SEEDCOINS = 20;
        static Coin sl = new Coin(Denomination.SLUG);
        static Coin nk = new Coin(Denomination.NICKEL);
        static Coin dm = new Coin(Denomination.DIME);
        static Coin qt = new Coin(Denomination.QUARTER);
        static Coin hd = new Coin(Denomination.HALFDOLLAR);

        static void Main(string[] args)
        {
            //one price for every flavor
            Dictionary<Flavor, PurchasePrice> FlavorPrice = new Dictionary<
                Flavor, PurchasePrice>();
            FlavorPrice.Add(Flavor.REGULAR, new PurchasePrice(1.6m));
            FlavorPrice.Add(Flavor.ORANGE, new PurchasePrice(155));
            FlavorPrice.Add(Flavor.LEMON, new PurchasePrice(1.8m));

            List<Coin> seedList = new List<Coin>();

            for (int i = 0; i < SEEDCOINS; i++)
                {
                    seedList.Add(nk);
                    seedList.Add(dm);
                    seedList.Add(qt);
                    seedList.Add(hd);
                }               
            CoinBox myBox = new CoinBox(seedList);
    
            
            decimal canPrice, iptMoney;
            CanRack RackOne = new CanRack();

            RackOne.RemoveACanOf("JHS(Jsa");
            

            const string EXITCODE = "EXIT";

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            while (true)
            {
                iptMoney = 0;
                string iptSoda;
                            
                Console.WriteLine("\n* Exit or pick your flavor? " +
                    "(Regular, Orange, Lemon): ");

                //flavor ipt validation
                Flavor flv;
                while(true)
                {
                    try
                    {
                        iptSoda = Console.ReadLine().ToUpper();
                        if (iptSoda == EXITCODE)
                        {
                            Console.WriteLine("Bye...");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        flv = (Flavor)Enum.Parse(typeof(Flavor), iptSoda);
                        break;
                    }
                    catch (System.ArgumentException e)
                    {
                        Console.Write("Flavors available: ");
                        foreach (Flavor f in FlavorOps.AllFlavors) Console.Write(f + " ");
                        Console.WriteLine("\n" + e.Message);
                    }
                }
                canPrice = FlavorPrice[flv].PriceDecimal;

                Console.WriteLine("\n* Exit or insert your coins");
                Console.WriteLine("(Nickel, Dime, Quarter, HalfDollar or their Decimal value)");
                Console.WriteLine("{0}: {1:c}", iptSoda, canPrice);

                //Keeps track of coins inserted
                List<Coin> inpMnyLst = new List<Coin>();

                //price ipt validation1
                while (iptMoney < canPrice)
                {
                    Coin aCoin;
                    decimal decVal;
                    string iptStr = Console.ReadLine().ToUpper();
                    
                    if (iptStr == EXITCODE)
                    {
                        foreach (Coin c in inpMnyLst) myBox.Withdraw(c);
                        Console.WriteLine("Bye, your change: {0:c}", iptMoney);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    try
                    {
                        //if not a decimal
                        decVal = Decimal.Parse(iptStr);
                        aCoin = calcCoin(decVal, false); 
                    }
                    catch
                    {
                        //Create a coin using the string
                        aCoin = calcCoin(new Coin(iptStr).ValueOf, false); 
                    }

                    inpMnyLst.Add(aCoin);
                    myBox.Deposit(aCoin);
                    iptMoney += aCoin.ValueOf;
                    if (iptMoney < canPrice)
                        Console.WriteLine("Pending: {0:c}", canPrice - iptMoney);
                }

                //Deliver soda
                RackOne.RemoveACanOf(iptSoda);

                //Deliver change
                for(decimal i = iptMoney; i>canPrice;)
                {
                    Coin c = calcCoin(i-canPrice, true);
                    myBox.Withdraw(c);
                    i -= c.ValueOf;
                }

                Console.WriteLine("**** Have your {0} soda ****", iptSoda);
                Console.WriteLine("**** Your change is {0:c} ****", iptMoney - canPrice);
                RackOne.DisplayCanRack();
            }
        }
        //finds a coin match for the user input
        static Coin calcCoin(decimal input, Boolean isChange)
        {
            if (isChange)
            {
                if (input >= 0.5m) return hd;
                else if (input >= 0.25m) return qt;
                else if (input >= 0.10m) return dm;
                else if (input >= 0.05m) return nk;
                else return sl;
            }
            else
            {
                if (input == 0.5m) return hd;
                else if (input == 0.25m) return qt;
                else if (input == 0.10m) return dm;
                else if (input == 0.05m) return nk;
                else return sl;
            }
            
        }
    }
}
