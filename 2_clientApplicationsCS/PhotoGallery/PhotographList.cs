using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    public class PhotographList : ObservableCollection<Photograph>
    {
        public String connectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=PhotoGallery;Integrated Security=True";
        static int id;

        public PhotographList() { }

        /// <summary>
        /// Copies the contents of one photograph list to another.
        /// </summary>
        /// <param name="inputList"></param>
        public PhotographList(PhotographList inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                Add(
                       new Photograph(
                                i+1,
                                inputList[i].Title,
                                inputList[i].DateTaken,
                                inputList[i].DateAdeed,
                                inputList[i].Description,
                                inputList[i].Author,
                                inputList[i].Keywords,
                                inputList[i].Location
                           )
                    );
            }
        }
        /// <summary>
        /// If the program is launched for the first time, it creates a list of Photograph 
        /// data using pictures from a given directory, otherwise it initializes from the
        /// database
        /// </summary>
        /// <param name="directory"></param>
        public PhotographList(string directory)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (IsDbEmpty(conn)) //Create Photolist and db from directory
                    FirstRunAddToDb(directory, conn);

                else //Create PhotoList from db
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PhotoGallery", conn);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = (int)reader["Id"];
                            string title = (string)reader["Title"];
                            DateTime dateTaken = (DateTime)reader["DateTaken"];
                            DateTime dateAdded = (DateTime)reader["DateAdded"];
                            string description = (string)reader["Description"];
                            string author = (string)reader["Author"];
                            string keywords = (string)reader["Keywords"];
                            string location = (string)reader["Location"];
                            Add(new Photograph(id, title, dateTaken, dateAdded, description, author, keywords, location));
                        }
                        conn.Close();
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("An error ocurred while creating obj from db: +", e.Message);
                    }
                }
            }
        }

        void FirstRunAddToDb(string directory, SqlConnection conn)
        {
            string[] filesUri = GetImmages(directory);
            int fileCount = filesUri.Length; // the files in the directory
            Random rnd = new Random();
            string[] keys = { "key1", "key2", "key3", "key4" };
            List<string> rdnKey = new List<string>(); //the possible keywords
            rdnKey.AddRange(keys);
            DateTime defaultDate = new DateTime(2015, 1, 1);
            try
            {
                conn.Open();
                for (int count = 0; count < fileCount; count++)
                {
                    string keyComb = ""; //the keywords to be added
                    int rndNum = rnd.Next(1, 3);
                    rdnKey.Shuffle();

                    //keyComb becomes a random number and selection rdnKey
                    for (int i = 0; i < rndNum; i++)
                        keyComb += rdnKey[i] + (i == (rndNum - 1) ? "" : ", ");

                    id = count + 1;
                    string title = Path.GetFileNameWithoutExtension(filesUri[count]);
                    DateTime dateTaken = defaultDate.AddDays(rnd.Next(1, 300));
                    DateTime dateAdded = defaultDate.AddDays(rnd.Next(301, 600));
                    string description = "desc(" + count + ")" + ": " + "This was added by the system";
                    string author = "Author" + (count + 1);
                    string keywords = keyComb;
                    string location = filesUri[count];

                    //add photograph obj to list
                    Add(new Photograph(id, title, dateTaken, dateAdded, description, author, keywords, location));
                    //insert data into db
                    TableInsert(id, title, dateTaken, dateAdded, description, author, keywords, location, conn);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An exception ocurred while opening the connection: " + e.Message);
            }
        }
        /// <summary>
        /// Inserts a line of photograph data into the db
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="dateTaken"></param>
        /// <param name="dateAdded"></param>
        /// <param name="description"></param>
        /// <param name="author"></param>
        /// <param name="keywords"></param>
        /// <param name="location"></param>
        /// <param name="conn"></param>
        public void TableInsert(int id, string title, DateTime dateTaken, DateTime dateAdded, string description, string author, string keywords, string location, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PhotoGallery (Id, Title, DateTaken, DateAdded, Description, Author, Keywords, Location) values (@Id, @Title, @DateTaken, @DateAdded, @Description, @Author, @Keywords, @Location)", conn);

            try
            {
                cmd.Parameters.AddWithValue("Id", id);
                cmd.Parameters.AddWithValue("Title", title);
                cmd.Parameters.AddWithValue("DateTaken", dateTaken.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("DateAdded", dateAdded.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("Description", description);
                cmd.Parameters.AddWithValue("Author", author);
                cmd.Parameters.AddWithValue("Keywords", keywords);
                cmd.Parameters.AddWithValue("Location", location);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An exception ocurred while creating insert @params: " + e.Message);
            }
        }

        public void TableUpdate(int id, string title, DateTime dateTaken, DateTime dateAdded, string description, string author, string keywords, string location, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("UPDATE PhotoGallery SET Title=@Title, DateTaken=@DateTaken, DateAdded=@DateAdded, Description=@Description, Author=@Author, Keywords=@Keywords, Location=@Location WHERE Id=@Id", conn);
            try
            {
                cmd.Parameters.AddWithValue("Id", id);
                cmd.Parameters.AddWithValue("Title", title);
                cmd.Parameters.AddWithValue("DateTaken", dateTaken.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("DateAdded", dateAdded.ToString("MM/dd/yyyy"));
                cmd.Parameters.AddWithValue("Description", description);
                cmd.Parameters.AddWithValue("Author", author);
                cmd.Parameters.AddWithValue("Keywords", keywords);
                cmd.Parameters.AddWithValue("Location", location);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An exception ocurred while updating the table on exit: " + e.Message);
            }
        }

        /// <summary>
        /// Obtains a list file locations of the specified supported format
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static string[] GetImmages(string directory)
        {
            string supportedFormat = "*.jpg";
            string[] files = Directory.GetFiles(directory, supportedFormat);
            return files;
        }

        /// <summary>
        /// Finds out if the db related to the Connection String is empty
        /// </summary>
        /// <returns></returns>
        public bool IsDbEmpty(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PhotoGallery", conn);
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

            conn.Close();

            if (result == 0)
                return true;
            else
                return false;
    
        }

    }

}
