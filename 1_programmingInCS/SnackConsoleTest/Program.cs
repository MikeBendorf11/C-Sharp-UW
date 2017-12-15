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
            //SNACK TEST
            Banana theBanana = new Banana("Chiquita", 1.10m, DateTime.Today.AddDays(5));
            CandyBar theCandyBar = new CandyBar("Buster", 2.25m, 2000);

            Console.WriteLine(theBanana);
            Console.WriteLine(theCandyBar);
            Console.ReadLine();
        }
    }
}
