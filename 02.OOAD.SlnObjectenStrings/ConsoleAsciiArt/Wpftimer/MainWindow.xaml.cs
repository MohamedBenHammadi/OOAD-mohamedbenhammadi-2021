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

namespace Wpftimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int seconden = 0;
        int minuuten = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Tijd;
        }

        private void Tijd(object sender, EventArgs e)
        {
           if(seconden == 59)
            {
                seconden = 0;
                minuuten++;
            }
           
            seconden++;
            lblTijd.Content = minuuten + " : " + seconden;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnReset.IsEnabled = true;
            btnStop.IsEnabled = true;
            timer.Start();


        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Tijd;

        }
    }
}
