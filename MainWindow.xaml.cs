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


namespace lab03
{
    


    public class dane
    {

        public string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int liczba;

        public int Liczba
        {
            get { return liczba; }
            set { liczba = value; }
        }


        public dane(string Imie , int Id, int Liczba)
        {
            this.Imie = Imie;
            this.Id = Id;
            this.Liczba = Liczba;
        }
        public dane()
        {

        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public static class podane_dane
    {
      public static string imie_pod;
      public static int id_pod = 1;
      public static int liczba_pod;
    }
    public static class statyczna
    {
        public static string szukana_dana;
        public static List<dane> lista_globalna = new List<dane>();
        // lista2 = new List<dane>();
    }

    // public List<dane> lista2 = new List<dane>();
    public partial class MainWindow : Window
    {
        
        public List<dane> lista2 = new List<dane>();
        public MainWindow()
        {
            InitializeComponent();
            
            //   lista.Items.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
            
            var sciezka = Directory.GetCurrentDirectory();
            DirectoryInfo scz = new DirectoryInfo(sciezka);

            var ostatniplik = scz.GetFiles("*.xml").OrderByDescending(f => f.LastAccessTime).First().ToString();

            lista2.Clear();

            lista2 = ReadXML<dane>();
            foreach (var zmienna in lista2)
            {
                lista.Items.Add(zmienna);
            }
            
            lista.Items.Refresh();


            lista.Items.Refresh();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // rowDef1 = new RowDefinition();
            //  grid1.RowDefinitions.Add(rowDef1);
            //  GridViewColumn gvc1 = new GridViewColumn();
            // gvc1.DisplayMemberBinding = new Binding("FirstName");
            // gvc1.Header = "FirstName";
            // gvc1.Width = 100;

          //  lista.Items.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
          //  podane_dane.id_pod = podane_dane.id_pod + 1;
            Window1 dodawanie = new Window1();
            dodawanie.Show();
            // lista.Items.Add(new dane("imei", 1, 2));
            
           





        }
        //int ilosc_wierszy = 1;
     





        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Serializacja 

            // dane pr = new dane(); 
             //new dane(); 


             XmlSerializer xs = new XmlSerializer(typeof(List<dane>));
             Stream s = File.Create("osoba.xml") ;

             xs.Serialize(s, lista2);
            /*
             foreach (var cos in lista.Items)
             {
                  xs.Serialize(s, cos);
             }
             */

            //      using (Stream s = File.Create("osoba.xml"))
            //           xs.Serialize(s, p);

            /*
            using (StreamWriter przes = new StreamWriter("plik_zapis.csv"))
            {
               


                /*
                foreach (var cos in lista.Items)
                {
                    // dane sklad ;
                        if (cos is dane sklad)
                         {
                   // dane sklad = new dane() ; 





                        przes.WriteLine(string.Join(";", sklad.Imie, sklad.Id, sklad.Liczba));
                       }
                }
                */
        }
            

        






        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // lista.Items.Clear();

            // ReadCSV("plik.csv");
            //  lista.Items.Add( ReadCSV("plik.csv"));

            /*
            string fileName = "plik.csv";
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));
            
            foreach (string linie in lines)
            {
                lista.Items.Add(lines.Select(line =>
               {
                   string[] data = linie.Split(';');
                //  lista ppp = new lista();
                //  ilosc_wierszy = ilosc_wierszy + 1;

                return new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
                // lista.Items.Add(new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2])));
                //return lista.Items(); 
            }));

            }
             */
            lista2.Clear();
            lista2 = ReadXML<dane>();
            foreach (var zmienna in lista2)
            {
                lista.Items.Add(zmienna);
            }
            /*
            dane[] tab = new dane[0] ; 
            dane nottab; 
            XmlSerializer xs = new XmlSerializer(typeof(dane));
            //  using (Stream s = File.OpenRead("osoba.xml")) ;
            Stream s = File.OpenRead("osoba.xml") ; 
            //tab.Append(xs.Deserialize(s));
            nottab = (dane)xs.Deserialize(s);
            lista.Items.Add(nottab);
            */
            lista.Items.Refresh();
        }


        public List<dane> ReadXML<dane>()
        {
            List<dane> wynik = new List<dane>();
            if (!System.IO.File.Exists("osoba.xml"))
            {
                return new List<dane>();
            }

            XmlSerializer sr = new XmlSerializer(typeof(List<dane>));
            using (FileStream myFileStream = new FileStream("osoba.xml", FileMode.Open))
            {
                wynik = (List<dane>)sr.Deserialize(myFileStream);
            }
            return wynik;
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // ItemsControl.ItemsSource(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod))
            podane_dane.id_pod = lista.Items.Count + 1;

            lista.Items.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
            lista2.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
            lista.Items.Refresh();
           // ItemsControl.ItemsControlFromItemContainer = lista.Items.Add((podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = false; 
        }

        private void wyjscie_Click(object sender, RoutedEventArgs e)
        {

            MyPopup.IsOpen = true; 

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Close(); 
            MyPopup.IsOpen = false;
        }

        private void szukaj_Click(object sender, RoutedEventArgs e)
        {


            statyczna.szukana_dana = szukane_imie.Text;
            statyczna.lista_globalna = lista2; 
            Window2 szukanie = new Window2();
            szukanie.Show();
        }

        private void szukane_imie_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}