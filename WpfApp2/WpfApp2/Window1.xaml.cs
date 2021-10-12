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
        DispatcherTimer stoper = new DispatcherTimer();
        System.DateTime aktualna = DateTime.Now;
        public Window1()
        {
            InitializeComponent();
            
            //wynik.Content = DateTime.Now.Second; 
            stoper.Interval = TimeSpan.FromSeconds(1);
            stoper.Tick += tykanie;
                
        }
        private void tykanie(object sender, EventArgs e)
        {
            System.DateTime aktualna2 = DateTime.Now;
            //wynik.Content = DateTime.Now.Minute.ToString();
            // wynik2.Content = DateTime.Now.Second.ToString();
            // System.DateTime date1 = new System.DateTime(2015, 3, 10, 2, 0, 10);
            //  wynik.Content = date1.Minute;
            // System.DateTime date2 = new System.DateTime(2015, 3, 10, 2, 0, 0);
            // wynik2.Content = date2.Second;
            System.TimeSpan date1 = aktualna2.Subtract(aktualna);
            wynik.Content = date1.Minutes;
            System.TimeSpan date2 = aktualna2.Subtract(aktualna);
            wynik2.Content = date2.Seconds;
        }


        private void start_button(object sender, EventArgs e)
        {
            aktualna = DateTime.Now;
            stoper.Start(); 
        }

        private void stop_button(object sender, EventArgs e)
        {
            stoper.Stop();
            //aktualna = DateTime.Now;
        }
     
    }
}




