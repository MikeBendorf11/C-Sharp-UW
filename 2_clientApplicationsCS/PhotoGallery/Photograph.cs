using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace PhotoGallery
{
    public class Photograph : INotifyPropertyChanged
    {
        static int id;
        string title;
        DateTime dateTaken;
        DateTime dateAdded;
        string description;
        string author;
        string keywords;
        string location;

        //Properties
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Title
        {
            set
            {
                title = value;
                NotifyChanged("Title");
            }
            get { return title; }
        }
        public DateTime DateTaken
        {
            set
            {
                dateTaken = value;
                NotifyChanged("DateTaken");
            }
            get { return dateTaken; }
        }
        public DateTime DateAdeed
        {
            set { dateAdded = value; }
            get { return dateAdded; }
        }
        public string Description
        {
            set
            {
                description = value;
                NotifyChanged("Description");
            }
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
 
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyChanged(String property)
        {
            if (PropertyChanged != null) //if anybody is listening
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //constructor
        public Photograph(int id, string title, DateTime dateTaken, DateTime dateAdded, string description, string author, string keywords, string location )
        {
            Id = id;
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
