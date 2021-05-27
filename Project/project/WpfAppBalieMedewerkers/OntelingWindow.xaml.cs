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
    /// Interaction logic for OntelingWindow.xaml
    /// </summary>
    public partial class OntelingWindow : Page
    {
        public OntelingWindow()
        {
            InitializeComponent();
            Ontleningen();
        }

       

        private void btnTerugbrengen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem listbox = (ListBoxItem)lbxDataOntleningen.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MessageBoxResult result = MessageBox.Show($"U zal het item terug brengen", "Terugbrengen?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;

            Ontelening ontleing = Ontelening.OntelingID(id);
            ontleing.OntleningTerug();
            lbxDataOntleningen.Items.Clear();
          


        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {
            lbxDataOntleningen.Items.Clear();
            int id = Convert.ToInt32(txtZoek.Text);
            List<Ontelening> ontleningen = Ontelening.OntelingIdAll(id);

            foreach (Ontelening ontleing in ontleningen)
            {
                ListBoxItem lisbox = new ListBoxItem();
                lisbox.Content = ontleing.ToString();
                lisbox.Tag = ontleing.Id;
                lbxDataOntleningen.Items.Add(lisbox);
            }
        }

        public void Ontleningen()
        {
            lbxDataOntleningen.Items.Clear();
            List<Ontelening> ontleningen = Ontelening.AllOnteleningen();
            foreach (Ontelening ontleing in ontleningen)
            {
                ListBoxItem lisbox = new ListBoxItem();

                lisbox.Content = ontleing.ToString();
                lisbox.Tag = ontleing.Id;
                lbxDataOntleningen.Items.Add(lisbox);
            }
        }

        private void lbxDataOntleningen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lst = (ListBoxItem)lbxDataOntleningen.SelectedItem;
            if (lst == null) return;
            int id = Convert.ToInt32(lst.Tag);

            Ontelening ont = Ontelening.OntelingID(id);

            lblId.Content = ont.Id;
            dprDatumUit.SelectedDate = ont.DatumUit;
            dprDatumIN.SelectedDate = ont.UiterstedatumIn;
            dprWerkelijkeDatum.SelectedDate = ont.WerkelijkeDatumIn;
            lblBoeteBedrag.Content = ont.BoeteBedrag;
            dprBoeteVoldaan.SelectedDate = ont.BoeteVoldaanOp;
            lblExemplaarId.Content = ont.ExemplaarId;
            lblLidnummer.Content = ont.Lidnummer;
        }
    }
}
