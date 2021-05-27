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
    /// Interaction logic for ReserverenPage.xaml
    /// </summary>
    public partial class ReserverenPage : Page
    {
        MainWindow venster;
        int klant;
        public ReserverenPage( MainWindow reser, int id)
        {
            InitializeComponent();
   
            this.venster = reser;
            this.klant= id;
            Reservaties();
        }
     
        private void btnAnuleerReservering_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem lisbox = (ListBoxItem)lstReservatie.SelectedItem;
            int id = Convert.ToInt32(lisbox.Tag);
            Reservatie reservatie = Reservatie.ReservatieId(id);
            MessageBoxResult result = MessageBox.Show($"Opgepast u zal de reservatie Annuleren?", "Annuleren?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;
            reservatie.VerwijderReservatie();
            Reservaties();
      
        }

    
        public void Reservaties()
        {
            lstReservatie.Items.Clear();
            List<Reservatie> reservaties = Reservatie.LijstReservatie(klant);
            foreach (Reservatie reservatie in reservaties)
            {
                ListBoxItem listbox = new ListBoxItem();

                listbox.Content = reservatie.ToString();
                listbox.Tag = reservatie.Id;
                lstReservatie.Items.Add(listbox);
            }
            
        }

   
    }
}
