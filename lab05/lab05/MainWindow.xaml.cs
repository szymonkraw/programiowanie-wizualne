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
using Microsoft.Win32;
using System.Drawing;
using System.Collections; 

namespace lab05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// (sek.Length - wzor.Length)

  


   static  public class findpattern
    {
     //  public  int   znalezione_wzorce = 0 ; 
      static   public int patterncount(string sek, string wzor)
        {
            int liczba = 0;
            int odl = sek.Length - wzor.Length;

            for (int i = 0; i < odl - 4; i++)
            {
                if (sek.Substring(i, 4) == wzor)
                {
                    liczba++;
                }
            }
            return liczba;

        }
        /*
     static  public string[] szuk_lancuch(string sekw)
        {
            string wzorzec = "";
            int[] liczba_wyst = { } ;
            string[] wzorce = { }; 


            for(int i = 0; i <(sekw.Length - 4); i++)
            {
                wzorzec = sekw.Substring(i, 4);
                //patterncount(sekw, wzorzec);
                wzorce.Append(wzorzec);
              //  liczba_wyst.Append(patterncount(sekw, wzorzec));
            }

            return wzorce;// , wzorce; 
        }
        
        */

       static public string szuk(string Text)
        {
            string wz = "";
            int k = 4;
            ArrayList Count = new ArrayList();
            for (int i = 0; i < Text.Length - k; i++)
            {
                string Pattern = Text.Substring(i, k);
                Count.Add(patterncount(Text, Pattern));
            }
            for (int i = 0; i < Text.Length - k; i++)
            {
                if (wz.Contains(Text.Substring(i, k)) == false)
                {
                   wz += Text.Substring(i, k);
                   wz += " " + Count[i].ToString() + "\n";
                  //  return FrequentPatterns; 
                }
            }
            return wz;
        }



    }







    public partial class MainWindow : Window
    {

        public string[] wzr; 

        static public string wzorce = "";
     static    public string sekwencja = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wczyt_sekw_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string sciezka= new string(openFileDialog.FileName);
                // obraz = fileUri;
                //img.Source = new BitmapImage(fileUri);
                
                sekwencja = File.ReadAllText(sciezka);
                sekwencja_text.Text = sekwencja;
                
            }
        }

        private void sekwencja_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void znajdz_wzr_Click(object sender, RoutedEventArgs e)
        {
             szukane_wzorce.Text = findpattern.szuk(sekwencja);
             
           //  ItemsControl item1  = new ItemsControl() ;
            
            wzorce =     findpattern.szuk(sekwencja);
            char[] delims = new[] { ' ', '\n' };
             wzr = wzorce.Split(delims);
            //string[] wzr = wzorce.Split(' ');
        
            for(int i = 0; i < wzr.Length -1 ; i = i+ 2 )
            {
                wybor.Items.Add(wzr[i]);
            }

            
        }

        private void wybor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // wybor.ItemsSource = wzr[2]; 
            string wybrana = wybor.Text;

            for (int i = 0; i <sekwencja.Length; i ++)
            {
                if (sekwencja.Substring(i, 4) == wybrana)
                {
                    wybor.Text.Substring(i, 4) ; 
                }
            }


            // sekwencja_text.Text = wybrana; 

        }
    }
}
