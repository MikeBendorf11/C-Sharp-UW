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
            uint sodaPrice = 35;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine("Please insert 35c: ");

            while (input < 35)
            {
                uint i;
                while (!UInt32.TryParse(iptStr = (Console.ReadLine()), out i))
                {
                    int j;
                    //can add here more validation conditionals for j values
                    if (Int32.TryParse(iptStr, out j))
                        Debug.WriteLine("No negative input allowed");
                    else
                        Debug.WriteLine("{0} is not a number!", iptStr, 0);
                }
                input += i;
            }

            Console.WriteLine("\nYour change: {0} cents" +
            "\nThanks!  Here is your soda", input - sodaPrice);
            Console.ReadLine();

        }
    }
}
