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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void zatw_but_Click(object sender, RoutedEventArgs e)
        {
            użytkownicy_dane.podany_autor = autor_text.Text;
            użytkownicy_dane.podany_tytul = tytul_text.Text;
            Close(); 
        }
    }
}
