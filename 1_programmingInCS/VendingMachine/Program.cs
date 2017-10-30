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
            CanRack testRack = new CanRack();
            decimal price = 1.50m;
            uint input = 0;
            string iptPrice = null;
            string iptSoda = null;


            while (true)
            {
                Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
                Console.WriteLine("Type exit or pick your flavor "+
                    "(Regular, Orange, Lemon): ");
                //testRack.RemoveACanOf("orange");
                //## test above is valid but bellow is probably not sending a 
                //reference and never considering "orange" a valid input
                //soda validation
                while (!CanRack.validStr(iptSoda = Console.ReadLine()))
                {
                    if (iptSoda == "exit")
                    {
                        Console.WriteLine("Bye...");
                        Environment.Exit(0);
                    }    
                    Console.WriteLine("Invalid Flavor");
                }
                 
                Console.WriteLine("Type exit or insert {0} to buy a {1}: "
                    , price, iptSoda);
                //price validation
                while (input < price)
                {
                    if (iptPrice == "exit" )
                    {
                        Console.WriteLine("Have your money, Bye...");
                        Environment.Exit(0);
                    }    
                    input += validateInputPrice(iptPrice = Console.ReadLine());
                    if (input < price)
                        Console.WriteLine("Missing {0} cents", price - input);
                }

                if (testRack.IsEmpty(iptSoda))
                    testRack.FillTheCanRack();
                else
                {
                    testRack.RemoveACanOf(iptSoda);
                    Console.WriteLine("Have your {0} soda", iptSoda); 
                }
                 
            }



            /*testRack.DisplayCanRack();
            testRack.RemoveACanOf("orange");
            testRack.DisplayCanRack();
            
            if(!testRack.IsFull(Flavor.ORANGE))
                testRack.AddACanOf("orange");
            testRack.DisplayCanRack();

            testRack.AddACanOf("RATa");
            testRack.DisplayCanRack();*/
            //testRack.RemoveACanOf("nofoundflavor");
            //testRack.DisplayCanRack();
            Console.ReadLine();

        }
        static uint validateInputPrice(string iptStr)
        {
            uint i;
            if (!UInt32.TryParse(iptStr, out i))
            {
                Debug.WriteLine("{0} is not a UInt32!", iptStr, 0);
                return 0;
            }
            return i;
        }
    }
}
