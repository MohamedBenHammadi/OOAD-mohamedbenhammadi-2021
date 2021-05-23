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
using EmpClassLibrary;
using System.Configuration;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Specialized;


namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connString = ConfigurationManager.AppSettings["connString"];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ItemPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Main.Content = new Klanten();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reservatie venster = new Reservatie();
            venster.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OntelingWindow venster = new OntelingWindow();
            venster.Show();
            this.Close();
            
        }
    }
}
