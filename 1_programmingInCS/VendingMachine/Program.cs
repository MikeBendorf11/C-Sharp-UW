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
            PurchasePrice OrangePrice = new PurchasePrice(325);
            Can OrangeCan = new Can(Flavor.ORANGE);
            CanRack RackOne = new CanRack();

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine("Press enter to start or enter Promo-Code:");
            /*****/
            //test of CanRack.EmptyCanRackOf(enum Flavor)
            if ((iptStr = Console.ReadLine()).Equals("123"))
            {
                RackOne.EmptyCanRackOf(new Can().TheFlavor);
                Console.WriteLine("You get 3 free cans of Regular flavor");
            }

            iptStr = null;
            Console.WriteLine("Please insert {0} to buy Orange: ", OrangePrice.Price);

            //increment until there is enough money
            while (input < OrangePrice.Price)
            {
                input += validateIpt(iptStr = Console.ReadLine());
                if (input < OrangePrice.Price)
                    Console.WriteLine("Missing {0} cents", OrangePrice.Price - input);
            }

            //test of CanRack class
            RackOne.RemoveACanOf(OrangeCan.TheFlavor);
            Debug.WriteLine("End of Remove Test");
            RackOne.FillTheCanRack();

            //the class that implements CanRack is responsible for 
            //testing the methods it intends to run, using the options
            //provided by CanRack
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
