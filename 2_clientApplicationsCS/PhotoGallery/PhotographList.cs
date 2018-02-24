using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    public class PhotographList : ObservableCollection<Photograph>
    {
        
        /// <summary>
        /// Creates a list of Photograph data using pictures from a given
        /// directory and writes random information in the object fields
        /// </summary>
        /// <param name="Directory"></param>
        public PhotographList(string Directory)
        {
            string[] filesUri = GetImmages(Directory);
            int fileCount = filesUri.Length;
            Random rnd = new Random();
            string[] keys = { "key1", "key2", "key3", "key4" };
            List<string> rdnKey = new List<string>(); //the possible keywords
            rdnKey.AddRange(keys);
            DateTime date = new DateTime(2015, 1, 1);

            for (int count = 0; count < fileCount; count++)
            {
                string keyComb = ""; //the keywords to be added
                int rndNum = rnd.Next(1, 5);
                rdnKey.Shuffle();

                //keyComb becomes a random number and selection rdnKey
                for (int i = 0; i < rndNum; i++)
                    keyComb += rdnKey[i] + (i == (rndNum - 1) ? "" : ", ");

                Add(
                        new Photograph(
                            Path.GetFileName(filesUri[count]),
                            date.AddDays(rnd.Next(1, 300)),
                            date.AddDays(rnd.Next(301, 600)),
                            "desc" + count + ": " +
                            "This is was added by the system",
                            "Author" + (count + 1),
                            keyComb,
                            filesUri[count])
                    );

                Debug.WriteLine(this[count].Title);
                Debug.WriteLine(this[count].DateTaken);
                Debug.WriteLine(this[count].DateAdeed);
                Debug.WriteLine(this[count].Description);
                Debug.WriteLine(this[count].Author);
                Debug.WriteLine(this[count].Keywords);
                Debug.WriteLine(this[count].Location);
                Debug.WriteLine("");
                
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
    }
    
}
