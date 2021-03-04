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

namespace WpfPunten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

   
    public partial class MainWindow : Window
    {

        int aantal = 0;
        public MainWindow()
        {
            InitializeComponent();

        }
      
        private void btnToeveogen_Click(object sender, RoutedEventArgs e)
        {
            lstNamen.Items.Add($"{txtNaam.Text} - {txtPunt.Text}/100");
            aantal++;
            txtNaam.Clear();
            txtPunt.Clear();
            
            
        }

        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            lstNamen.Items.Remove(lstNamen.SelectedItem);
        }

        private void lstNamen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (aantal > 0)
            {
                btnVerwijder.IsEnabled = true;

            }
            else
            {
                btnVerwijder.IsEnabled = false;
            }
        }
    }
}
