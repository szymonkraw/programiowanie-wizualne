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
using System.Media;
using Microsoft.Win32;
using System.Windows.Threading;
using System.IO;

namespace lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// 
    /// </summary>
    /// 
    public static class statyczna
    {
        public static string[] songs = new string[7] ;
        public static string czas; 
    }
    public partial class MainWindow : Window
    {
        //public static string[] songs; 
        public MediaPlayer mediaplayer = new MediaPlayer();
        public static string name;
        public static string name2;
        public static string imie = "";
        public MainWindow()
        {
           
            InitializeComponent();
          //  public MediaPlayer mediaPlayer = new MediaPlayer();
    }
     
        private void play_Click(object sender, RoutedEventArgs e)
        {
            /*
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaplayer.Open(new Uri(openFileDialog.FileName));
                mediaplayer.Play();
            }
            */

            //string file = "Billy Gilman - Jingle Bell Rock.mp3";
            // OpenFileDialog openFileDialog = new OpenFileDialog();
            string miejsce = Directory.GetCurrentDirectory().ToString();

            //Uri file = new Uri(miejsce + "/Billy Gilman - Jingle Bell Rock.mp3");

            //   DispatcherTimer timer = new DispatcherTimer();
            //  timer.Interval = TimeSpan.FromSeconds(1);
            //   timer.Tick += timer_Tick;
            //    timer.Start();



            //  DispatcherTimer timer = new DispatcherTimer();
            //  DispatcherTimer AudioPlayerTimer = new DispatcherTimer();

            //  if (mediaplayer.Position == mediaplayer.NaturalDuration)
            //    {
        //    string imie = "";
            /*
            if (imie != name)
            {
                Uri file = new Uri(miejsce + name);
                mediaplayer.Open(file);
                mediaplayer.Play();
                imie = name;

            }
            */
                if (mediaplayer.NaturalDuration > mediaplayer.Position)
                {
                // Uri file = new Uri(miejsce + name);
                //  mediaplayer.Open(file);
                if (imie != name)
                {
                    Uri file = new Uri(miejsce + name);
                    mediaplayer.Open(file);
                    mediaplayer.Play();
                    imie = name;

                }

                mediaplayer.Play();
                }
                else
                {
                    Uri file = new Uri(miejsce + name);
                    mediaplayer.Open(file);
                    mediaplayer.Play();
                }

                //    Uri file = new Uri(miejsce + name);
                //   mediaplayer.Open(file);

                  
                    mediaplayer.Play();
            
                 
            
                //     }
                
                
                /*
                do
                 {
                 

                 } while (mediaplayer.Position == mediaplayer.NaturalDuration);
                */
                
                 
         //   mediaplayer.Open(file);
            
          //  mediaplayer.Play(); 

        }
        /*
        void timer_Tick(object sender, EventArgs e)
        {
            if (mediaplayer.Source != null)
                String.Format("{0} / {1}", mediaplayer.Position.ToString(@"mm\:ss"), mediaplayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
         
        }
        */
        private void stop_Click(object sender, RoutedEventArgs e)
        {
            mediaplayer.Pause();   
        }



        private void song1_Checked(object sender, RoutedEventArgs e)
        {
            string song1_name = "/s1.mp3";
            statyczna.songs[0] = song1_name;
            name = song1_name; 
        }

        private void song1_Unchecked(object sender, RoutedEventArgs e)
        {
           
        }

        private void song2_Checked(object sender, RoutedEventArgs e)
        {
            string song2_name = "/s2.mp3";
            //statyczna.songs.Append(song2_name);
            statyczna.songs[1] = song2_name;
            name = song2_name;

        }

        private void song2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void song3_Checked(object sender, RoutedEventArgs e)
        {
            string song3_name = "/s3.mp3";
            statyczna.songs[2] = song3_name;
            name = song3_name;
        }

        private void song3_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void song4_Checked(object sender, RoutedEventArgs e)
        {
            string song4_name = "/s4.mp3";
            statyczna.songs[3] = song4_name;
            name = song4_name;
        }

        private void song4_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void song5_Checked(object sender, RoutedEventArgs e)
        {
            string song5_name = "/s5.mp3";
            statyczna.songs[4] = song5_name;
            name = song5_name;
        }

        private void song5_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void song6_Checked(object sender, RoutedEventArgs e)
        {
            string song6_name = "/s6.mp3";
            statyczna.songs[5] = song6_name;
            name = song6_name;
        }

        private void song6_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void song7_Checked(object sender, RoutedEventArgs e)
        {
            string song7_name = "/s7.mp3";
            statyczna.songs[6] = song7_name;
            name = song7_name;
        }

        private void song7_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}

