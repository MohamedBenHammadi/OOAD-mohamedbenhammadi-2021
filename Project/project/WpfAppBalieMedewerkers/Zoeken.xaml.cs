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
using System.Linq;
using EmpClassLibrary;

namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for Zoeken.xaml
    /// </summary>
    public partial class Zoeken : Window
    {
        private List<Leden> item ;
        public Zoeken()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void wrpKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var foundObjects = item.Where((myObject) => myObject.Achternaam.Equals(txtZoek.Text.ToLower(), StringComparison.OrdinalIgnoreCase));
        }
    }
}
