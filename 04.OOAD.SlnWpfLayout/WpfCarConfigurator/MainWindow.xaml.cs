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
            if (chkdVelgen.IsChecked == true)
            {
                imgVelgen.Opacity = 1;

            }
            else
            {
                imgVelgen.Opacity = 0.3;
            }

            if (chkdBose.IsChecked == true)
            {
                imgAudio.Opacity = 1;

            }
            else
            {
                imgAudio.Opacity = 0.3;
            }
            if (chkdMatjes.IsChecked == true)
            {
                imgMatjes.Opacity = 1;

            }
            else
            {
                imgMatjes.Opacity = 0.3;
            }
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

            if (cmbV8.IsSelected == true)
            {
                totaal += 85000;
            }
            else if (cmbConvertible.IsSelected == true)
            {
                totaal += 72000;
            }
            else if (cmbMuslsanne.IsSelected == true)
            {
                totaal += 65300;
            }

            if (rdbRood.IsChecked == true)
            {
                totaal += 700;
            }
            else if (rdbGroen.IsChecked == true)
            {
                totaal += 250;
            }

            if (chkdVelgen.IsChecked == true)
            {
                totaal += 300;
            }

            else if (chkdBose.IsChecked == true)
            {
                totaal += 1250;
            }

            else if (chkdMatjes.IsChecked == true)
            {
                totaal += 450;
            }
            lblTotaal.Content = "€" + Convert.ToString(totaal) ;

        }
    }
}
