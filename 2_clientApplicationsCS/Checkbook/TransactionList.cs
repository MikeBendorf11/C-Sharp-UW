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
        
        enum TableOrder { TransactionId, TransactionType, Category, TransactionDate, Description, Amount, Checknum }

        public TransactionList()
        {
            String connectionString =
             "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Checkbook;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                TableOrder tb = new TableOrder();  
                SqlCommand cmd = new SqlCommand("SELECT * FROM CheckingTransaction", conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Find out from DB whether is check, debit or deposit then 
                        //Transaction theTransac2 = new Check(DateTime.Today, );
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("An exception occurred:" + e.Message);
                }
            }

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
                //find transaction type
                GroupCollection gc = m.Groups;

                if (gc[TYPE].ToString().ToUpper() == "CHECK")
                    theTransac[countTrs] = new Check(baseDate, "", "", 0m, "");
                else if (gc[TYPE].ToString().ToUpper() == "DEBIT")
                    theTransac[countTrs] = new Debit(baseDate, "", "", 0m);
                else if (gc[TYPE].ToString().ToUpper() == "DEPOSIT")
                    theTransac[countTrs] = new Deposit(baseDate, "", "", 0m);
                else
                    Debug.WriteLine("Error: Undefined transaction type");

                //if check fill checknum prop
                if (theTransac[countTrs].GetType() == typeof(Check))
                    theTransac[countTrs].Checknum = gc[CHECKNUM].ToString();
                else
                    Debug.WriteLine("Info: Transac is not a Check");
                
                //parse date
                try
                {
                    string str = gc[DATE].ToString();
                    baseDate = Convert.ToDateTime(str, culture);
                    theTransac[countTrs].Date = baseDate;
                }
                catch (FormatException e)
                { Debug.WriteLine("Error: Check the Data input format"); }

                //parse everything else
                theTransac[countTrs].Description = gc[DESCRIPTION].ToString();
                theTransac[countTrs].Category = gc[CATEGORY].ToString();
                theTransac[countTrs].Amount = Decimal.Parse(gc[AMOUNT].ToString());
                
                //add to transaction class
                this.Add(theTransac[countTrs]);
                countTrs++;
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
