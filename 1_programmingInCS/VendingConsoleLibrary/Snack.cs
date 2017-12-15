using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingConsoleLibrary
{
    public abstract class Snack
    {
        private string name;
        private decimal price;
        public Snack(string name, decimal price)
        {
            Name = name; Price = price;
        }
        public override string ToString()
        {
            return Name + " Price: " + Price + ", ";
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public decimal Price
        {
            set { price = value; }
            get { return price;  }
        }
    }
    public abstract class JunkFood : Snack
    {
        private int caloriesFromFat;
        public JunkFood(string name, decimal price, int calories) :
            base(name, price)
        { CaloriesFromFat = calories; }

        public override string ToString()
        {
            return base.ToString() + "Calories: " + CaloriesFromFat + ", ";
        }
        public int CaloriesFromFat
        {
            set { caloriesFromFat = value; }
            get { return caloriesFromFat; }
        }


    }

    public abstract class HealthFood: Snack
    {
        private DateTime freshUntil;
        public HealthFood(string name, decimal price, DateTime expires) :
            base(name, price)
        { FreshUntil = expires; }
        public override string ToString()
        {
            return  base.ToString() + "Expires: " + FreshUntil.ToShortDateString() + ", ";
        }
        public DateTime FreshUntil
        {
            set { freshUntil = value;  }
            get { return freshUntil; }
        }
    }

    public class CandyBar : JunkFood
    {
        public CandyBar(string name, decimal price, int calories) :
            base(name, price, calories){ }
        public override string ToString()
        {
            return base.ToString() + "makes you hyper";
        }
    }
    public class PotatoChips : JunkFood
    {
        public PotatoChips(string name, decimal price, int calories) :
            base(name, price, calories){ }
        public override string ToString()
        {
            return base.ToString() + "fills you up";
        }
    }
    public class Apple : HealthFood
    {
        public Apple(string name, decimal price, DateTime expires) :
            base(name, price, expires){ }
        public override string ToString()
        {
            return base.ToString() + "crunchy and juicy";
        }
    }
    public class Banana : HealthFood
    {
        public Banana(string name, decimal price, DateTime expires) :
            base(name, price, expires){ }
        public override string ToString()
        {
            return base.ToString() + "sweet and tasty";
        }
    }
}
