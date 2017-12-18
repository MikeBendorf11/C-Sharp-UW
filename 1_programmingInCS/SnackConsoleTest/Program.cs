using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingConsoleLibrary;

namespace SnackConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodLocker theFoodlocker = new FoodLocker();
            theFoodlocker.Stock();
            foreach (Snack s in theFoodlocker.Store)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
