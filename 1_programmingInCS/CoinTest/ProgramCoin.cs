using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CoinTest
{
    class ProgramCoin
    {
        static void Main(string[] args)
        {
            Coin StrCoin = new Coin("Pound");
            Debug.WriteLine("1");
            Coin DecCoin = new Coin(1/3m);
            Debug.WriteLine("2");

            Console.WriteLine("Wrong Dec: {0}", DecCoin);
            Debug.WriteLine("3");
            Console.WriteLine("Denom ctor: {0}", new Coin(Denomination.NICKEL));
            Debug.WriteLine("4");
            Console.WriteLine("Str ctor: {0}", new Coin("DimE"));
            Debug.WriteLine("5");
            Console.WriteLine("Dec ctor: {0}", new Coin(0.5m));
            Debug.WriteLine("6");

            Console.WriteLine((new Coin(Denomination.HALFDOLLAR).ValueOf));
            Debug.WriteLine("7");
            Console.WriteLine((new Coin()).CoinEnumeral);
            Debug.WriteLine("8");
            Console.WriteLine((new Coin(Denomination.QUARTER)));
            Debug.WriteLine("9");
            Console.ReadLine();
        }
    }
}
/*
Wrong Dec: slug
Denom ctor: nickel
Str ctor: dime
Dec ctor: slug
0.5
SLUG
quarter
*/