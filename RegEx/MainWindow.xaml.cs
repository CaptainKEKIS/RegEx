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
            lbListBox.ItemsSource = new[]
            {
                new RegexChecker(@"^a$|^aaaaaa$|^a\saa\sa$"),
                new RegexChecker(@"^[A-Za-z]{5,}$"),
                new RegexChecker("jhgjhgjhgjhgjh"),
                new RegexChecker("jhgjhgjhgjhgjh"),
                new RegexChecker("jhgjhgjhgjhgjh"),
                new RegexChecker("jhgjhgjhgjhgjh")
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((sender as Button).DataContext as RegexChecker).Check();
        }


        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    Regex r1 = new Regex(@"^[A-Za-z]{5,}$");
        //    if (r1.IsMatch(TBDva.Text))
        //    {
        //        MessageBox.Show("OK!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not OK!");
        //    }
        //}
        ////([A-Za-z0-9]+\-*[A-Za-z0-9]+)+
        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    Regex r1 = new Regex(@"^[A-Za-z\d][A-Za-z\d\-]*[A-Za-z\d]@[A-Za-z]{2,}\.[A-Za-z]{2,}$");
        //    if (r1.IsMatch(TBTri.Text))
        //    {
        //        MessageBox.Show("OK!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not OK!");
        //    }
        //}

        //private void Button_Click_3(object sender, RoutedEventArgs e)
        //{
        //    Regex r1 = new Regex(@"^[А-Яа-яё][А-Яа-яё\-]*[А-Яа-яё]$");
        //    if (r1.IsMatch(TBTri.Text))
        //    {
        //        MessageBox.Show("OK!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not OK!");
        //    }
        //}
    }
}
