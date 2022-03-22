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

namespace Lenght
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
       
        }
        string withoutspace;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label1.Content = "Lenght of string:  " + TextBox1.Text.Length;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            withoutspace = string.Concat(TextBox1.Text.Where(c => !Char.IsWhiteSpace(c)));
            Label1.Content = "Lenght of string:  " + withoutspace.Length;
        }
    }
}
