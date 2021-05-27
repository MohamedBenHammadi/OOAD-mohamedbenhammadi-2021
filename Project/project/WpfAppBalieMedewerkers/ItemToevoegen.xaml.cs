using Microsoft.Win32;
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

namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for ItemToevoegen.xaml
    /// </summary>
    public partial class ItemToevoegen : Page
    {
        string foto;
        public ItemToevoegen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Afbeeldingen|.jpg;.png";
          
            if (dialog.ShowDialog() == true)
            {
                foto = dialog.FileName;
                txtFotoInvoer.Text = foto;
            }
        }

        private void brnVoegToe_Click(object sender, RoutedEventArgs e)
        {
            lblSucces.Content = "item toegevoegd";
            Item item = new Item();
            item.VoegItem(Convert.ToInt32(txtIdInvoer.Text),txtTitelInvoer.Text, foto, txtBeschrijvingInvoer.Text, txtUitgeverijInvoer.Text, Convert.ToInt32(txtLeeftijdVanInvoer.Text), Convert.ToInt32(txtLeeftijdTotInvoer.Text), txtTaalInvoer.Text);;
        }
    }
}
