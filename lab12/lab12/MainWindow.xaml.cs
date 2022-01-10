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

namespace lab12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class statyczna 
        {
        public static string chosen_animal;
        public static string chosen_level;
        public static ImageBrush img_all = new ImageBrush();
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            statyczna.chosen_animal = animal.SelectionBoxItem.ToString();
            statyczna.chosen_level = level.SelectionBoxItem.ToString(); 

            Window1 nowe = new Window1();
            nowe.Show();
        }
    }
}
