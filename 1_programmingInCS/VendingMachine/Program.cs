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
            testRack.RemoveACanOf("orange");
            testRack.DisplayCanRack();
            testRack.RemoveACanOf("nofoundflavor");
            testRack.DisplayCanRack();
            Console.ReadLine();
        }
    }
}
