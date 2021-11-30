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


namespace lab07
{

    public class uzytkownicy
    {

        public string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public uzytkownicy(string Imie, string Nazwisko, int ID)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.ID = ID;
        }
        public uzytkownicy()
        {

        }
    
    }


    public class ksiazki
    {

        public string tytul;
        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int id1;

        public int ID1
        {
            get { return id1; }
            set { id1 = value; }
        }
        public string Wypozycz;

        public string wypozycz
        {
            get { return Wypozycz; }
            set { Wypozycz = value; }
        }
        public ksiazki(string Tytul, string Autor, int ID1, string wypozycz)
        {
            this.Tytul = Tytul;
            this.Autor = Autor;
            this.ID1 = ID1;
            this.wypozycz = wypozycz; 
        }
        public ksiazki()
        {

        }
    }

    public static class statyczna
    {
        public static int ID_użytkownik;
        public static int ID_książka;
        public static int ilosc_wjesc = 0;
    }

    public static class użytkownicy_dane
    {
        public static string podane_imie;
        public static string podane_nazwisko;
        public static int podane_id;
        public static string podany_tytul;
        public static string podany_autor;
        public static int podane_id1;
        public static string podane_wypoz;
        //public List<uzytkownicy> lista2 = new List<uzytkownicy>();
    }
    



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<uzytkownicy> lista2 = new List<uzytkownicy>();
        public static List<ksiazki> lista3 = new List<ksiazki>();
        public MainWindow()
        {


            InitializeComponent();

            /*
            var sciezka = Directory.GetCurrentDirectory();
            DirectoryInfo scz = new DirectoryInfo(sciezka);

            var ostatniplik = scz.GetFiles("*.xml").OrderByDescending(f => f.LastAccessTime).First().ToString();

            lista2.Clear();

            lista2 = ReadXML<dane>();
            foreach (var zmienna in lista2)
            {
                lista.Items.Add(zmienna);
            }

            lista2.Items.Refresh();
            */

            
            var sciezka = Directory.GetCurrentDirectory();
            DirectoryInfo scz = new DirectoryInfo(sciezka);

            var plik = scz.GetFiles("ksiazki_bazadanych.xml");

            lista3 = ReadXML<ksiazki>();
            foreach (var zmienna in lista3)
            {
                lista_książ.Items.Add(zmienna);
            }

            var sciezkau = Directory.GetCurrentDirectory();
            DirectoryInfo sczu = new DirectoryInfo(sciezkau);

            var pliku = sczu.GetFiles("uzytkownicy_bazadanych.xml");

            lista2 = ReadXMLuzyt<uzytkownicy>();
            foreach (var zmiennau in lista2)
            {
                lista_użyt.Items.Add(zmiennau);
            }

            lista_książ.Items.Refresh();          

        }



        public List<ksiazki> ReadXML<ksiazki>()
        {
            List<ksiazki> wynik = new List<ksiazki>();
            if (!System.IO.File.Exists("ksiazki_bazadanych.xml"))
            {
                return new List<ksiazki>();
            }

            XmlSerializer sr = new XmlSerializer(typeof(List<ksiazki>));
            using (FileStream myFileStream = new FileStream("ksiazki_bazadanych.xml", FileMode.Open))
            {
                wynik = (List<ksiazki>)sr.Deserialize(myFileStream);
            }
            return wynik;
        }

        public List<uzytkownicy> ReadXMLuzyt<uzytkownicy>()
        {
            List<uzytkownicy> wynik = new List<uzytkownicy>();
            if (!System.IO.File.Exists("uzytkownicy_bazadanych.xml"))
            {
                return new List<uzytkownicy>();
            }

            XmlSerializer sr = new XmlSerializer(typeof(List<uzytkownicy>));
            using (FileStream myFileStream = new FileStream("uzytkownicy_bazadanych.xml", FileMode.Open))
            {
                wynik = (List<uzytkownicy>)sr.Deserialize(myFileStream);
            }
            return wynik;
        }





        private void wypozycz_Click(object sender, RoutedEventArgs e)
        {
            
            var selItem = lista_książ.SelectedItem as ksiazki ;

            
            int x = 0;

            x = selItem.ID1 -1 ;

            var selitem2 = lista_użyt.SelectedItem as uzytkownicy;

            string x2 = selitem2.id.ToString() ; 

            lista3[x] = new ksiazki(selItem.tytul, selItem.autor, selItem.ID1, x2);
            lista_książ.Items[x] = new ksiazki(selItem.tytul, selItem.autor, selItem.ID1, x2);

        }

        private void oddaj_Click(object sender, RoutedEventArgs e)
        {
            var selItem = lista_książ.SelectedItem as ksiazki;

            int x = 0;

            x = selItem.ID1 - 1;
            lista3[x] = new ksiazki(selItem.tytul, selItem.autor, selItem.ID1, "--");
            lista_książ.Items[x] = new ksiazki(selItem.tytul, selItem.autor, selItem.ID1, "--" );
        }

        private void dodaj_czyt_Click(object sender, RoutedEventArgs e)
        {
            Window2 dod_czyt = new Window2();
            dod_czyt.Show();
       //     Close();
        }

        private void dodaj_ks_Click(object sender, RoutedEventArgs e)
        {
            Window1 dod_ksiazke  = new Window1();
            dod_ksiazke.Show();
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            użytkownicy_dane.podane_id = lista_użyt.Items.Count + 1;
            lista2.Add(new uzytkownicy(użytkownicy_dane.podane_imie, użytkownicy_dane.podane_nazwisko, użytkownicy_dane.podane_id));
            lista_użyt.Items.Add(new uzytkownicy(użytkownicy_dane.podane_imie, użytkownicy_dane.podane_nazwisko, użytkownicy_dane.podane_id));
            lista_użyt.Items.Refresh();
        }

        private void dodaj_Copy_Click(object sender, RoutedEventArgs e)
        {
            użytkownicy_dane.podane_id1 = lista_książ.Items.Count + 1;
            użytkownicy_dane.podane_wypoz = "--";
            lista3.Add(new ksiazki(użytkownicy_dane.podany_tytul, użytkownicy_dane.podany_autor, użytkownicy_dane.podane_id1, użytkownicy_dane.podane_wypoz));
            
            lista_książ.Items.Add(new ksiazki(użytkownicy_dane.podany_tytul, użytkownicy_dane.podany_autor, użytkownicy_dane.podane_id1, użytkownicy_dane.podane_wypoz));
            lista_książ.Items.Refresh();
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //lista3 = lista_książ ;
            XmlSerializer xs = new XmlSerializer(typeof(List<ksiazki>));
            Stream s = File.Create("ksiazki_bazadanych.xml");

            xs.Serialize(s, lista3);

            XmlSerializer xsu = new XmlSerializer(typeof(List<uzytkownicy>));
            Stream su = File.Create("uzytkownicy_bazadanych.xml");

            xsu.Serialize(su, lista2);
        }



    }
   
}
