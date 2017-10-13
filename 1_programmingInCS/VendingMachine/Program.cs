using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace programmingInCS
{
    class Program
    {

        static void Main(string[] args)
        {
            uint input = 0;
            string iptStr;
            uint PurchasePrice = 35;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine("Please insert 35c: ");
                        
            while (input < PurchasePrice)
                input += validateIpt(iptStr = (Console.ReadLine()));

            Console.WriteLine("\nYour change: {0} cents" +
            "\nThanks!  Here is your soda", input - PurchasePrice);
            Console.ReadLine();

        }
        static uint validateIpt(string iptStr)
        {
            uint i;
            if (!UInt32.TryParse(iptStr, out i))
                //can add here more validation conditionals for j values
                Debug.WriteLine("{0} is not a UInt32!", iptStr, 0);
            return i;
        }
    }
}
