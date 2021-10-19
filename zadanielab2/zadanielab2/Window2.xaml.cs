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

namespace zadanielab2
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
           // statyczna.cena = 10; 
          //  cena_marki.Content = statyczna.cena; 
            InitializeComponent();
            cena_marki.Content = statyczna.cena;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mm = new MainWindow();
            mm.Show();
            Close();
        }
        string polisa_text;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            polisa_text = polisa_wart.Text;
            int.TryParse(polisa_text, out int polisa_int);
         //   int polisa_int = polisa_text.ParseInt();
            statyczna.cena = statyczna.cena + polisa_int;
          //  cena_marki.Content = statyczna.cena;
        }

        private void CheckBox_Checked_klimatyzacja(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 1000;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Checked_glosniki(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 1000;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Checked_nawigacja(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 500;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Checked_autoszyb(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 200;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Checked_radio(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 400;
            cena_marki.Content = statyczna.cena;
        }

        private void RadioButton_Checked_Ford(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 20000;
            cena_marki.Content = statyczna.cena;
        }
        private void RadioButton_Checked_Fiat(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 15000;
            cena_marki.Content = statyczna.cena;
        }
        private void RadioButton_Checked_Ferrari(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 50000;
            cena_marki.Content = statyczna.cena;
        }

        private void RadioButton_Unchecked_fiat(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 15000;
            cena_marki.Content = statyczna.cena;
        }
        private void RadioButton_Unchecked_ford(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 20000;
            cena_marki.Content = statyczna.cena;
        }
        private void RadioButton_Unchecked_ferrari(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 50000;
            cena_marki.Content = statyczna.cena;
        }

        private void CheckBox_Unchecked_klimatyzacja(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 1000;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Unchecked_glosniki(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 1000;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Unchecked_nawigacja(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 500;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Unchecked_autoszyb(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 200;
            cena_marki.Content = statyczna.cena;
        }
        private void CheckBox_Unchecked_radio(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 400;
            cena_marki.Content = statyczna.cena;
        }
      
    }
    
}
