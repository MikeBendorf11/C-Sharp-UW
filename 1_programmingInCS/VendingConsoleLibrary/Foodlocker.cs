using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingConsoleLibrary
{
    public class FoodLocker
    {
        int size;
        public FoodLocker()
        {
            Size = 10;
            Store = new List<Snack>(Size);
        }
        public int Size
        {
            set { size = value; }
            get { return size; }
        }
        public List<Snack> Store;
        public void Stock()
        {
            Banana theBanana = new Banana(
                "Chiquita", 1.10m, DateTime.Today.AddDays(5)
                );
            Apple theApple = new Apple(
                "Fuji", 2.00m, DateTime.Today.AddDays(10)
                );
            CandyBar theCandyBar = new CandyBar("Buster", 2.25m, 2000);
            PotatoChips thePotatoChips = new PotatoChips("Lays", 1.90m, 1500);
            Random rd = new Random(2);
            List<Snack> allSnacks = new List<Snack>
            {
                new Banana("Chiquita", 1.10m, DateTime.Today.AddDays(5)),
                new Apple("Fuji", 2.00m, DateTime.Today.AddDays(10)),
                new CandyBar("Buster", 2.25m, 2000),
                new PotatoChips("Lays", 1.90m, 1500)
            };
        }
    }
}
