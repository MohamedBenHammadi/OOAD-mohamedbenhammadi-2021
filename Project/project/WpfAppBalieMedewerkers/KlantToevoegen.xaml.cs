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
    /// Interaction logic for KlantToevoegen.xaml
    /// </summary>
    public partial class KlantToevoegen : Page
    {
        Klanten klantToevoegen;
        public KlantToevoegen(Klanten klant)
        {
            InitializeComponent();
            this.klantToevoegen = klant;
        }

        private void btnVoegKlantToe_Click_1(object sender, RoutedEventArgs e)
        {
            Leden klant = new Leden();
            klant.Voegklant(Convert.ToInt32(txtLidnummer.Text), txtVoornaamInvoer.Text, txtAchternaaminvoer.Text, dbpGeboorteDatum.DisplayDate, txtNummer.Text, txtStraatInvoer.Text, Convert.ToInt32(txtpostcode.Text), txtGemeente.Text, dpVervalDatum.DisplayDate, txtGsmInvoer.Text);
            klantToevoegen.LoadKlant(null);
            lbSucces.Content = "Klant toegevoegd";
        }
    }
}
