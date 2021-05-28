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
    /// Interaction logic for PageReservatie.xaml
    /// </summary>
    public partial class PageReservatie : Page
    {
        public PageReservatie()
        {
            InitializeComponent();
            ReservatieLaaden();
            lbxDataReservatie.BorderBrush = Brushes.White;


        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {
            lbxDataReservatie.Items.Clear();
            ListBoxItem lst = (ListBoxItem)lbxDataReservatie.SelectedItem;
            
            List<Reservatie> reservaties = Reservatie.LijstReservatie(Convert.ToInt32(txtZoek.Text));
            foreach (Reservatie reservatie in reservaties)
            {
                ListBoxItem listbox = new ListBoxItem();

                listbox.Content = reservatie.ToString();
                listbox.Tag = reservatie.Id;
                lbxDataReservatie.Items.Add(listbox);
            }
        }
        public void ReservatieLaaden()
        {
            lbxDataReservatie.Items.Clear();
            List<Reservatie> reservatie = Reservatie.LijsReservatieZonderId();
            lbxDataReservatie.BorderBrush = Brushes.White;
            foreach (Reservatie reser in reservatie)
            {
                ListBoxItem lisbox = new ListBoxItem();

                lisbox.Content = reser.ToString();
                lisbox.Tag = reser.Id;
                lbxDataReservatie.Items.Add(lisbox);
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lisbox = (ListBoxItem)lbxDataReservatie.SelectedItem;
            int id = Convert.ToInt32(lisbox.Tag);

            MessageBoxResult result = MessageBox.Show($"U zal de reserevatie annuleren?", "annuleren?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;

            Reservatie reservatie = Reservatie.ReservatieId(id);
            reservatie.VerwijderReservatie();
            ReservatieLaaden();
        }

        private void lbxDataReservatie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lst = (ListBoxItem)lbxDataReservatie.SelectedItem;
            if (lst == null)
            {
            
                return;
            }
            int id = Convert.ToInt32(lst.Tag);

            Reservatie reser = Reservatie.ReservatieId(id);

            lblId.Content = reser.Id;
            lblExemplaar_id.Content = reser.Exemplaarid;
            lblLid_lidnummer.Content = reser.Lidlidnummer;
            dprDatumReservatie.SelectedDate = reser.Datumreservatie;
        }
    }
}
