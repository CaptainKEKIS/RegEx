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
                new RegexChecker(@"^[A-Za-z\d][A-Za-z\d\-]*[A-Za-z\d]@[A-Za-z]{2,}\.[A-Za-z]{2,}$"),
                new Zadnie3Checker(@"^([А-ЯЁ][а-яё]+(\-[А-ЯЁ][а-яё]+)?):(\sширота)?\s(\d{1,3}(\,\d{4})?)\,(\sдолгота)?\s(\d{1,3}(\,\d{4})?)$"),
                new Zadanie5Checker(@"^(http://|https://|ftp://)?(www\.)?[A-Za-z\d][A-Za-z\d\-_]*[A-Za-z\d]\.[A-Za-z\d][A-Za-z\d\-_]*[A-Za-z\d](\.[A-Za-z\d][A-Za-z\d\-_]*[A-Za-z\d]){0,3}$")
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((sender as Button).DataContext as RegexChecker).Check();
        }
    }
}
