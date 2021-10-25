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

namespace lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
//        GridViewColumn gvc; 

        public class dane
        {

            private string Imie;
            public string imie
            {
                get { return Imie; }
                set { Imie = value; }
            }

            private int Id;
            public int id
            {
                get { return Id; }
                set { Id = value; }
            }

            private int Liczba;

            public int liczba
            {
                get { return Liczba; }
                set { Liczba = value; }
            }
           
         
            public dane(string Imie, int Id , int Liczba )
            {
               this.Imie = Imie;
               this.Id = Id;
               this.Liczba = Liczba;
            }
        } 




        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // rowDef1 = new RowDefinition();
          //  grid1.RowDefinitions.Add(rowDef1);
          //  GridViewColumn gvc1 = new GridViewColumn();
           // gvc1.DisplayMemberBinding = new Binding("FirstName");
           // gvc1.Header = "FirstName";
           // gvc1.Width = 100;
            lista.Items.Add(new dane("imei",1,2)); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
      
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //ListViewPeople.ItemsSource = ReadCSV("example");
        }
    }
}
