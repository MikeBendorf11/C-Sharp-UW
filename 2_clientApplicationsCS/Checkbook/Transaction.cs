using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkbook
{
    public enum TransactionType { Check, Debit, Deposit }
    abstract public class Transaction: INotifyPropertyChanged
    {
        private int id;         // Transaction ID
        private TransactionType type;   // Type of transaction
        private string category;        // Category (Budget)
        private DateTime date;      // Date of transaction
        private string description; // Paid to, taken from...
        private decimal amount;     // The amount (always >0)
        private string checknum;

        // Check # if appropriate
        public int Id
        {
            get { return id; }
            private set { id = value; NotifyChanged("Id"); }
        }
        public TransactionType Type
        {
            get { return type; }
            set { type = value; NotifyChanged("Type");  }
        }
        public string Category
        {
            get { return category; }
            set { category = value; NotifyChanged("Category"); }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; NotifyChanged("Date"); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; NotifyChanged("Description"); }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; NotifyChanged("Amount"); }
        }
        public string Checknum
        {
            get { return checknum; }
            set { checknum = value; NotifyChanged("Checknum"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyChanged(String property) //was private
        {
            if (PropertyChanged != null) //if anybody is listening
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }

        private static int lastId = 0;

        int nextId() { return ++lastId; }

        public override string ToString()
        {
            return Date.ToShortDateString() + "\t" + Type.ToString() + "\t" + Amount.ToString("C");
        }
        // Property creates and returns the amount string 
        public string AmountString
        {
            get
            {
                StringBuilder strAmt = new StringBuilder();
                int dollars = (int)Amount;
                int cents = (int)(Amount * 100 % 100);
                strAmt.Append(amtToString(dollars) + " and " + amtToString(cents, true) + "/100s Dollars");
                strAmt[0] = char.ToUpper(strAmt[0]);
                return strAmt.ToString();
            }
        }

        // Return dollars in text ("Three hundred seventy two"), or if useDigits, return "372" 
        private string amtToString(int amt, bool useDigits = false)
        {
            if (amt == 0) return (useDigits ? "00" : "zero");     
            if (useDigits) return amt.ToString();                

            StringBuilder strAmt = new StringBuilder();          
            int[] groups = { 1000000000, 1000000, 1000, 1 };      

            foreach (int grp in groups)                           
            {
                if (amt < grp) continue;                           
                int v = amt / grp;                                  
                hundredsToString(v, strAmt, grp);                  
                amt = amt % grp;                                    
            }
            return strAmt.ToString();                             
        }

        // Covert a "hundreds" group into text
        // Our number system repeats every 3 digits (thousands, millions, billions, etc)
        private void hundredsToString(int amt, StringBuilder strAmt, int grouping)
        {
            String[] label = { "", "thousand", "million", "billion" }; 
            int group = 0;                       
            if (grouping >= 1000) group++;
            if (grouping >= 1000000) group++;
            if (grouping >= 1000000000) group++;

            if (amt >= 100)                      
            {
                int h = amt / 100;                 
                numberToString(h, strAmt);           
                appendWithSpace(strAmt, "hundred");
                amt = amt % 100;                   
            }
            numberToString(amt, strAmt);          
            appendWithSpace(strAmt, label[group]);
            return;
        }
        // Convert a number (0-999) to a string.
        private void numberToString(int amt, StringBuilder strAmt)
        {
            String[] nums = { "", "one", "two", "three", "four", "five", "six", "seven", "eight",
    "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
    "seventeen", "eighteen", "nineteen" };
            String[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy",
    "eighty", "ninety" };

            if (amt < 20)       
            {
                appendWithSpace(strAmt, nums[amt]);
            }
            else          
            {
                appendWithSpace(strAmt, tens[amt / 10]);
                appendWithSpace(strAmt, nums[amt % 10]);
            }
        }

        // Append a string to the StringBuilder
        private void appendWithSpace(StringBuilder sb, String s)
        {
            if (s.Length == 0) return;             
            if (sb.Length > 0) sb.Append(" ");     
            sb.Append(s);                          
        }

        //why do we need this ???
        public String TransactionSummary { get { return ToString(); } }

        public Transaction(DateTime dateTime, TransactionType type, string
          description, string category, decimal amount, string checknum = "")
        {
            id = nextId();
            Date = dateTime;
            Type = type;
            Description = description;
            Category = category;
            Amount = amount;
            Checknum = checknum;
        }
        public abstract decimal CalculationAmount { get; }



    }

    //These children are the only way to create a Transaction obj
    public class Check : Transaction
    {
        protected const decimal checkCharge = .10M;
        public Check(DateTime dateTime, string description, string category, decimal
          amount, String checknum) : base(dateTime, TransactionType.Check,
          description, category, amount, checknum)
        {
        }
        public override decimal CalculationAmount
        {
            get { return 0 - (Amount + checkCharge); }
        }
    }
    public class Debit : Transaction
    {
        public Debit(DateTime dateTime, string description, string category, decimal
         amount) : base(dateTime, TransactionType.Debit, description, category, amount)
        {
        }
        override public decimal CalculationAmount { get { return 0 - Amount; } }
    }
    public class Deposit : Transaction
    {
        public Deposit(DateTime dateTime, string description, string category, decimal amount) :
           base(dateTime, TransactionType.Deposit, description, category, amount)
        {
        }
        override public decimal CalculationAmount { get { return Amount; } }
    }

}
