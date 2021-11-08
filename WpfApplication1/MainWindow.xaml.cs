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
using System.IO;
using Microsoft.Win32;
using System.Drawing;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///         int liczba = 0; 
      

    public partial class MainWindow : Window
    {

       // public void RotateFlip(System.Drawing.RotateFlipType rotateFlipType);
    // public   int liczba = 0; 
        public int liczba = 0;
       public Uri przekrecenie; 
        public MainWindow()
        {
            InitializeComponent();
        }

        public void b_Choose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                przekrecenie = fileUri; 
                img.Source = new BitmapImage(fileUri);
            }
        }

        private void b_A_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void b_B_Click(object sender, RoutedEventArgs e)
        {
           

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = przekrecenie;
            if (liczba == 0)
            {
                bi.Rotation = Rotation.Rotate90;
                liczba++;
            }
            else   if (liczba == 1)
            {
                bi.Rotation = Rotation.Rotate180;
                liczba++;
            }
            else if (liczba == 2)
            {
                bi.Rotation = Rotation.Rotate270;
                liczba++;
            }
            else   if (liczba == 3)
            {
                bi.Rotation = Rotation.Rotate0;
                liczba=0;
            }
            bi.EndInit();
            img.Source = bi;
            przekrecenie = bi.UriSource; 
        }

        private void b_C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_D_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
