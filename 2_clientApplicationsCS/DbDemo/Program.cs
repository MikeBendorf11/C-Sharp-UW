using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String connectionString =
              "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Checkbook;Integrated Security=True";

            //SqlConnection conn = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand("CREATE TABLE CheckingTransaction " + "(TransactionId INT PRIMARY KEY, TransactionType INT, Category " + "VARCHAR(50), TransactionDate DATETIME, Description VARCHAR(50), " + "Amount MONEY, CheckNum VARCHAR (10))", conn);
            //try
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //}
            //catch (SqlException e)
            //{
            //    Console.WriteLine("An exception occurred:" + e.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}

            
                    using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM CheckingTransaction", conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("Transaction ID = " + (int)reader["TransactionId"]);
                        Console.WriteLine("Transaction Type = " + (int)reader["TransactionType"]);
                        Console.WriteLine("Category = " + (String)reader["Category"]);
                        Console.WriteLine("Transaction Date = " + reader.GetDateTime(3));
                        Console.WriteLine("Description = " + reader.GetString(4));
                        Console.WriteLine("Amount = " + reader.GetDecimal(5));
                        Console.WriteLine("Check Number = " + reader.GetString(6));
                        Console.ReadLine();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("An exception occurred:" + e.Message);
                }
            }
             
             
        }
    }
}
