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
        static void Main(string[] args)
        {
            //one price for every flavor
            PurchasePrice[] FlavorPrice = new PurchasePrice[
                Enum.GetValues(typeof(Flavor)).Length]; 
            FlavorPrice[(int)Flavor.REGULAR] = new PurchasePrice(1.60m);
            FlavorPrice[(int)Flavor.ORANGE] = new PurchasePrice(155); // using int
            FlavorPrice[(int)Flavor.LEMON] = new PurchasePrice(1.80m);
            
            decimal canPrice, iptMoney;
            CanRack RackOne = new CanRack();
            const string EXITCODE = "EXIT";

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");

            while (true)
            {
                iptMoney = 0;
                string iptSoda;
                            
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
                canPrice = FlavorPrice[
                    (int)Enum.Parse(typeof(Flavor), iptSoda)].PriceDecimal;

                Console.WriteLine("\n* Exit or insert your coins");
                Console.WriteLine("(Nickel, Dime, Quarter, HalfDollar or their Decimal value)");
                Console.WriteLine("{0}: {1:c}", iptSoda, canPrice);

                //price ipt validation
                while (iptMoney < canPrice)
                {
                    Coin aCoin;
                    decimal decVal;
                    string iptStr = Console.ReadLine().ToUpper();
                    
                    if (iptStr == EXITCODE)
                    {
                        Console.WriteLine("Bye, your change: {0:c}", iptMoney);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    if (Decimal.TryParse(iptStr, out decVal)) //is ipt decimal?
                        aCoin = new Coin(decVal);
                    else
                        aCoin = new Coin(iptStr); //then string

                    iptMoney += aCoin.ValueOf;
                    if (iptMoney < canPrice)
                        Console.WriteLine("Pending: {0:c}", canPrice - iptMoney);
                }

                //Deliver soda
                if (RackOne.IsEmpty(iptSoda))
                    RackOne.FillTheCanRack();

                RackOne.RemoveACanOf(iptSoda);
                Console.WriteLine("**** Have your {0} soda ****", iptSoda);
                Console.WriteLine("**** Your change is {0:c} ****"
                    , iptMoney - canPrice);
                RackOne.DisplayCanRack();
            }
        }
    }
}
