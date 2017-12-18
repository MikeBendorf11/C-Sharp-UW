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
            Random rd = new Random(3);
            List<Snack> allSnacks = new List<Snack>
            {
                new Banana("Chiquita", 1.10m, DateTime.Today.AddDays(5)),
                new Apple("Fuji", 2.00m, DateTime.Today.AddDays(10)),
                new CandyBar("Buster", 2.25m, 2000),
                new PotatoChips("Lays", 1.90m, 1500)
            };
            for (int i = 0; i < Size; i++)
            {
                int r = rd.Next(0, allSnacks.Count());
                Store.Add(allSnacks[r]);
            }         
        }
    }
}
