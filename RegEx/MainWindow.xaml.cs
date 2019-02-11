using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace RegEx
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Regex r1 = new Regex(@"^a$|^aaaaaa$|^a\saa\sa$");
            if (r1.IsMatch(TBOdin.Text))
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Not OK!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regex r1 = new Regex(@"^\w{5,}$");
            if (r1.IsMatch(TBDva.Text))
            {
                MessageBox.Show("OK!");
            }
            else
            {
                MessageBox.Show("Not OK!");
            }
        }
    }
}
