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
    /// Interaction logic for ReservatiePage.xaml
    /// </summary>
    public partial class ReservatiePage : Page
    {
        public ReservatiePage()
        {
            InitializeComponent();
        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {

            lbxDataReservatie.Items.Clear();
            List<Reservatie> reservati = Reservatie. Convert.ToInt32(txtZoek.Text));
            foreach (Reservatie reservatie in reservaties)
            {
                ListBoxItem listbox = new ListBoxItem();

                listbox.Content = reservatie.ToString();
                listbox.Tag = reservatie.;
                lbxDataReservatie.Items.Add(listbox);
            }
        }
    }
}
