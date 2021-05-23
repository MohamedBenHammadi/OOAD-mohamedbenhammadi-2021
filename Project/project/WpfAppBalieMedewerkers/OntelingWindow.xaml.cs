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

namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for OntelingWindow.xaml
    /// </summary>
    public partial class OntelingWindow : Window
    {
        public OntelingWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow venster = new MainWindow();
            this.Close();
        }

        private void btnTerugbrengen_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new OntelingTerugBrengen();
            lblActie.Content = "Terug brengen";
        }

        private void btnExit_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow venster = new MainWindow();
            venster.Show();
            this.Close();
        }
    }
}
