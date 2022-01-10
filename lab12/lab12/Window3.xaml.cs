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
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void TA_Click(object sender, RoutedEventArgs e)
        {
            Window1 nowe = new Window1();
            nowe.Show();
            Close(); 
        }

        private void RET_Click(object sender, RoutedEventArgs e)
        {
            Window2 nowe = new Window2();
            nowe.Show();
            Close();

        }
    }
}
