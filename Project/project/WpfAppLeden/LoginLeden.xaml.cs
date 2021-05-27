using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;
using EmpClassLibrary;

namespace WpfAppLeden
{
    /// <summary>
    /// Interaction logic for LoginLeden.xaml
    /// </summary>
    public partial class LoginLeden : Window
    {
      
        public LoginLeden()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            int lidnummer;

            lidnummer = Convert.ToInt32(txtBarcode.Text);

            if (Leden.LoginLid(lidnummer))
            {
                MainWindow venster = new MainWindow(this, lidnummer);
                this.Close();
                venster.Show();
            }
            else
            {
              
                lblfoutmelding.Content = "lidnummer is niet correct";
            }
        }

        private void BtnZonderLogIN_Click(object sender, RoutedEventArgs e)
        {
            WindowZonderLogIn venster = new WindowZonderLogIn();
            this.Close();
            venster.Show();
        }
    }
}
