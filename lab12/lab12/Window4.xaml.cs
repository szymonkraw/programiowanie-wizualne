using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace lab12
{
    /// <summary>
    /// Logika interakcji dla klasy Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            
        }

        private void toss_Click(object sender, RoutedEventArgs e)
        {
            var img = new ImageBrush();

            Random rnd = new Random();
            int wyn = rnd.Next(10); 
            if(wyn >5 )
            {
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/R.fd2469d430b506b4f41c4c1731ccd2aa?rik=OrQL09g4w0KAKw&pid=ImgRaw&r=0"));
                toss.Background = img; 
                result.Content = "ITS YOUr LUCKY DAY"; 
            }
            else
            {
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/OIP.03Gxkxnu27d9jXkIbpXDAwHaHa?pid=ImgDet&rs=1"));
                toss.Background = img;
                result.Content = "UNLUCKY"; 
            }
        }

        private void ret_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nowe = new MainWindow();
            nowe.Show();
            Close(); 
        }
    }
}
