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
    /// Interaction logic for Reservatie.xaml
    /// </summary>
    public partial class Reservatie : Window
    {
        public Reservatie()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow venster = new MainWindow();
            venster.Show();
            this.Close();
        }
    }
}
