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



//using System.Windows.Media.Imaging;
//using System.Windows.Media.Color; 

namespace zobrazem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///         int liczba = 0; 
   



    public partial class MainWindow : Window
    {
   

        // public void RotateFlip(System.Drawing.RotateFlipType rotateFlipType);
        // public   int liczba = 0; 
        public int liczba = 0;
        public int obroc = 0; 
        public Uri obraz;
        public MainWindow()
        {
            InitializeComponent();
        }
     //   public static System.Windows.Media.Imaging.BitmapSource CreateBitmapSourceFromHBitmap(IntPtr bitmap, IntPtr palette, System.Windows.Int32Rect sourceRect, System.Windows.Media.Imaging.BitmapSizeOptions sizeOptions);

        public void b_Choose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                obraz = fileUri;
                img.Source = new BitmapImage(fileUri);
            }
        }
      
        // public Bitmap Generate_negative_image(Bitmap sourceimage)

        
        public System.Drawing.Bitmap Generate_negative_image(Bitmap sourceimage)

        {
            //Bitmap sourceimage = BitmapImage2Bitmap(sourceimage2); 
            System.Drawing.Color c;

            for (int i = 0; i < sourceimage.Width; i++)

            {

                for (int j = 0; j < sourceimage.Height; j++)

                {
                    c = sourceimage.GetPixel(i, j);

                    c = System.Drawing.Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

                    sourceimage.SetPixel(i, j, c);

                }

            }



            return sourceimage;

        }




        public System.Drawing.Bitmap green(Bitmap sourceimage)

        {
            //Bitmap sourceimage = BitmapImage2Bitmap(sourceimage2); 
            System.Drawing.Color c;

            for (int i = 0; i < sourceimage.Width; i++)

            {

                for (int j = 0; j < sourceimage.Height; j++)

                {
                    c = sourceimage.GetPixel(i, j);

                    //c = System.Drawing.Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);

                    //GOTOWE ODDAWANIE ZIELONEGO OBRAZU
                    
                    /*
                    c  = System.Drawing.Color.FromArgb(0,  c.G, 0);
                    sourceimage.SetPixel(i, j, c);
                    
                    */
                    
                    if (c.G>c.R && c.G>c.B )
                    {
                        c = System.Drawing.Color.FromArgb(c.R,c.G, c.B);
                        sourceimage.SetPixel(i, j, c);
                    }
                 else if (c.G < c.R || c.G < c.B)
                    {
                        c = System.Drawing.Color.FromArgb(255,255,255);
                        sourceimage.SetPixel(i, j, c);
                    }
                   



                }

            }



            return sourceimage;

        }









        //BITMAP TO BITMAPIMAGE 
        /*
        private BitmapImage BitmapToBitmapImage(System.Drawing.Bitmap bitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bitmap.Save(ms, bitmap.RawFormat);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
            }
            return bitmapImage;
        }

        */

        BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }


        private void b_A_Click(object sender, RoutedEventArgs e)
        {

            if (obroc == 0)
            {
                img.LayoutTransform = new ScaleTransform() { ScaleX = -1 };
                obroc++;
            }
            else if (obroc == 1)
            {
                img.LayoutTransform = new ScaleTransform() { ScaleX = 1 };
                obroc = 0;
            }
        }

        private void b_B_Click(object sender, RoutedEventArgs e)
        {


            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = obraz;
            if (liczba == 0)
            {
                bi.Rotation = Rotation.Rotate90;
                liczba++;
            }
            else if (liczba == 1)
            {
                bi.Rotation = Rotation.Rotate180;
                liczba++;
            }
            else if (liczba == 2)
            {
                bi.Rotation = Rotation.Rotate270;
                liczba++;
            }
            else if (liczba == 3)
            {
                bi.Rotation = Rotation.Rotate0;
                liczba = 0;
            }
            bi.EndInit();
            img.Source = bi;
            obraz = bi.UriSource;
        }

        private void b_C_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitm_gr = new BitmapImage();
            bitm_gr.BeginInit();
            bitm_gr.UriSource = obraz;
            bitm_gr.EndInit();

            Bitmap bitm2_gr = BitmapImage2Bitmap(bitm_gr);

            Bitmap wynik_gr = green(bitm2_gr);

            img.Source = BitmapToImageSource(wynik_gr);



        }





        public Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            // BitmapImage bitmapImage = new BitmapImage(new Uri("../Images/test.png", UriKind.Relative));

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new Bitmap(bitmap);
            }
        }
        /*   public static System.Drawing.Bitmap BitmapSourceToBitmap(BitmapSource srs)
           {
               System.Drawing.Bitmap btm = null;

               int width = srs.PixelWidth;

               int height = srs.PixelHeight;

               int stride = width * ((srs.Format.BitsPerPixel + 7) / 8);

               byte[] bits = new byte[height * stride];

               srs.CopyPixels(bits, stride, 0);


               return btm;
           }
           */

        private void b_D_Click(object sender, RoutedEventArgs e)
        {


            BitmapImage bitm = new BitmapImage();
            bitm.BeginInit();
            bitm.UriSource = obraz;
           


            //Bitmap bitm22 = BitmapImage2Bitmap(bitm);


            //BitmapImage bitm2 = new BitmapImage();
            bitm.EndInit();

            //  bitm2.StreamSource(Generate_negative_image(bitm));

            // img.CreateBitmapSourceFromHBitmap(bitm.GetHBitmap());
            // bitm2 = Generate_negative_image(bitm);
            Bitmap bitm2 = BitmapImage2Bitmap(bitm);

            Bitmap wynik = Generate_negative_image(bitm2);

            img.Source = BitmapToImageSource(wynik);
           

        }
    }
}