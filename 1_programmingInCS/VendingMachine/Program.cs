using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmingInCS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint input = 0 , change = 0, sodaPrice = 35;
            bool isValid = true;

            Console.WriteLine("Welcome to the .NET C# Soda Vending Machine");
            Console.WriteLine("Please insert 35c: ");

            try
            {
                do
                {
                    input += MethodWithThrows.PetzoldParse(Console.ReadLine());

                    if (input > sodaPrice)
                        change = input - sodaPrice;

                    if (input < sodaPrice)
                        Console.WriteLine("You need another {0} cents", sodaPrice - input);
                    
                } while (input < sodaPrice);
                
                Console.WriteLine("You have inserted {0} cents", input);
            }

            catch (Exception exc)
            {    
                Console.WriteLine("Tampering detected! You get no soda");
                isValid = false;
            }

            Console.WriteLine(isValid? "\nYour change: {0} cents" +
                "\nThanks!  Here is your soda" : "", change);
            Console.ReadLine();

        }
    }
}
