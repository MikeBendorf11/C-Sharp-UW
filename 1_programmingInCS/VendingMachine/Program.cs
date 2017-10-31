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
            CanRack RackOne = new CanRack();
            decimal price = 1.50m;
            decimal input;
            string iptPrice = null;
            string iptSoda = null;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            while (true)
            {
                input = 0;
                Console.WriteLine("\nType exit or pick your flavor " +
                    "(Regular, Orange, Lemon): ");

                do
                {
                    iptSoda = Console.ReadLine();
                    if (iptSoda == "exit")
                    {
                        Console.WriteLine("Bye...");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                while (!CanRack.validStr(ref(iptSoda)));

                Console.WriteLine("Type exit or insert {0} to buy a {1}: "
                    , price, iptSoda.ToUpper());

                //price validation
                while (input < price)
                {
                    if (iptPrice == "exit")
                    {
                        input = 0;
                        Console.WriteLine("Have your money, bye...");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    input += validateInputPrice(iptPrice = Console.ReadLine());
                    if (input < price && input != 0)
                        Console.WriteLine("Missing {0} cents", price - input);
                }

                if (RackOne.IsEmpty(iptSoda))
                    RackOne.FillTheCanRack();

                RackOne.RemoveACanOf(iptSoda);
                Console.WriteLine("Have your {0} soda", iptSoda);
                Console.WriteLine("Your change is {0}", input - price);
                RackOne.DisplayCanRack();
            }

            /*testRack.DisplayCanRack();
            testRack.RemoveACanOf("orange");
            testRack.DisplayCanRack();
            
            if(!testRack.IsFull(Flavor.ORANGE))
                testRack.AddACanOf("orange");
            testRack.DisplayCanRack();

            testRack.AddACanOf("RATa");
            testRack.DisplayCanRack();
            testRack.RemoveACanOf("nofoundflavor");
            testRack.DisplayCanRack();*/


        }
        static decimal validateInputPrice(string iptStr)
        {
            decimal i;
            if (!decimal.TryParse(iptStr, out i))
            {
                Debug.WriteLine("{0} is not a decimal!", iptStr, 0);
                return 0;
            }
            return i;
        }
    }
}
