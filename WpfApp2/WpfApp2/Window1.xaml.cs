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
using System.Windows.Threading; 

namespace WpfApp2
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
       
        DateTime poczatek;
        TimeSpan ts;
        public Window1()
        {
            InitializeComponent();

           
        }

        private void start_button(object sender, RoutedEventArgs e)
        {
            string test;
            ts = DateTime.Now - poczatek;
            wynik.Content = ts.ToString();
        }

        private void stop_button(object sender, RoutedEventArgs e)
        {
            poczatek = new DateTime(DateTime.Now.Ticks);
          //  Timer1.enabled = true;
        }
    }
}
