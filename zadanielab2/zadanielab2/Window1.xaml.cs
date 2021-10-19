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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            cena_silnika.Content = statyczna.cena; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mm = new MainWindow();
            mm.Show();
            Close();
        }

        private void RadioButton_Checked_benzyna(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 20000;
            cena_silnika.Content = statyczna.cena;
        }
        private void RadioButton_Checked_diesel(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 15000;
            cena_silnika.Content = statyczna.cena;
        }
        private void RadioButton_Checked_hybryda(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 40000;
            cena_silnika.Content = statyczna.cena;
        }
        private void RadioButton_Unchecked_benzyna(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 20000;
            cena_silnika.Content = statyczna.cena;
        }
        private void RadioButton_Unchecked_diesel(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 15000;
            cena_silnika.Content = statyczna.cena;
        }
        private void RadioButton_Unchecked_hybryda(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 40000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Selected_moc1(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 4000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Selected_moc2(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 8000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Selected_moc3(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 12000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Selected_moc4(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena + 16000;
            cena_silnika.Content = statyczna.cena;
        }

        private void ComboBoxItem_Unselected_moc1(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 4000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Unselected_moc2(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 8000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Unselected_moc3(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 12000;
            cena_silnika.Content = statyczna.cena;
        }
        private void ComboBoxItem_Unselected_moc4(object sender, RoutedEventArgs e)
        {
            statyczna.cena = statyczna.cena - 16000;
            cena_silnika.Content = statyczna.cena;
        }

        
    }
}
