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
using System.Security.Cryptography;

namespace lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 




    
    public class Decode
    {

        public static string Dekrypt(string text, string klucza)
        {
            if(klucza.Length!=32 )
            {
                return "ERROR"; 
            }

            byte[] text_b = new byte[16];
            byte[] buff = Convert.FromBase64String(text);

            using (Aes obj = Aes.Create())
            {
                obj.Mode = CipherMode.ECB;
                obj.Key = Encoding.UTF8.GetBytes(klucza);
                obj.IV = text_b;
                ICryptoTransform deskrypt= obj.CreateDecryptor(obj.Key, obj.IV);

                using (MemoryStream memory = new MemoryStream(buff))
                {
                    using (CryptoStream crypto = new CryptoStream((Stream)memory, deskrypt, CryptoStreamMode.Read))
                    {
                        using (StreamReader Reader = new StreamReader((Stream)crypto))
                        {            
                                return Reader.ReadToEnd();                      
                        }
                    }
                }
            }
        }
    }
    


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void odkryj_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            result = Decode.Dekrypt(hash.Text, pass.Text); 
        
            wynik.Text = result;
        }

        private void load_Click(object sender, RoutedEventArgs e)
        {
            string wczytane = "";
            wczytane = File.ReadAllText("plik.txt");
            hash.Text = wczytane;
           


        }
    }
}
