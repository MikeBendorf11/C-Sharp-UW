using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexXmlIndexerProperty
{
    public class Transaction
    {
        string id;
        string date;
        string type;
        string description;
        string category;
        double amount;
        string checknum;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value;  }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value;  }
        }
        public string Checknum
        {
            get { return checknum; }
            set { checknum = value; }
        }
    }
}
