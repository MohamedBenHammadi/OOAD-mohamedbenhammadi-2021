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

namespace WpfAlcohol
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

   
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double aantalGlazen;

            aantalGlazen = sldbier.Value + sldwhiskey.Value + sldwijn.Value;

            if (sldbier.Value == 1 )
            {
                lblbier.Content = sldbier.Value + " glas";
            }
            else
            {
                lblbier.Content = sldbier.Value + " glazen";
            }
            Kleurrectangle(aantalGlazen);
        }

        private void sldwijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double aantalGlazen;

            aantalGlazen = sldbier.Value + sldwhiskey.Value + sldwijn.Value;

            if (sldwijn.Value == 1)
            {
                lblwijn.Content = sldwijn.Value + " glas";
            }
            else
            {
                lblwijn.Content = sldwijn.Value + " glazen";
            }
            Kleurrectangle(aantalGlazen);
        }

        private void sldwhiskey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double aantalGlazen;

            aantalGlazen = sldbier.Value + sldwhiskey.Value + sldwijn.Value;

            if (sldwhiskey.Value == 1)
            {
                lblwhiskey.Content = sldwhiskey.Value + " glas";
            }
            else
            {
                lblwhiskey.Content = sldwhiskey.Value + " glazen";
            }
            Kleurrectangle(aantalGlazen);
        }
    

        private void Kleurrectangle(double glazen)
        {
            int breedte = 20;
            int hoogte = 20;

            double R = 17 * glazen;
            double G = 255 - (17 * glazen);

            rectangleOef.Fill = new SolidColorBrush(Color.FromRgb( Convert.ToByte(R), Convert.ToByte(G), 0));
            rectangleOef.Width = breedte * glazen;
            rectangleOef.Height = hoogte;
           

        }
    
    
    
    
    
    
    
    
    }
}
