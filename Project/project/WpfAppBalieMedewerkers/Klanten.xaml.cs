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
using EmpClassLibrary;

namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for Klanten.xaml
    /// </summary>
    public partial class Klanten : Page
    {
        public Klanten()
        {
            InitializeComponent();
            LoadKlant(null);
        }


        public void LoadKlant(int? selectedId)
        {
            wrpKlant.Items.Clear();
            List<Leden> klant = Leden.LijstLeden();

            foreach (Leden klanten in klant)
            {

                ListBoxItem listbox = new ListBoxItem();
                listbox.Content = klanten.ToString();

                listbox.Tag = klanten.Lidnummer;
                listbox.IsSelected = selectedId == klanten.Lidnummer;

                wrpKlant.Items.Add(listbox);


            }

            wrpKlant.BorderBrush = Brushes.White;
        }



        private void wrpKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lst = (ListBoxItem)wrpKlant.SelectedItem;
            if (lst == null) return;
            int id = Convert.ToInt32(lst.Tag);


            Leden klant = Leden.GetKlanttId(id);

            lblidnummer.Content = klant.Lidnummer;
            lblVoornaam.Content = klant.Voornaam;
            lblAchternaam.Content = klant.Achternaam;
            lblGEboortedatum.Content = klant.Geboortedatum;
            lblStraat.Content = klant.Straat;
            lblNummer.Content = klant.Nummer;
            lblPostcode.Content = klant.Postcode;
            lblGemeente.Content = klant.Gemeente;
            lblVervalDatum.Content = klant.VervaldatumLidkaart;
            lblGsm.Content = klant.Gsm;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListBoxItem listbox = (ListBoxItem)wrpKlant.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MessageBoxResult result = MessageBox.Show($"Opgespast! wilt u  lid {lblVoornaam.Content} verwijderen?", "verwijderen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;

            Leden lid = Leden.GetKlanttId(id);
            lid.Verwijderklant();
            LoadKlant(null);
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new KlantToevoegen(this);
        }

        private void btnAanpassen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem listbox = (ListBoxItem)wrpKlant.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MainToevoegen.Content = new KlantAanpassen(this, id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem listbox = (ListBoxItem)wrpKlant.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MainToevoegen.Content = new LidkaarVernieuwen(this, id);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zoeken venster = new Zoeken();
            venster.Show();
        }
    }
}
