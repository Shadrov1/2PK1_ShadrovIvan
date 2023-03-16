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

namespace pz_25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }

        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }

        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }

        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }

        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }

        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }

        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }

        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }

        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }

        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }

        private void pressButton_addition_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
        }

        private void pressButton_subtraction_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }

        private void pressButton_multi_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }

        private void presButton_divide_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
        }

        private void pressButton_equal_Click(object sender, RoutedEventArgs e)
        {
            string expression = inputTextBlock.Text;
            inputTextBlock.Text = Calculation(expression).ToString();
        }
        private double Calculation(string expression)
        {

            return 0;
        }
    }
}