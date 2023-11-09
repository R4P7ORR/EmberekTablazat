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

namespace EmberekTablazat
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Ember> list = new List<Ember>();
		public MainWindow()
		{
			InitializeComponent();
			list.Add(new Ember("Nagy Árpi", 69));
			list.Add(new Ember("Lakatos Brendon", 27));
			list.Add(new Ember("Kerekes Pali", 16));

			emberek.ItemsSource = list;
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			string name = inputName.Text;
			int age = Convert.ToInt32(inputAge.Text);
			if (name != null && age > 0 )
			{
				list.Add(new Ember(name, age));
				emberek.Items.Refresh();
			}
		}

		private void btnDel_Click(object sender, RoutedEventArgs e)
		{
			if (!emberek.SelectedCells.Any())
			{
				MessageBox.Show("Nincs kiválasztott ember!");
			}
			else
			{
				for (int i = 0; i < list.Count ; i++)
				{
					if (list[i].Equals(emberek.SelectedItem))
					{
						list.Remove(list[i]);
						emberek.Items.Refresh();
					}
				}
			}
		}
	}
}
