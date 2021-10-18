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
    public static class statyczna
    {
        public static int cena;

    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void marki_przycisk_Click(object sender, RoutedEventArgs e)
        {
            Window1 marki = new Window1();
            marki.Show();
        }

        private void silnik_przycisk_Click(object sender, RoutedEventArgs e)
        {
            Window2 silnik = new Window2();
            silnik.Show();
        }
    }
}
