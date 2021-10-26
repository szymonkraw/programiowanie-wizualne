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

namespace lab03
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           // string text1 = imie_text.Text;
           // podane_dane.imie_pod = imie_text.Text;
        }


        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        { 
            string posrednik = liczba_text.Text;
            int.TryParse(posrednik, out int posrednik2);
            podane_dane.liczba_pod = posrednik2;
        }

        private void akcept_Click(object sender, RoutedEventArgs e)
        {
            podane_dane.imie_pod = imie_text.Text;
           // string posrednik = liczba_text.Text;
           // int.TryParse(posrednik, out int posrednik2);
           // podane_dane.liczba_pod = posrednik2;
            Close();
        }
    }
}
