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

            if (sldbier.Value == 1 )
            {
                lblbier.Content = sldbier.Value + " glas";
            }
            else
            {
                lblbier.Content = sldbier.Value + " glazen";
            }
            Kleurrectangle();
        }

        private void sldwijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldwijn.Value == 1)
            {
                lblwijn.Content = sldwijn.Value + " glas";
            }
            else
            {
                lblwijn.Content = sldwijn.Value + " glazen";
            }
            Kleurrectangle();
        }

        private void sldwhiskey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sldwhiskey.Value == 1)
            {
                lblwhiskey.Content = sldwhiskey.Value + " glas";
            }
            else
            {
                lblwhiskey.Content = sldwhiskey.Value + " glazen";
            }
            Kleurrectangle();
        }
    

        private void Kleurrectangle()
        {
            rectangleOef.Width = (sldbier.Value * 10) + (sldwijn.Value * 10) + (sldwhiskey.Value * 10);
            rectangleOef.Fill = new SolidColorBrush(Color.FromRgb(rectangleOef.Width, 0, 0));
        }
    
    
    
    
    
    
    
    
    }
}
