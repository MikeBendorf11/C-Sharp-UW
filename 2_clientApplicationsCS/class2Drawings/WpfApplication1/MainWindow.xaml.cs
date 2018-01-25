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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point start;        // Start coords of box
        Size size;          // Height, width of box
        bool isDragging = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = e.GetPosition(this);

            if (isDragging && location.X > start.X &&
              location.Y > start.Y)
            {
                size.Width = e.GetPosition(this).X - start.X;
                size.Height = e.GetPosition(this).Y -start.Y;
                InvalidateVisual();
            }

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            start = e.GetPosition(this);
            isDragging = true;

        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;

        }

        protected override void
    OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Brush background = new
              SolidColorBrush(Colors.White);
            drawingContext.DrawRectangle(background,
              new Pen(null, 0), new
              Rect(0, 0, ActualWidth, ActualHeight));
            if (size.Width > 0 && size.Height > 0)
            {
                Brush brush = new
                  SolidColorBrush(Colors.Transparent);
                Pen pen = new Pen(new
                  SolidColorBrush(Colors.Blue), 3);
                drawingContext.DrawRectangle(brush, pen, new
                  Rect(start, size));
            }
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
