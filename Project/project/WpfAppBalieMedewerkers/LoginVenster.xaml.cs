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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using EmpClassLibrary;

namespace WpfAppBalieMedewerkers
{
    /// <summary>
    /// Interaction logic for LoginVenster.xaml
    /// </summary>
    public partial class LoginVenster : Window
    {

        static string connString = ConfigurationManager.AppSettings["connString"];
        public LoginVenster()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {

            string codePasje, wachtwoord;
            codePasje = txtCode.Text;
            wachtwoord = txtWachtwoord.Password;


            if (Medewerker.LoginMedewerker(codePasje, wachtwoord))
            {
                lblfoutmelding.Content = "de gebruikersnaam / paswoord is niet correct";
            }
            else
            {
                MainWindow venster = new MainWindow();
                this.Close();
                venster.Show();
           
            }

        }






    }
    
}
