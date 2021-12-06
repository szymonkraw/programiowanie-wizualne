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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.ComponentModel;



namespace lab08
{
    public class lotnisko
    {

        public string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public string wojewodztwo;
        public string Wojewodztwo
        {
            get { return wojewodztwo; }
            set { wojewodztwo = value; }
        }

        public int id1;

        public int ID1
        {
            get { return id1; }
            set { id1 = value; }
        }

        public string icao;

        public string ICAO
        {
            get { return icao; }
            set { icao = value; }
        }

        public string iata; 

        public string IATA
        {
            get { return iata; }
            set { iata = value; }
        }
        public string miasto;

        public string Miasto
        {
            get { return miasto; }
            set { miasto = value; }
        }
        public string pasazerowie ;

        public string Pasazerowie 
        {
            get { return pasazerowie;  }
            set { pasazerowie  = value; }
        }

        public string procenty;

        public string Procenty 
        {
            get { return procenty; }
            set { procenty = value; }
        }

        public lotnisko(string Miasto, string Wojewodztwo, int ID1, string ICAO, string IATA, string Nazwa, string Pasazerowie)
        {
            this.Nazwa = Nazwa;
            this.Wojewodztwo = Wojewodztwo;
            this.ID1 = ID1;
            this.ICAO = ICAO;
            this.IATA = IATA;
            this.Miasto = Miasto;
            this.Pasazerowie = Pasazerowie;
           // this.Procenty = Procenty; 
        }


        public lotnisko()
        {

        }
    }
    public static class sprawdzanie
    {
        public static int icao_zazn = 0;
        public static int iata_zazn = 0;
        public static int pasa_zazn = 0;
        public static int woj_zazn = 0;
        public static int miasto_zazn = 0;
        public static string icaoo = "";
        public static string iataa = "";
        public static string pasazerr = "";
        public static string wojewodztwoo = "";
        public static string miastoo = "";
    }



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] drugi_split;
        public MainWindow()
        {
            InitializeComponent();
            // string fileName = "Test_data";
            string lines = File.ReadAllText("przykladowy2.csv");
            //string lines = File.ReadAllText("przykladowy2.txt");

            string [] pierwszy_split = lines.Split('"') ;
            //  string[] trzeci_split = pierwszy_split.Split(",");
            //drugi_split[0] = ""; 
   




            for( int i = 0; i < pierwszy_split.Length -1 ; i = i+ 2 )
            {
               // if (i % 2 == 0)
           //     {
                int id = 1;
                string[] data = pierwszy_split[i].Split(',');
                if (data.Length > 5)
                {
                lotnisko_lista.Items.Add(new lotnisko(data[0], data[1], id, data[2], data[3], data[4],  data[5]));
                }
                //  lotnisko_lista.Items.Add(new lotnisko(data[0], data[1], id, data[2], data[3], data[4], data[5], data[6]));
                id = id + 1;
              //  }
            }


            /*

            foreach (string linie in lines)
            {
                int id = 1;

                //   lotnisko_lista.Items.Add(lines.Select(Line =>
                ///  {
             //   string[] cos = linie.Split('"');
                string[] data = linie.Split(',');
                lotnisko_lista.Items.Add(new lotnisko(data[0], data[1], id, data[2], data[3], data[4], data[5], data[6]));

                //return new lotnisko( data[0], data[1], id, data[2], data[3], data[4], data[5], data[6] );
                //lista.Items.Add(new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2])));
                //return lista.Items(); 
                //       }));

                id++;
            }


            */
        }




        private void szukaj_Click(object sender, RoutedEventArgs e)
        {
            var selitem = lotnisko_lista.SelectedItem as lotnisko ;
            
            
            sprawdzanie.icaoo = selitem.ICAO;
            sprawdzanie.iataa = selitem.IATA;
            sprawdzanie.pasazerr = selitem.Pasazerowie;
            sprawdzanie.wojewodztwoo = selitem.Wojewodztwo;
            sprawdzanie.miastoo = selitem.Miasto;
            
            Window1 nowe = new Window1();
            nowe.Show();
        }

        private void kod_icao_Checked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.icao_zazn = 1; 
        }

        private void kod_iata_Checked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.iata_zazn = 1; 
        }

        private void l_pasaz_Checked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.pasa_zazn = 1; 
        }

        private void woj_Checked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.woj_zazn = 1;
        }

        private void miast_Checked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.miasto_zazn = 1;
        }

        private void kod_icao_Unchecked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.icao_zazn = 0;
        }

        private void kod_iata_Unchecked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.iata_zazn = 0;
        }

        private void l_pasaz_Unchecked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.pasa_zazn = 0;
        }

        private void woj_Unchecked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.woj_zazn = 0; 
        }

        private void miast_Unchecked(object sender, RoutedEventArgs e)
        {
            sprawdzanie.miasto_zazn = 0;
        }
    }
}
