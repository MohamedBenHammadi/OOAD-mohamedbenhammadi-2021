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

namespace WpfAppLeden
{
    /// <summary>
    /// Interaction logic for CheckStock.xaml
    /// </summary>
    public partial class CheckStock : Page
    {
        public CheckStock()
        {
            InitializeComponent();
     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idInvoer;

            idInvoer = txtInvoer.Text;

            lblVoorraad.Content = Exemplaar.CheckStock(Convert.ToInt32(idInvoer));
           
        }
        
   
    }
}
