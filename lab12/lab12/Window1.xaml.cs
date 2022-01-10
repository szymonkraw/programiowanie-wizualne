using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System;
using System.Windows.Threading; 

namespace lab12
{

    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        public Button CreateAButton()

        {

            Button btn = new Button();

            btn.Height = 80;

            btn.Width = 150;

            btn.Content = "Click ME";

            btn.Background = new SolidColorBrush(Colors.Orange);

            btn.Foreground = new SolidColorBrush(Colors.Black);


            // stack.Children.Add(btn);
            return btn;

        }

        DispatcherTimer _timer;

        TimeSpan _time;

        public Window1()
        {


            InitializeComponent();

            int level_chosen = 0;

            if (statyczna.chosen_level == "Easy")
            {
                level_chosen = 3;
            }
            else if (statyczna.chosen_level == "Medium")
            {
                level_chosen = 4;
            }
            else if (statyczna.chosen_level == "Hard")
            {
                level_chosen = 5;
            }




            Random rnd = new Random();


            int count = 1;
            var img = new ImageBrush();

            if (statyczna.chosen_animal == "Aligator")
         
            {
                statyczna.img_all.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/OIP.tzlfO00VTtvSKLEyRHyelwHaE8?pid=ImgDet&rs=1"));
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/OIP.tzlfO00VTtvSKLEyRHyelwHaE8?pid=ImgDet&rs=1"));
            }
            if (statyczna.chosen_animal == "Kot")
            {
                statyczna.img_all.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/R.b1bdce2d470e5ab09dd37c36552aa342?rik=tUoUbMn%2fdGSQtg&pid=ImgRaw&r=0"));
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://th.bing.com/th/id/R.b1bdce2d470e5ab09dd37c36552aa342?rik=tUoUbMn%2fdGSQtg&pid=ImgRaw&r=0"));
            }
            if (statyczna.chosen_animal == "Ryba")
            {
                statyczna.img_all.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://i.pinimg.com/originals/a2/12/ef/a212ef6cf59f1df07a582be018729bdb.jpg"));
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://i.pinimg.com/originals/a2/12/ef/a212ef6cf59f1df07a582be018729bdb.jpg"));
            }
            if (statyczna.chosen_animal == "Mysz")
            {
                statyczna.img_all.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://i.redd.it/7tog0eta7tf21.jpg"));
                img.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri("https://i.redd.it/7tog0eta7tf21.jpg"));
            }

            _time = TimeSpan.FromSeconds(5);

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {

                if (_time == TimeSpan.Zero )
                {
                    _timer.Stop();

                    Window3 nowe2 = new Window3();
                    nowe2.Show();
                    Close();
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);


            for (int i = 0; i < level_chosen; i++)
            {
                for (int j = 0; j < level_chosen; j++)
                {
                    Button MyControl1 = new Button();
                    //MyControl1.Content = "check Me ";
                    MyControl1.Name = "Button" + count.ToString();
                    //   MyControl1.Click += new EventHandler(Button_Click);

                

                 

                    MyControl1.Click += (s, e) => {
                         
                           int num = rnd.Next(10);

                           if (num < 3 )
                           {
                            _timer.Stop();
                            MyControl1.Background = img;
                            if(statyczna.chosen_animal=="Aligator")
                            {
                                Window4 nowsze = new Window4();
                                nowsze.Show();
                            }
                               Window2 nowe = new Window2();
                               nowe.Show();
                               Close();
                           }
                           else
                           {
                               MyControl1.Background = null ; 
                           }
                       };

                    Grid.SetColumn(MyControl1, j);
                    Grid.SetRow(MyControl1, i);
                    grid1.Children.Add(MyControl1);

                    count++;
                }

            }



        }



    }
}
