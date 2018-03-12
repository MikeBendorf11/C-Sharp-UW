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
using System.Data.SqlClient;

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
            tbSearch.Foreground = Brushes.Black; 
        }

        //search using words separated by commas or spaces
        private void btSearch_Click(object sender, RoutedEventArgs e) 
        {
            if (tbSearch.Text == "Type your search criteria..." || tbSearch.Text == "")
            {
                PhotoListSubset = PhotoList;
            }
            else
            {
                Regex wordPattern = new Regex(@"[a-zA-Z0-9]{3,}");
                MatchCollection wordsinTextBox = wordPattern.Matches(tbSearch.Text);
                PhotographList tempPhotolist = new PhotographList();
                foreach (Match m in wordsinTextBox)
                {
                    foreach (Photograph p in PhotoList)
                    {
                        Regex wordsInObj = new Regex(m.ToString(), RegexOptions.IgnoreCase);
                        Match mTitle, mDesc, mAuth, mKey;
                        mTitle = wordsInObj.Match(p.Title);
                        mDesc = wordsInObj.Match(p.Description);
                        mAuth = wordsInObj.Match(p.Author);
                        mKey = wordsInObj.Match(p.Keywords);

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
            tbSearch.Foreground = Brushes.Gray;
        }

        //adds a new picture to the collection
        private void btNew_Click(object sender, RoutedEventArgs e)
        {
            btClear_Click(sender, e);

            OpenFileDialog dlg = new OpenFileDialog();
            int tempId = 0; //**will be inserted on last row of db
            dlg.InitialDirectory = homeDirectory;
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dlg.FilterIndex = 3;
            dlg.RestoreDirectory = true;
            
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                Photograph tp = new Photograph(
                        tempId,
                        Path.GetFileNameWithoutExtension(dlg.FileName),
                        DateTime.Today.AddDays(-365),
                        DateTime.Today,
                        "", "", "", dlg.FileName
                        );
                foreach(Photograph p in PhotoList)
                {
                    //Don't do anything if file exists already
                    if (p.Location == tp.Location)
                    {
                        MessageBox.Show("Picture already exists!");
                        return;
                    }
                    tempId++;
                }
                tp.Id = tempId + 1;
                PhotoList.Add(tp);
                PhotoListSubset = PhotoList;

                //add new photo to the db
                using (SqlConnection conn = new SqlConnection(PhotoList.connectionString))
                {
                    try
                    {
                        conn.Open();
                        PhotoList.TableInsert(tp.Id, tp.Title, tp.DateTaken, tp.DateAdeed, tp.Description, tp.Author, tp.Keywords, tp.Location, conn);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("An exception ocurred while adding the new Photo: " + ex.Message);
                    }     
                }
            }
        }
        //**only when pressing search and clear the photolist is getting updated to the displayed
        //values, might have smth to do with the events, Photolist and the PhotoListSubset 
        //when the program closes, update the db
        private void PhotoGallery_Closed(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(PhotoList.connectionString))
            {
                try
                {
                    int tempId = 1;
                    conn.Open();
                    foreach(Photograph p in PhotoList)
                    {
                        PhotoList.TableUpdate(tempId, p.Title, p.DateTaken, p.DateAdeed, p.Description, p.Author, p.Keywords, p.Location, conn);
                        tempId++;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("An exception ocurred while updating the db on exit: " + ex.Message);
                }
            }
        }

        private void PhotoGallery_Loaded(object sender, RoutedEventArgs e)
        {
            PhotoListSubset = PhotoList;
        }
        private void tbDateTaken_Error(object sender, ValidationErrorEventArgs e)

        {
            MessageBox.Show("Invalid Date: " + e);
            tbDateTaken.Undo();
            Keyboard.Focus(tbDateTaken);
        }
        private void tbDateAdded_Error(object sender, ValidationErrorEventArgs e)

        {
            MessageBox.Show("Invalid Date: " + e);
            tbDateAdded.Undo();
            Keyboard.Focus(tbDateAdded);
        }


    }
}

