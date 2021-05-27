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
    /// Interaction logic for KlantAanpassen.xaml
    /// </summary>
    public partial class KlantAanpassen : Page
    {
        Klanten klantAanpassen;
        int id;
        public KlantAanpassen( Klanten klant, int id)
        {
            InitializeComponent();
            this.id = id;
            this.klantAanpassen = klant;
            Leden klanten = Leden.GetKlanttId(id);

            txtLidnummer.Text = Convert.ToString(klanten.Lidnummer);
            txtVoornaamInvoer.Text = klanten.Voornaam;
            txtAchternaaminvoer.Text = klanten.Achternaam;
            dtbGeboorteDatum.SelectedDate = klanten.Geboortedatum;
            txtStraatInvoer.Text = klanten.Straat;
            txtNummer.Text = klanten.Nummer;
            txtpostcode.Text = Convert.ToString(klanten.Postcode);
            txtGemeente.Text = klanten.Gemeente;
            dprVervalDatum.SelectedDate = klanten.VervaldatumLidkaart;
            txtGsmInvoer.Text = klanten.Gsm;



        }

        private void btnPasKlantToe_Click(object sender, RoutedEventArgs e)
        {
            Leden klant = new Leden();
            klant.LidAanpassen(Convert.ToInt32(txtLidnummer.Text), txtVoornaamInvoer.Text, txtAchternaaminvoer.Text, dtbGeboorteDatum.DisplayDate, txtNummer.Text, txtStraatInvoer.Text, Convert.ToInt32(txtpostcode.Text), txtGemeente.Text, dprVervalDatum.DisplayDate ,txtGsmInvoer.Text);

            lbSucces.Content = "klant aangepast";
        }
    }
}
