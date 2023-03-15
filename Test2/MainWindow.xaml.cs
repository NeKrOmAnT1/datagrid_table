using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Test2
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> people = new ObservableCollection<Person>();

        public MainWindow()
        {
            InitializeComponent();
                data_grid.ItemsSource = people;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            AddPersonWindow add = new AddPersonWindow();
            if (add.ShowDialog() == true)
            {
                people.Add(new Person { FirstName = add.FirstName, LastName = add.LastName });
            }

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                people.Remove((Person)data_grid.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Больше так не делай");
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
