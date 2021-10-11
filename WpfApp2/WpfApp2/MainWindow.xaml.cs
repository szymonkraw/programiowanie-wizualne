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

namespace WpfApp2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			var czas = new System.Windows.Threading.DispatcherTimer();
			czas.Tick += new EventHandler(ustaw_zegar);
			czas.Interval = new TimeSpan(0, 0, 1);
			czas.Start(); 
		}
		private void ustaw_zegar(object sender, EventArgs e)
		{
			
			zegar.Content = DateTime.Now.Hour;
			zegar2.Content = DateTime.Now.Minute; 
			
			CommandManager.InvalidateRequerySuggested();
		}


		private void open(object sender, RoutedEventArgs e)
		{
			Window1 drugie_okno = new Window1();
			//this.Visibility = Visibility.Hidden;
			drugie_okno.Show();
		}
		
	}
}
