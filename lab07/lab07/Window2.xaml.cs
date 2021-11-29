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

namespace lab07
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void zatwierdź_użytkownika_Click(object sender, RoutedEventArgs e)
        {
            użytkownicy_dane.podane_imie = Imie_text.Text;
            użytkownicy_dane.podane_nazwisko = Nazwisko_text.Text; 
         //   MainWindow nowe= new MainWindow();
         //   nowe.Show(); 
            Close(); 
        }
    }
}
