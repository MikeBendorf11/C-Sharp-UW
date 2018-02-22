using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace PhotoGallery
{
    public class Photograph
    {
        string title;
        DateTime dateTaken;
        DateTime dateAdded;
        string description;
        string author;
        string keywords;
        string location;

        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public DateTime DateTaken
        {
            set { dateTaken = value; }
            get { return dateTaken; }
        }
        public DateTime DateAdeed
        {
            set { dateAdded = value; }
            get { return dateAdded; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public string Author
        {
            set { author = value; }
            get { return author; }
        }
        public string Keywords
        {
            set { keywords = value; }
            get { return keywords; }
        }
        public string Location
        {
            set { location = value; }
            get { return location; }
        }
        
        //constructor
        public Photograph(string Title, DateTime dateTaken, DateTime dateAdded, string description, string author, string keywords, string location )
        {
            Title = title;
            DateTaken = dateTaken;
            DateAdeed = dateAdded;
            Description = description;
            Author = author;
            Keywords = keywords;
            Location = location;
        }
    }
}
