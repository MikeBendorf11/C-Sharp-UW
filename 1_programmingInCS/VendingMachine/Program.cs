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
            uint input = 0;
            string iptStr;
            PurchasePrice OrangePrice = new PurchasePrice(50);
            CanRack RackOne = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine("Press enter to start or enter Promo-Code:");

            //test of CanRack class
            if ((iptStr = Console.ReadLine()).Equals("Orange"))
            {
                RackOne.EmptyCanRackOf("Orange");
                Console.WriteLine("You get 3 free cans of Orange");
            }

            iptStr = null;
            Console.WriteLine("Please insert {0} to buy Fanta: ", OrangePrice.Price);

            //increment until there is enough money
            while (input < OrangePrice.Price)
            {
                input += validateIpt(iptStr = Console.ReadLine());
                if (input < OrangePrice.Price)
                    Console.WriteLine("Missing {0} cents", OrangePrice.Price - input);
            }

            //test of CanRack class
            RackOne.RemoveACanOf("Orange");
            Debug.WriteLine("End of Remove Test");
            RackOne.FillTheCanRack();
            if(!RackOne.IsFull("Lemon"))
            RackOne.AddACanOf("Lemon");

            Console.WriteLine("\nYour change: {0} cents" +
             "\nThanks!  Here is your soda", input - OrangePrice.Price);
            Console.ReadLine();

        }

        //Input can only be a unsigned integer
        static uint validateIpt(string iptStr)
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
