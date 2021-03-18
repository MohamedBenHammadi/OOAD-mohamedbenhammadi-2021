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

namespace WpfCarConfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            imgAudio.Opacity = chkdBose.IsChecked.Value ? 1 : 0.3;
            imgMatjes.Opacity = chkdMatjes.IsChecked.Value ? 1 : 0.3;
            imgVelgen.Opacity = chkdVelgen.IsChecked.Value ? 1 : 0.3;


            
            BerekenPrijs();
        }

      
        private void radio_Checked(object sender, RoutedEventArgs e)
        {

            //keuze voor V8
            if (rdbBlauw.IsChecked == true && cmbV8.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model1_blauw.jpg", UriKind.Relative));

            }
            else if (rdbRood.IsChecked == true && cmbV8.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model1_rood.jpg", UriKind.Relative));


            }
            else if (rdbGroen.IsChecked == true && cmbV8.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model1_groen.jpg", UriKind.Relative));


            }

            //keuze voor convertible
            if (rdbBlauw.IsChecked == true && cmbConvertible.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model2_blauw.jpg", UriKind.Relative));

            }
            else if (rdbRood.IsChecked == true && cmbConvertible.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model2_rood.jpg", UriKind.Relative));

            }
            else if (rdbGroen.IsChecked == true && cmbConvertible.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model2_groen.jpg", UriKind.Relative));

            }

            //keuze voor Mulsanne 

            if (rdbBlauw.IsChecked == true && cmbMuslsanne.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model3_blauw.jpg", UriKind.Relative));

            }
            else if (rdbRood.IsChecked == true && cmbMuslsanne.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model3_rood.jpg", UriKind.Relative));

            }
            else if (rdbGroen.IsChecked == true && cmbMuslsanne.IsSelected == true)
            {
                imgAuto.Source = new BitmapImage(new Uri("img/model3_groen.jpg", UriKind.Relative));

            }

            BerekenPrijs();

        }

        private void BerekenPrijs()
        {
            int totaal = 0;

            totaal += cmbAuto.SelectedIndex == 0 ? 85000 : 0;
            totaal += cmbAuto.SelectedIndex == 1 ? 72000 : 0;
            totaal += cmbAuto.SelectedIndex == 2 ? 65300 : 0;

            totaal += rdbGroen.IsChecked == true ? 250 : 0;
            totaal += rdbRood.IsChecked == true ? 700 : 0;


            totaal += chkdBose.IsChecked == true ? 1250 : 0;
            totaal += chkdMatjes.IsChecked == true ? 450 : 0;
            totaal += chkdVelgen.IsChecked== true ? 300 : 0;


          
            lblTotaal.Content = "€" + Convert.ToString(totaal) ;

        }

        
    }
}
