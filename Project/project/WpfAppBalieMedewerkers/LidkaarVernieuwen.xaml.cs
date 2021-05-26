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
    /// Interaction logic for LidkaarVernieuwen.xaml
    /// </summary
    /// 
    /// 
    
    public partial class LidkaarVernieuwen : Page
    {

        Klanten venster;
        int id;

        public LidkaarVernieuwen(Klanten klanten , int id)
        {
            InitializeComponent();
            this.venster = klanten;
            this.id = id;

            Leden klant = Leden.GetKlanttId(id);

            dprVervalDatum.SelectedDate = klant.VervaldatumLidkaart;
        }

        private void btnPasVervaldatum_Click(object sender, RoutedEventArgs e)
        {
            Leden klant = new Leden();
            klant.VervalDatumAanpassen(id, dprVervalDatumNieuw.DisplayDate);
         
            venster.LoadKlant(null);
        }
    }
}
