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
using System.Windows.Threading;

namespace Wpfellipsen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += GenereerCirkel;

        }

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {

            lblMaxradius.Content = sldMaxradius.Value;
            lblMinradius.Content = sldMinimumRadius.Value;
            lblaantalcirkels.Content = Aantalcirkelssld.Value;

            timer.Start();


        }
        private void GenereerCirkel(object sender, EventArgs e)
        {

            int tour = 0;
            if (sldMinimumRadius.Value > sldMaxradius.Value)
            {
                lblfoutmelding.Content = "De minimum straal mag niet groter zijn dan de maximum straal";


            }
            else
            {
                for (int i = 0; i < Aantalcirkelssld.Value; i++)
                {
                    Ellipse newEllipse = new Ellipse();
                    newEllipse.Width = sldMaxradius.Value;
                    newEllipse.Height = sldMinimumRadius.Value;
                    newEllipse.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(random.Next(1, 256)), Convert.ToByte(random.Next(1, 256)), Convert.ToByte(random.Next(1, 256))));
                    double xPos = random.Next(0, Convert.ToInt32(canvas1.Width));
                    double yPos = random.Next(0, Convert.ToInt32( canvas1.Height));
                    newEllipse.SetValue(Canvas.LeftProperty, xPos);
                    newEllipse.SetValue(Canvas.TopProperty, yPos);
                    canvas1.Children.Add(newEllipse);
                    tour++;
                }

                if(tour > Aantalcirkelssld.Value)
                {
                    timer.Stop();
                }
                lblfoutmelding.Content = " ";
            }



        }



    }
}
