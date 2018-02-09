using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Checkbook
{
    /// <summary>
    /// Interaction logic for EditTransaction.xaml
    /// </summary>
    public partial class EditTransaction : Window
    {
        Transaction transaction;
        CategoryList categoryList;

        public EditTransaction(Transaction transaction, CategoryList categoryList)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.categoryList = categoryList;
            tbId.Text = transaction.Id.ToString();
            tbType.Text = transaction.Type.ToString();
            tbDescription.Text = transaction.Description;
            tbDate.Text = transaction.Date.ToShortDateString();
            lblAmountString.Content = transaction.AmountString;
            tbAmount.Text = transaction.Amount.ToString("C");
            //Set a combo box to an specific string value
            cbCategory.SelectedItem = transaction.Category;
            tbCheckNum.Text = transaction.Checknum;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //load categories to cbCategory
            foreach(Category c in categoryList)
                cbCategory.Items.Add(c.Title);

        }

        private void bttnOk_Click(object sender, RoutedEventArgs e)
        {
            //save data and update main
            try
            {
                transaction.Description = tbDescription.Text;
                transaction.Category = cbCategory.SelectedItem.ToString();
                transaction.Date = DateTime.Parse(tbDate.Text);
                transaction.Checknum = tbCheckNum.Text;
                this.DialogResult = true;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Date Format");
            }
            
        }

        private void bttnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
