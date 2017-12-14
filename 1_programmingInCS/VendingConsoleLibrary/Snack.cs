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
            base(name, price) { }
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
        private DateTime FreshUntil;
        public HealthFood() { }
        public override string ToString()
        {
            return "";
        }
    }

    public class CandyBar : JunkFood
    {
        public CandyBar() { }
        public override string ToString()
        {
            return "";
        }
    }
    public class PotatoChips : JunkFood
    {
        public PotatoChips() { }
        public override string ToString()
        {
            return "";
        }
    }
    public class Apple : HealthFood
    {
        public Apple() { }
        public override string ToString()
        {
            return "";
        }
    }
    public class Banana : HealthFood
    {
        public Banana() { }
        public override string ToString()
        {
            return "";
        }
    }
}
