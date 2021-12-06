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

namespace lab08
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string szcz = ""; 
            if(sprawdzanie.icao_zazn == 1 )
            {
                szcz =  szcz + sprawdzanie.icaoo + "\n";
            }

            if (sprawdzanie.iata_zazn == 1)
            {
                szcz =  szcz + sprawdzanie.iataa + "\n";
            }

            if (sprawdzanie.pasa_zazn == 1)
            {
                szcz = szcz + sprawdzanie.pasazerr + "\n";
            }

            if (sprawdzanie.woj_zazn == 1)
            {
                szcz =  szcz + sprawdzanie.wojewodztwoo + "\n";
            }

            if (sprawdzanie.miasto_zazn == 1)
            {
                szcz =  szcz + sprawdzanie.miastoo + "\n";
            }

            szczegoly.Content = szcz; 

            // szczegoly.Text = ;
        }
    }
}
