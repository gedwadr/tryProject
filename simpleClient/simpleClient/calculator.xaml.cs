using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace simpleClient
{
    /// <summary>
    /// Interaction logic for calculator.xaml
    /// </summary>
    public partial class calculator : Window
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button10.Content.ToString();
            number2.Text = button10.Content.ToString();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button2.Content.ToString();
            number2.Text = button2.Content.ToString();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button5.Content.ToString();
            number2.Text = button5.Content.ToString();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button8.Content.ToString();
            number2.Text = button8.Content.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button1.Content.ToString();
            number2.Text = button1.Content.ToString();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button4.Content.ToString();
            number2.Text = button4.Content.ToString();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button7.Content.ToString();
            number2.Text = button7.Content.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button3.Content.ToString();
            number2.Text = button3.Content.ToString();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button6.Content.ToString();
            number2.Text = button6.Content.ToString();

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = button9.Content.ToString();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.ImathServiceClient calculatorClient = new ServiceReference1.ImathServiceClient();
            result.Text = calculatorClient.Plus(int.Parse(number1.Text), int.Parse(number2.Text)).ToString();

        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.ImathServiceClient calculatorClient = new ServiceReference1.ImathServiceClient();
            result.Text = calculatorClient.Min(int.Parse(number1.Text), int.Parse(number2.Text)).ToString();

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.ImathServiceClient calculatorClient = new ServiceReference1.ImathServiceClient();
            result.Text = calculatorClient.Cross(int.Parse(number1.Text), int.Parse(number2.Text)).ToString();

        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.ImathServiceClient calculatorClient = new ServiceReference1.ImathServiceClient();
            result.Text = calculatorClient.Div(int.Parse(number1.Text), int.Parse(number2.Text)).ToString();

        }
    }
}
