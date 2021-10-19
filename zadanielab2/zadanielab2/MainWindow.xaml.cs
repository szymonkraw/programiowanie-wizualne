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

namespace zadanielab2
{

    public static class statyczna
    {
        public static int cena ; 
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cena_auta.Content = statyczna.cena;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 silnik_w = new Window1();
            silnik_w.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 marki_w = new Window2();
            marki_w.Show();
            Close();
        }
    }
}
