using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexXmlIndexerProperty
{
    class Program
    {
        enum Property { ID = 1, DATE, TYPE, DESCRIPTION, CATEGORY, AMOUNT, CHECKNUM = 8 };

        static void Main(string[] args)
        {


            string input = @"<Transactions><Transaction><Id>1</Id><Date>11/23/2014</Date><Type>Deposit</Type><Description>Pay</Description><Category>Income</Category><Amount>1327</Amount></Transaction><Transaction><Id>2</Id><Date>11/24/2014</Date><Type>Check</Type><Description>Food</Description><Category>Food</Category><Amount>62</Amount><Checknum>2021</Checknum></Transaction><Transaction><Id>3</Id><Date>11/24/2014</Date><Type>Debit</Type><Description>ATM</Description><Category>Misc</Category><Amount>40</Amount></Transaction><Transaction><Id>4</Id><Date>11/25/2014</Date><Type>Check</Type><Description>Rent</Description><Category>Rent</Category><Amount>713</Amount><Checknum>2022</Checknum></Transaction><Transaction><Id>5</Id><Date>11/26/2014</Date><Type>Debit</Type><Description>Dinner</Description><Category>Friends</Category><Amount>37.29</Amount></Transaction><Transaction><Id>6</Id><Date>11/26/2014</Date><Type>Debit</Type><Description>Movie</Description><Category>Friends</Category><Amount>12.50</Amount></Transaction><Transaction><Id>7</Id><Date>11/27/2014</Date><Type>Deposit</Type><Description>Mom</Description><Category>Income</Category><Amount>100</Amount></Transaction><Transaction><Id>8</Id><Date>11/28/2014</Date><Type>Check</Type><Description>Costco</Description><Category>Misc</Category><Amount>15.72</Amount><Checknum>2024</Checknum></Transaction><Transaction><Id>9</Id><Date>11/29/2014</Date><Type>Debit</Type><Description>Gas</Description><Category>Gas</Category><Amount>43.83</Amount></Transaction><Transaction><Id>10</Id><Date>11/30/2014</Date><Type>Debit</Type><Description>Market</Description><Category>Food</Category><Amount>35.11</Amount></Transaction></Transactions>";

            Regex pattern = new Regex((@"<Id>(\d*)<\/Id>" +
                                       @"<Date>(\d{2}\/\d{2}\/\d{4})<\/Date>" +
                                       @"<Type>(\w*)<\/Type>" +
                                       @"<Description>(\w*)<\/Description>" +
                                       @"<Category>(\w*)<\/Category>" +
                                       @"<Amount>(\d*\.?\d*)<\/Amount>" +
                                       @"(<Checknum>(\d*)<\/Checknum>)?"));

            /*<Id>(\d*)<\/Id><Date>(\d{2}\/\d{2}\/\d{4})<\/Date><Type>(\w*)<\/Type><Description>(\w*)<\/Description><Category>(\w*)<\/Category><Amount>(\d*\.?\d*)<\/Amount>(<Checknum>(\d*)<\/Checknum>)?*/

            Transaction[] theTransac = new Transaction[10]; //total 10 records

            Match match = pattern.Match(input);
            MatchCollection matchCollection = pattern.Matches(input);

            int countMatch = 0;
            foreach (Match m in matchCollection)
            {
                theTransac[countMatch] = new Transaction();
                GroupCollection gc = m.Groups;
                for (int countGroup = 1; countGroup<gc.Count; countGroup++)
                {
                    if (countGroup == (int)Property.ID)
                        theTransac[countMatch].Id = gc[(int)Property.ID].ToString();
                    else if (countGroup == (int)Property.DATE)
                        theTransac[countMatch].Date = gc[(int)Property.DATE].ToString();
                    else if (countGroup == (int)Property.TYPE)
                        theTransac[countMatch].Type = gc[(int)Property.TYPE].ToString();
                    else if (countGroup == (int)Property.DESCRIPTION)
                        theTransac[countMatch].Description = gc[(int)Property.DESCRIPTION].ToString();
                    else if (countGroup == (int)Property.CATEGORY)
                        theTransac[countMatch].Category = gc[(int)Property.CATEGORY].ToString();
                    else if (countGroup == (int)Property.AMOUNT)
                        theTransac[countMatch].Amount = Double.Parse(gc[(int)Property.AMOUNT].ToString());
                    else if (countGroup == (int)Property.CHECKNUM)
                        theTransac[countMatch].Checknum = gc[(int)Property.CHECKNUM].ToString();
                    else
                        Debug.WriteLine("Unresolved property match!");
                }
                countMatch++;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("id: {0}", theTransac[j].Id);
                Console.WriteLine("date: {0}", theTransac[j].Date);
                Console.WriteLine("type: {0}", theTransac[j].Type);
                Console.WriteLine("description: {0}", theTransac[j].Description);
                Console.WriteLine("category: {0}", theTransac[j].Category);
                Console.WriteLine("amount: {0}", theTransac[j].Amount);
                Console.WriteLine("checknum: {0}", theTransac[j].Checknum);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }
}
