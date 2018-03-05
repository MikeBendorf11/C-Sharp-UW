using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Checkbook
{

    public class TransactionList : ObservableCollection<Transaction>
    {
        const int ID = 1;
        const int DATE = 2;
        const int TYPE = 3;
        const int DESCRIPTION = 4;
        const int CATEGORY = 5;
        const int AMOUNT = 6;
        const int CHECKNUM = 8;
        const int TOTALTRS = 10;

        String connectionString =
    "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Checkbook;Integrated Security=True";
        
        public TransactionList()
        {
            if (checkEmptyTable())
            {
                string input = @"<Transactions><Transaction><Id>1</Id><Date>11/23/2014</Date><Type>Deposit</Type><Description>Pay</Description><Category>Income</Category><Amount>1327</Amount></Transaction><Transaction><Id>2</Id><Date>11/24/2014</Date><Type>Check</Type><Description>Food</Description><Category>Food</Category><Amount>62</Amount><Checknum>2021</Checknum></Transaction><Transaction><Id>3</Id><Date>11/24/2014</Date><Type>Debit</Type><Description>ATM</Description><Category>Misc</Category><Amount>40</Amount></Transaction><Transaction><Id>4</Id><Date>11/25/2014</Date><Type>Check</Type><Description>Rent</Description><Category>Rent</Category><Amount>713</Amount><Checknum>2022</Checknum></Transaction><Transaction><Id>5</Id><Date>11/26/2014</Date><Type>Debit</Type><Description>Dinner</Description><Category>Friends</Category><Amount>37.29</Amount></Transaction><Transaction><Id>6</Id><Date>11/26/2014</Date><Type>Debit</Type><Description>Movie</Description><Category>Friends</Category><Amount>12.50</Amount></Transaction><Transaction><Id>7</Id><Date>11/27/2014</Date><Type>Deposit</Type><Description>Mom</Description><Category>Income</Category><Amount>100</Amount></Transaction><Transaction><Id>8</Id><Date>11/28/2014</Date><Type>Check</Type><Description>Costco</Description><Category>Misc</Category><Amount>15.72</Amount><Checknum>2024</Checknum></Transaction><Transaction><Id>9</Id><Date>11/29/2014</Date><Type>Debit</Type><Description>Gas</Description><Category>Gas</Category><Amount>43.83</Amount></Transaction><Transaction><Id>10</Id><Date>11/30/2014</Date><Type>Debit</Type><Description>Market</Description><Category>Food</Category><Amount>35.11</Amount></Transaction></Transactions>";

                Regex pattern = new Regex((@"<Id>(\d*)<\/Id>" +
                                           @"<Date>(\d{2}\/\d{2}\/\d{4})<\/Date>" +
                                           @"<Type>(\w*)<\/Type>" +
                                           @"<Description>(\w*)<\/Description>" +
                                           @"<Category>(\w*)<\/Category>" +
                                           @"<Amount>(\d*\.?\d*)<\/Amount>" +
                                           @"(<Checknum>(\d*)<\/Checknum>)?"));

                MatchCollection matchCollection = pattern.Matches(input);
                Transaction[] theTransac = new Transaction[TOTALTRS];
                DateTime baseDate = new DateTime(1980, 1, 1);
                CultureInfo culture = new CultureInfo("en-US");

                int countTrs = 0;
                
                foreach (Match m in matchCollection)
                {
                    GroupCollection gc = m.Groups;
                    int id = int.Parse(gc[ID].ToString());
                    int type = 3; //any value greater than 2 will report error later
                    switch (gc[TYPE].ToString().ToUpper())
                    {
                        case "CHECK": type = (int)TransactionType.Check;  break;
                        case "DEBIT": type = (int)TransactionType.Debit; break;
                        case "DEPOSIT": type = (int)TransactionType.Deposit; break;
                    }
                    string category = gc[CATEGORY].ToString();
                    DateTime date = Convert.ToDateTime(gc[DATE].ToString(), culture);
                    string description = gc[DESCRIPTION].ToString();
                    decimal amount = decimal.Parse(gc[AMOUNT].ToString());
                    string checknum = "";
                    if(type == (int)TransactionType.Check)
                        checknum = gc[CHECKNUM].ToString();

                    addTransacObj(id, type, category, date, description, amount, checknum);
                    addRecords(id, type, category, date, description, amount, checknum);

                    countTrs++;
                }
            }
            //table is not empty, create TransactionList from it
            else
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CheckingTransaction", conn);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                         while (reader.Read())
                        {
                            int id = (int)reader["TransactionID"];
                            int type = (int)reader["TransactionType"];
                            string category = (string)reader["Category"];
                            DateTime date = (DateTime)reader["TransactionDate"];
                            string description = (string)reader["Description"];
                            decimal amount = (decimal)reader["Amount"];
                            string checknum = (string)reader["CheckNum"];
                            addTransacObj(id, type, category, date, description, amount, checknum);
                        }
                    }
                    catch(Exception e)
                    {
                        Debug.WriteLine("An error ocurred: +", e.Message);
                    }
                }
            }
        }

        //Adds to table when program launches for the first time
        public void addRecords(int id, int type, string category, DateTime date, string description, decimal amount, string checknum)
        {
            string record = "";

            record = String.Format("({0}, {1}, '{2}', '{3}', '{4}', {5}, '{6}')", id, type, category, date.ToString("MM/dd/yyyy"), description, amount.ToString("#.00"), checknum);
            Debug.WriteLine(record);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CheckingTransaction " + "(TransactionId, TransactionType, Category, TransactionDate, " + "Description, Amount, Checknum) values " + record, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("An exception occurred:" + e.Message);
                }
            }
        }

        //Adds to transacitonList using any of the transaction constructors
        public void addTransacObj(int id, int type, string category, DateTime date, string description, decimal amount, string checknum)
        {
                if (type == (int)TransactionType.Check)
                Add(new Check(date, description, category, amount, checknum));
            else if (type == (int)TransactionType.Debit)
                Add(new Debit(date, description, category, amount));
            else if (type == (int)TransactionType.Deposit)
                Add(new Deposit(date, description, category, amount));
            else
                Debug.WriteLine("Error adding obj: Transaction type{0} not recognized");
        }

        public bool checkEmptyTable()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM CheckingTransaction", conn);
                int result = 0;
                try
                {
                    conn.Open();
                    result = int.Parse(cmd.ExecuteScalar().ToString());
                }
                catch (SqlException e)
                {
                    Console.WriteLine("An exception occurred:" + e.Message);
                }

                if (result == 0)
                    return true;
                else
                    return false;
            }
        }

        public decimal Balance
        {
            get
            {
                decimal bal = 0;
                foreach (Transaction t in this)
                {
                    bal += t.CalculationAmount;
                }
                return bal;
            }
        }
    }
}