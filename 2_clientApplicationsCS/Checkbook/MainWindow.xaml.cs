using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Checkbook
{
    public partial class MainWindow : Window 
    {
        Transaction selectedTransac;
        TransactionList transactionList = new TransactionList();
        CategoryList categoryList;

        //used for binding with MainWindowXaml.lbtransactions
        public TransactionList Transactions
        {
            get { return transactionList; }
            set { transactionList = value; }
        }

       public Transaction SelectedTransaction
        {
            get
            {
                return selectedTransac;
            }
            set
            {
                if (lbTransactions.SelectedIndex < 0) return;
                selectedTransac = transactionList[lbTransactions.SelectedIndex];
                lblAmountString.Content = selectedTransac.AmountString;
                selectedTransac.NotifyChanged("AmountString");
            }
        }



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //lbTransactions.ItemsSource = transactionList; //xaml will do it
            lblBalance.Content = transactionList.Balance.ToString("C");

            categoryList = new CategoryList(transactionList);
            lbCategories.ItemsSource = categoryList;
        }

        private void lbTransactions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbTransactions.ItemsSource != null)
            {
                if (lbTransactions.SelectedIndex < 0) lbTransactions.SelectedIndex = 0;
                int index = lbTransactions.SelectedIndex;
                Transaction tr = transactionList[index];
                tbId.Text = tr.Id.ToString();
                tbType.Text = tr.Type.ToString();
                tbDescription.Text = tr.Description;
                tbDate.Text = tr.Date.ToShortDateString();
                //lblAmountString.Content = tr.AmountString; //done by xaml binding
                tbAmount.Text = tr.Amount.ToString("C");
                tbCategory.Text = tr.Category;
                tbCheckNum.Text = tr.Checknum;
            }
        }

        private void bttnEdit_Click(object sender, RoutedEventArgs e)
        {
            //show EditTransaction
            if (lbTransactions.SelectedIndex < 0) lbTransactions.SelectedIndex = 0;
            int index = lbTransactions.SelectedIndex;

            EditTransaction editTransac = new EditTransaction(transactionList[index], categoryList);

            //Manually update display after changes: Toggle source
            if (editTransac.ShowDialog() == true )
            {
                lbTransactions.ItemsSource = null;   
                lbTransactions.ItemsSource = transactionList;
                lbTransactions.SelectedIndex = 0;
                
                categoryList.Refresh();
                lbCategories.ItemsSource = null;
                lbCategories.ItemsSource = categoryList;
            }
        }
    }
}
