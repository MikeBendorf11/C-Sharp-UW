using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkbook
{
    public class Category : IComparable<Category>
    {
        private string title;
        private decimal amount;
        public Category(string theTitle, decimal theAmount)
        {
            Title = theTitle;
            Amount = theAmount;
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public decimal Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        public override string ToString()
        {
            return Title + "\t" + Amount.ToString("C");
        }

        public int CompareTo(Category other)
        {
            return this.Amount.CompareTo(other.Amount) *-1;
        }
    }

    public class CategoryList : List<Category>
    {
        TransactionList transactionList;
        public CategoryList(TransactionList transactionList)
        {
            this.transactionList = transactionList;
            Refresh();
        }
        public void AddTransaction(Transaction tr)
        {
            foreach(Category c in this)
            {
                if (tr.Category == c.Title)
                {
                    c.Amount += tr.Amount;
                    return;
                }                   
            }
            Add(new Category(tr.Category, tr.Amount));
        }
        public void Refresh()
        {
            Clear();
            foreach (Transaction t in transactionList)
                AddTransaction(t);
            Sort();
        }
    }
}
