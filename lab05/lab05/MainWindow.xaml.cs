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
using System.Runtime.InteropServices;


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



        /*
        private const int WM_USER = 0x0400;
        private const int EM_SETEVENTMASK = (WM_USER + 69);
        private const int WM_SETREDRAW = 0x0b;
        private IntPtr OldEventMask;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public void BeginUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
            OldEventMask = (IntPtr)SendMessage(this.Handle, EM_SETEVENTMASK, IntPtr.Zero, IntPtr.Zero);
        }

        public void EndUpdate()
        {
            SendMessage(this.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            SendMessage(this.Handle, EM_SETEVENTMASK, IntPtr.Zero, OldEventMask);
        }
        */


        public string[] wzr;

        static public string wzorce = "";
        static public string sekwencja = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wczyt_sekw_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string sciezka = new string(openFileDialog.FileName);
                // obraz = fileUri;
                //img.Source = new BitmapImage(fileUri);

                sekwencja = File.ReadAllText(sciezka);
                sekwencja_text.AppendText(sekwencja);
                // Add(newRun(sekwencja)); 
                //   sekwencja_text.Text = sekwencja;

            }
        }

        private void sekwencja_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void znajdz_wzr_Click(object sender, RoutedEventArgs e)
        {
            szukane_wzorce.Text = findpattern.szuk(sekwencja);

            //  ItemsControl item1  = new ItemsControl() ;

            wzorce = findpattern.szuk(sekwencja);
            char[] delims = new[] { ' ', '\n' };
            wzr = wzorce.Split(delims);
            //string[] wzr = wzorce.Split(' ');

            for (int i = 0; i < wzr.Length - 1; i = i + 2)
            {
                wybor.Items.Add(wzr[i]);
            }


        }

        /*
        static public void sprawdz (int poz, string znl)
        {
            if (sekwencja.Substring(poz+1, 4 )==znl)
            {
                TextRange rangeoftext = new TextRange(sekwencja_text.Document.ContentEnd, sekwencja_text.Document.ContentEnd);
                //rangeoftext.Text = wybrana;
                //i = i + 4 ; 
                rangeoftext.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
            }
        }
        */

        //private TextPointer caretBefore = null;
        private void wybor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wybor.Items.Refresh();


            TextRange czysc = new TextRange(sekwencja_text.Document.ContentStart, sekwencja_text.Document.ContentEnd);
            czysc.Text = "";
            czysc.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);

            string wybrana = wybor.Text;
            int pozycja = 0;

            int spr = 0;

            for (int i = 0; i < sekwencja.Length - 4; i++)
            {

                if (sekwencja.Substring(i, 4) == wybrana)
                {


                    if (spr == 0)
                    {
                        sekwencja_text.AppendText(sekwencja.Substring(0, i));  //lub samo i - 1 to jeszcze można zmienić 
                        spr = i + 4;



                        TextRange rangeoftext = new TextRange(sekwencja_text.Document.ContentEnd, sekwencja_text.Document.ContentEnd);
                        rangeoftext.Text = wybrana;
          
                        rangeoftext.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);

                        i = i + 4;

                        pozycja = i-4 ;
                    }
              

                    else if (spr != 0)
                    {

                        sekwencja_text.AppendText(sekwencja.Substring(spr, i - spr  ));
                        spr = i + 4;

                        TextRange rangeoftext1 = new TextRange(sekwencja_text.Document.ContentEnd, sekwencja_text.Document.ContentEnd);
                        rangeoftext1.Text = wybrana;
                        //i = i + 4 ; 
                        rangeoftext1.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
                      //  pozycja = i;
                        i = i + 4;

                      //  TextRange rangeoftext2 = new TextRange(sekwencja_text.Document.ContentEnd, sekwencja_text.Document.ContentEnd);
                      //  rangeoftext2.Text = wybrana;
                     //   i = i + 4;
                     //   rangeoftext2.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);

                        pozycja = i -4 ;

                    }



                }
            }


                TextRange kolor = new TextRange(sekwencja_text.Document.ContentEnd, sekwencja_text.Document.ContentEnd);
                kolor.Text = sekwencja.Substring(pozycja + 4, sekwencja.Length - (pozycja + 4 ));
                kolor.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);


            }
        }
    }

