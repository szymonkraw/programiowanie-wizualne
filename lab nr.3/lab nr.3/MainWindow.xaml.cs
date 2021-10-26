
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

namespace lab03
{




    public class dane
    {

        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int liczba;

        public int Liczba
        {
            get { return liczba; }
            set { liczba = value; }
        }


        public dane(string Imie, int Id, int Liczba)
        {
            this.Imie = Imie;
            this.Id = Id;
            this.Liczba = Liczba;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public static class podane_dane
    {
      public static  string imie_pod;
      public static int id_pod = 1;
      public static int liczba_pod;
    }



    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            lista.Items.Refresh();
            //   lista.Items.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
          
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
            // string lis = Convert.ToString(lista);
            //  File.WriteAllText("plik2.csv", lis); 
            //  System.Data.DataTable dt = new System.Data.DataTable("mytab") ; 
            //   foreach (ListViewItem item in lista.Items)
            //    {
            //   dt.Columns.Add(item.ToString());
            //  foreach (var it in item.SubItems)
            //   { dt.Rows.Add(it.ToString()); }
            // }
            // String t = (String)lista.Items[0].SubItems[0];

            /*
            var listView1 = new ListView();
            DataTable table = new DataTable();
            foreach (ListViewItem item in listView1.Items)
            {
                table.Columns.Add(item.ToString());
                foreach (var it in item.SubItems)
                    table.Rows.Add(it.ToString());
            }
            */
            //  TextWriter tw = new StreamWriter("SavedList.txt");

            /*
            // string[] linie = lista.ItemsSource ;  
            foreach(var cos in GridViewColumn.Imie)
            {
                tw.Write(cos);
            }
           // tw.Write(Imie);
            tw.Close(); 
           */




            /*
            StringBuilder args = new StringBuilder();
            args.Append("--logfile=duration_output.txt");
            foreach (var str in lista.ItemsSource)
            {
                args.Append(" ");
                args.Append(str);
            }

            */



            /*
            foreach(var ob in lista.ItemsSource)
            {
                tw.Write(ob);
            }
            */
            //  string polstr = string.Join(";", from item in lista.Items.Cast<ListViewItem>()  select @"""" + + @"""");
            //    string polstr = string.Join(";", lista.Items);
            //  tw.Write(args);

            // tw.Write(); 
            // tw.Close();




            /*
            const string sPath = "plikprzyklad.csv";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in )         {
               
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();
            
            */
            /*
            foreach(ListViewItem cos in lista.Items)
            {
                tw.Write(cos);
            }
            tw.Close();

*/

           // lista.ItemsSource = (System.Collections.IEnumerable)lista.Items ;

            using (StreamWriter przes = new StreamWriter("plik_zapis.csv"))
            {
                foreach (var cos in lista.Items)
                {
                   // dane sklad ;
                   if (cos is dane sklad )
                       {
                        przes.WriteLine(string.Join(";", sklad.Imie, sklad.Id, sklad.Liczba));
                       }
                }
            }

        }





        // var listOfObjects = File.ReadLines("theFile.csv").Select(line => new Item(line)).ToList();

    /*
        public IEnumerable<dane> ReadCSV(string fileName)
        {

            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));

            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                //  lista ppp = new lista();
                //  ilosc_wierszy = ilosc_wierszy + 1;
            
                return new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
               // lista.Items.Add(new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2])));
                //return lista.Items(); 
            });

            //lista.Items.Add(new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2])));
        }

        */

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();

           // ReadCSV("plik.csv");
            //  lista.Items.Add( ReadCSV("plik.csv"));
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




            //  lista.ItemSource.tolist();
            ////liczba_ob = 0; 
            //.Select(line => new dane(line)).ToList();
            //var pobrane  = File.ReadLines("plik.csv");
            /*
            string fileName = "plik.csv";
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));

            lines.Select(line =>
            {
                string[] data = line.Split(';');

                lista.Items.Add( new dane(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2])));
            });
            */



            lista.Items.Refresh();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // ItemsControl.ItemsSource(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod))
            podane_dane.id_pod = lista.Items.Count + 1;

            lista.Items.Add(new dane(podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));


            
            lista.Items.Refresh();
           // ItemsControl.ItemsControlFromItemContainer = lista.Items.Add((podane_dane.imie_pod, podane_dane.id_pod, podane_dane.liczba_pod));
        }
    }
}