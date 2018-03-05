using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
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
        String connectionString =
    "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Checkbook;Integrated Security=True";

        public EditTransaction(Transaction transaction, CategoryList categoryList)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.categoryList = categoryList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //load categories to cbCategory
            foreach(Category c in categoryList)
                cbCategory.Items.Add(c.Title);

            tbId.Text = transaction.Id.ToString();
            tbType.Text = transaction.Type.ToString();
            tbDescription.Text = transaction.Description;
            tbDate.Text = transaction.Date.ToShortDateString();
            lblAmountString.Content = transaction.AmountString;
            tbAmount.Text = transaction.Amount.ToString("#.00");
            //Set a combo box to an specific string value
            cbCategory.SelectedItem = transaction.Category;
            tbCheckNum.Text = transaction.Checknum;
        }

        private void bttnOk_Click(object sender, RoutedEventArgs e)
        {
            /*type, amount, category, date, and description*/
            string cmdInsert = "UPDATE CheckingTransaction SET TransactionType=@TransactionType, " + "Amount=@Amount, Category=@Category, TransactionDate=@TransactionDate ," + "Description=@Description WHERE TransactionId=@TransactionId";

            //save data and update main
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(cmdInsert, conn);
                try
                {
                    conn.Open();
                    int id = int.Parse(tbId.Text);
                    int type = 3; //any value greater than 2 will report error later
                    switch (tbType.Text.ToUpper())
                    {
                        case "CHECK": type = (int)TransactionType.Check; break;
                        case "DEBIT": type = (int)TransactionType.Debit; break;
                        case "DEPOSIT": type = (int)TransactionType.Deposit; break;
                    }
                    string category = cbCategory.SelectedItem.ToString();
                    DateTime date = DateTime.Parse(tbDate.Text);
                    string description = tbDescription.Text;
                    decimal amount = decimal.Parse(tbAmount.Text);
                    string checknum = "";
                    if (tbType.Text.ToUpper() == "CHECK")
                        checknum = tbCheckNum.Text;

                    //Change the current transaction object
                    transaction.Description = description;
                    transaction.Category = category;
                    transaction.Date = date;
                    transaction.Checknum = checknum;
                    transaction.Amount = amount;

                    //Update the db record
                    cmd.Parameters.AddWithValue("TransactionId", id);
                    cmd.Parameters.AddWithValue("TransactionType", type);
                    cmd.Parameters.AddWithValue("Category", category);
                    cmd.Parameters.AddWithValue("TransactionDate", date.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("Description", description);
                    cmd.Parameters.AddWithValue("Amount", amount);
                    cmd.Parameters.AddWithValue("CheckNum", checknum);
                    cmd.ExecuteNonQuery();

                    this.DialogResult = true;
                    this.Close();
                }
                catch (Exception x)
                {
                    Debug.WriteLine("An error ocurred: " + x.Message);
                }
            }
        }

        private void bttnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
