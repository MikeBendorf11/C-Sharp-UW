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
using System.Windows.Shapes;
using System.Diagnostics;

namespace PhotoGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const int TITLE = 0;
        public const int DATETAKEN = 1;
        public const int DATEADDED = 2;
        public const int DESCRIPTION = 3;
        public const int AUTHOR = 4;
        public const int KEYWORDS = 5;
        public const int LOCATION = 6;

        static string homeDirectory = @"C:\Users\Public\Pictures\Sample Pictures";
        PhotographList photoList = new PhotographList(homeDirectory);

        //for dgSummary binding
        public PhotographList PhotoList
        {
            get { return photoList; }
            set { photoList = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //dgSummary.Columns[DATEADDED].Visibility = Visibility.Collapsed;
            //dgSummary.Columns[AUTHOR].Visibility = Visibility.Collapsed;
            //dgSummary.Columns[KEYWORDS].Visibility = Visibility.Collapsed;
            //dgSummary.Columns[LOCATION].Visibility = Visibility.Collapsed;
            //dgSummary.ItemsSource = photolist;


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(dgSummary.Columns[0].GetType());
        }
    }
}

