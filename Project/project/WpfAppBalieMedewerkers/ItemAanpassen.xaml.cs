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
    /// Interaction logic for ItemAanpassen.xaml
    /// </summary>
    public partial class ItemAanpassen : Page
    {
        ItemPage venster1;
        int id;
        string foto;
        public ItemAanpassen(ItemPage item, int id1)
        {
            InitializeComponent();
            this.venster1 = item;
            this.id = id1;


            Item item1 = Item.GetElementId(id);
            txtIdInvoer.Text = Convert.ToString(item1.Id);
            txtTitelInvoer.Text = item1.Titel;
            txtBeschrijving.Text = item1.Beschrijving;
            txtUitgeverijInvoer.Text = item1.Uitgeverij;
            txtLeeftijdVanInvoer.Text = Convert.ToString(item1.LeeftijdVan);
            txtLeeftijdTotInvoer.Text = Convert.ToString(item1.LeeftijdTot);
            txtTaalInvoer.Text = item1.Taal;

        }

        private void btnKiesFoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Afbeeldingen|.jpg;.png";
           
            if (dialog.ShowDialog() == true)
            {
                foto = dialog.FileName;
           
            }

        }

        private void btnAanpassen_Click(object sender, RoutedEventArgs e)
        {

            if (rdbJa.IsChecked == true)
            {
                Item item1 = new Item();
                item1.ItemAanpassen(Convert.ToInt32(txtIdInvoer.Text), txtTitelInvoer.Text, foto, txtBeschrijving.Text, txtUitgeverijInvoer.Text, Convert.ToInt32(txtLeeftijdVanInvoer.Text), Convert.ToInt32(txtLeeftijdTotInvoer.Text), txtTaalInvoer.Text);
                venster1.LoadItem(null);
            } 
            else if(rdvNeen.IsChecked == true)
            {
                Item item1 = new Item();
                item1.ItemAanpassenZonderFoto(Convert.ToInt32(txtIdInvoer.Text), txtTitelInvoer.Text, txtBeschrijving.Text, txtUitgeverijInvoer.Text, Convert.ToInt32(txtLeeftijdVanInvoer.Text), Convert.ToInt32(txtLeeftijdTotInvoer.Text), txtTaalInvoer.Text);
                venster1.LoadItem(null);
            }
           

        }
    }
}
