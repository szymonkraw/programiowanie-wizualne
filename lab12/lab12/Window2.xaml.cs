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

namespace lab12
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            if (statyczna.chosen_animal == "Aligator")
            {
                ani.Content = "Angry doge";
            }
            if (statyczna.chosen_animal == "Kot")
            {
                ani.Content = "Doge with friend";
            }
            if (statyczna.chosen_animal == "Ryba")
            {
                ani.Content = "Fish";
            }
            if (statyczna.chosen_animal == "Mysz")
            {
                ani.Content = "Sleepy doge";
            }
            
        //    ani.Content = ""; 
        }

        private void ret_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Window1 nowe = new Window1();
            nowe.Show();
        }
    }
}
