
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
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            
            InitializeComponent();
            //statyczna.szukana_dana; 
            int i = 0;
            bool is_integer = int.TryParse(statyczna.szukana_dana, out i);


            if(is_integer == true)
            {
                //int liczba = int.Parse(statyczna.szukana_dana);
                foreach (dane cos in statyczna.lista_globalna)
                {
                    if (cos.Liczba == i)
                    {
                        lista_szukane.Items.Add(cos);
                    }

                }

            }

            if(is_integer == false)
            {

            
            foreach (dane cos in  statyczna.lista_globalna)
                {
                if(cos.Imie == statyczna.szukana_dana )
                {
                    lista_szukane.Items.Add(cos);
                }
                
            }
            }


            lista_szukane.Items.Refresh();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
