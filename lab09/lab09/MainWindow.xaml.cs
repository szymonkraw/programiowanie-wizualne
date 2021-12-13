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
using System.ComponentModel;
using System.IO;
using Microsoft.Win32;


namespace lab09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public  static class zmienne
    {
        public static string comboitem; 
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
            MyPopup.IsOpen = true;
        }

        private void Wersja_ang_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            MyPopup2.IsOpen = true;
            if (MyPopup2.IsOpen)
                e.Cancel = true;
            else
                e.Cancel = false;
            base.OnClosing(e);
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = false; 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog otworz = new OpenFileDialog();

            //string plik = "plik_sane.txt";
            string plik = ""; 
            if (otworz.ShowDialog() == true )
            {
                plik = otworz.FileName;
            }

            string lines = File.ReadAllText(plik);

            string [] rozdzielone = lines.Split(',');

            kierunek_textbox.Text = rozdzielone[0];
            zakes_studiów.Text = rozdzielone[1];
            profil_studiów.Text = rozdzielone[2];
            forma_studiów.Text = rozdzielone[3];
            poziom_studiów.Text = rozdzielone[4];
            student1_imie.Text = rozdzielone[5];
            student1_album.Text = rozdzielone[6];
            student2_imie.Text = rozdzielone[7];
            student2_album.Text = rozdzielone[8];
            student3_imie.Text = rozdzielone[9];
            student3_album.Text = rozdzielone[10];
            student4_imie.Text = rozdzielone[11];
            student4_album.Text = rozdzielone[12];
            tytul_pracy.Text = rozdzielone[13];
            Wersja_ang.Text = rozdzielone[14];
            dane_wejscie.Text = rozdzielone[15];
            zakres_pracy.Text = rozdzielone[16];
            oddanie_pracy.Text = rozdzielone[17];
            promotor.Text = rozdzielone[18];
            jedn_promotora.Text = rozdzielone[19];
            rodzaj_pracy.SelectedIndex = Int32.Parse(rozdzielone[20]); 


            
            

            MyPopup.IsOpen = false;
        }

        private void niewczytaj_Click(object sender, RoutedEventArgs e)
        {
            MyPopup2.IsOpen = false;
            App.Current.Shutdown();
        }

        private void wczytaj_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // if (saveFileDialog.ShowDialog() == true)
            //File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            //string filepath = "plik_sane.txt"; 
            //  string combo = zmienne.comboitem;  
            var combo = rodzaj_pracy.SelectedIndex; 
            string dane = kierunek_textbox.Text + ',' + zakes_studiów.Text + ',' + profil_studiów.Text + ',' + forma_studiów.Text + ',' + poziom_studiów.Text + ',' + student1_imie.Text + ',' + student1_album.Text + ',' + student2_imie.Text + ',' + student2_album.Text + ',' + student3_imie.Text + ',' + student3_album.Text + ',' + student4_imie.Text + ',' + student4_album.Text + ',' + tytul_pracy.Text + ',' + Wersja_ang.Text + ',' + dane_wejscie.Text + ',' + zakres_pracy.Text + ',' + oddanie_pracy.Text + ',' + promotor.Text + ',' + jedn_promotora.Text + ',' + combo;
           
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, dane);
            }
               




            MyPopup2.IsOpen = false;
            App.Current.Shutdown();
        }

        private void licencjat_Selected(object sender, RoutedEventArgs e)
        {
            zmienne.comboitem = "1";//licencjat.Content.ToString();
        }

        private void magisterka_Selected(object sender, RoutedEventArgs e)
        {
            zmienne.comboitem = "2";//magisterka.Content.ToString();
        }

        private void inżynierka_Selected(object sender, RoutedEventArgs e)
        {
            zmienne.comboitem = "3";//inżynierka.Content.ToString();
        }
    }
}
