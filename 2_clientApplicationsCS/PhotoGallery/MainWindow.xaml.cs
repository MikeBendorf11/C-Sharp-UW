using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
//using System.Windows.Shapes;
using System.Diagnostics;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;

namespace PhotoGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        static string homeDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
        static PhotographList photoList = new PhotographList(homeDirectory);
        PhotographList photoListSubset = new PhotographList(photoList);
        Photograph selectedPhoto;

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyChanged(String property)
        {
            if (PropertyChanged != null) 
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //for dgSummary binding
        public PhotographList PhotoList
        {
            get { return photoList; }
            set { photoList = value; } //not used until search
        }

        //in use by the search feature
        public PhotographList PhotoListSubset 
        {
            set
            {
                photoListSubset = value;
                NotifyChanged("PhotoListSubset");
            }
            get { return photoListSubset; }
        }

        //for detail form text boxes
        public Photograph SelectedPhoto
        {
            set
            {
                selectedPhoto = value;
                NotifyChanged("SelectedPhoto");
            }
            get { return selectedPhoto; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }



        private void dgSummary_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPhoto = (Photograph)dgSummary.SelectedValue;
            if (SelectedPhoto == null) return; //while searching dgsummary becomes null
            Uri uri = new Uri(SelectedPhoto.Location);
            imageBox.Source = new BitmapImage(uri);
        }

        private void tbSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbSearch.Text == "Type your search criteria...")
                tbSearch.Text = "";
        }

        private void btSearch_Click(object sender, RoutedEventArgs e) 
        {
            if (tbSearch.Text == "Type your search criteria..." || tbSearch.Text == "")
            {
                PhotoListSubset = PhotoList;
            }
            else
            {
                Regex pattern = new Regex(@"[a-zA-Z0-9]{3,}");
                MatchCollection wordsinTb = pattern.Matches(tbSearch.Text);
                PhotographList tempPhotolist = new PhotographList();
                foreach (Match wordTb in wordsinTb)
                {
                    foreach (Photograph p in PhotoList)
                    {
                        Regex pattern2 = new Regex(wordTb.ToString(), RegexOptions.IgnoreCase);
                        Match mTitle, mDesc, mAuth, mKey;
                        mTitle = pattern2.Match(p.Title);
                        mDesc = pattern2.Match(p.Description);
                        mAuth = pattern2.Match(p.Author);
                        mKey = pattern2.Match(p.Keywords);

                        if (tempPhotolist.Contains(p)) //ignore duplicated results found
                            continue;
                        else if (mTitle.Success || mDesc.Success || mAuth.Success || mKey.Success)
                            tempPhotolist.Add(p);
                        else Debug.WriteLine("No match found in {0}", p.Title);
                    }
                }
                PhotoListSubset = tempPhotolist;
            }
            dgSummary.SelectedIndex = 0;
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tbSearch.Text = "Type your search criteria...";
            PhotoListSubset = PhotoList;
        }

        //adds a new picture to the collection
        private void btNew_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = homeDirectory;
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dlg.FilterIndex = 3;
            dlg.RestoreDirectory = true;
            
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                Photograph tempPhoto = new Photograph(
                        Path.GetFileNameWithoutExtension(dlg.FileName),
                        DateTime.Today.AddDays(-365),
                        DateTime.Today,
                        "", "", "", dlg.FileName
                        );
                foreach(Photograph p in PhotoList)
                {
                    //Don't do anything if file exists already
                    if (p.Location == tempPhoto.Location)
                    {
                        MessageBox.Show("Picture already exists!");
                        return;
                    }
                }

                PhotoList.Add(tempPhoto);
                PhotoListSubset = PhotoList;
            }

        }
    }
}

