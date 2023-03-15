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
using System.Windows.Shapes;

namespace Test2
{
    /// <summary>
    /// Логика взаимодействия для AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddPersonWindow()
        {
            InitializeComponent();
        }
        

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            FirstName = tb_firstname.Text;
            LastName = tb_lastname.Text;
            DialogResult = true;
        }
    }
}
