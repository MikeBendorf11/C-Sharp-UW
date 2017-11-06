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

        static void Main(string[] args)
        {
            CoinBox changeBox, myBox;
            List<Coin> seedList = new List<Coin>();
            
            Coin sl = new Coin(Denomination.SLUG);
            Coin nk = new Coin(Denomination.NICKEL);
            Coin dm = new Coin(Denomination.DIME);
            Coin qt = new Coin(Denomination.QUARTER);
            Coin hd = new Coin(Denomination.HALFDOLLAR);

            for (int i = 0; i < SEEDCOINS; i++)
                {
                    seedList.Add(nk);
                    seedList.Add(dm);
                    seedList.Add(qt);
                    seedList.Add(hd);
                }               
            changeBox = new CoinBox(seedList);

            //one price for every flavor
            PurchasePrice rglP = new PurchasePrice(1.60m);
            PurchasePrice orgP = new PurchasePrice(155); // using int
            PurchasePrice lmnP = new PurchasePrice(1.80m);
            
            decimal canPrice, myBoxValueOf;
            CanRack RackOne = new CanRack();
            const string EXITCODE = "EXIT";

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            while (true)
            {
                myBoxValueOf = 0;
                string iptSoda;
                myBox = new CoinBox();
                            
                Console.WriteLine("\n* Exit or pick your flavor? " +
                    "(Regular, Orange, Lemon): ");
                
                //flavor ipt validation
                do
                {
                    iptSoda = Console.ReadLine().ToUpper();
                    if (iptSoda == EXITCODE)
                    {
                        Console.WriteLine("Bye...");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                } while (!CanRack.validStr(iptSoda));

                //find price for this enum
                switch (iptSoda)
                {
                    case "LEMON": canPrice = lmnP.PriceDecimal; break;
                    case "ORANGE": canPrice = orgP.PriceDecimal; break;
                    case "REGULAR": canPrice = rglP.PriceDecimal; break;
                    default: canPrice = 0; break;
                }
                    
                Console.WriteLine("\n* Exit or insert your coins");
                Console.WriteLine("(Nickel, Dime, Quarter, HalfDollar or their Decimal value)");
                Console.WriteLine("{0}: {1:c}", iptSoda, canPrice);
                //##test bellow. Haven't tried value of yet??
                //price ipt validation
                while (myBox.ValueOf < canPrice)
                {
                    Coin aCoin;
                    decimal decVal;
                    string iptStr = Console.ReadLine().ToUpper();
                    
                    if (iptStr == EXITCODE)
                    {
                        Console.WriteLine("Bye, your change: {0:c}", myBox.ValueOf);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    if (Decimal.TryParse(iptStr, out decVal)) //is ipt decimal?
                        aCoin = new Coin(decVal);
                    else
                        aCoin = new Coin(iptStr); //then string

                    changeBox.Deposit(aCoin);
                    
                    if (myBox.ValueOf < canPrice)
                        Console.WriteLine("Pending: {0:c}", canPrice - myBox.ValueOf);
                }

                //Deliver soda
                if (RackOne.IsEmpty(iptSoda))
                    RackOne.FillTheCanRack();

                RackOne.RemoveACanOf(iptSoda);
                Console.WriteLine("**** Have your {0} soda ****", iptSoda);
                Console.WriteLine("**** Your change is {0:c} ****"
                    , myBoxValueOf - canPrice);
                RackOne.DisplayCanRack();
            }
        }
    }
}
