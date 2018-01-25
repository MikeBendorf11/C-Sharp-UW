using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Checkbook
{
    class TransactionList : List<Transaction>
    {
        public TransactionList()
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
            Transaction[] theTransac = new Transaction[10];
            DateTime date = new DateTime(1, 1, 1980);


            int countMatch = 0;
            foreach (Match m in matchCollection)
            {
                //transaction parser
                theTransac[countMatch] = new Check(date, "", "", 0m, "");

                GroupCollection gc = m.Groups;
                for (int countGroup = 1; countGroup < gc.Count; countGroup++)
                {
                    //transaction property parser
                }
            }
            /*Put in the xml data, 
             Parse it for each object
             Look to see if is a check, debit or deposit
             Create the appropiate obj and fill it with the data
             Add it to the current list with Add(t)*/
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
