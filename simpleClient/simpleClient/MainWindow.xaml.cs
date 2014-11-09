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
using System.Windows.Navigation;
using System.Windows.Shapes;
using simpleClient.ServiceReference2;

namespace simpleClient
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Service1Client login = new Service1Client();
            string result = login.AuthenticateUser(usernameBox.Text, passwordBox.Text);
            MessageBox.Show(result);

            calculator cal = new calculator();

           // if (result.CompareTo("success") == 0)
                cal.Show();

        }
    }
}
