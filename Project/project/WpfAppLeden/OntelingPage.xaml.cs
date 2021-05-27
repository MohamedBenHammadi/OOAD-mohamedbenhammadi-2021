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
    /// Interaction logic for OntelingPage.xaml
    /// </summary>
    public partial class OntelingPage : Page
    {
        MainWindow venster;
        int klant;
        public OntelingPage( MainWindow ontl, int id)
        {
            this.venster = ontl;
            this.klant = id;
            InitializeComponent();
            LijsOntelingen();
        }

        public void LijsOntelingen()
        {
            //lstOntelingen.Items.Clear();
            List<Ontelening> ontlening = Ontelening.AllOnteleningen();
            foreach (Ontelening ontleningen in ontlening)
            {
                ListBoxItem lisbox = new ListBoxItem();
                lisbox.Tag = ontleningen.Id;
                lisbox.Content = ontleningen.ToString();
                lstOntelingen.Items.Add(lisbox);
            }
        }

        private void btnTerugbrengen_Click(object sender, RoutedEventArgs e)
        {

            ListBoxItem listbox = (ListBoxItem)lstOntelingen.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MessageBoxResult result = MessageBox.Show($"Opgepast u zal de uw boek ontlenen?", "ontlenen?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;

            Ontelening ontlening = Ontelening.OntelingID(id);
            ontlening.OntleningTerug();
            lstOntelingen.Items.Clear();
            LijsOntelingen();
              
        }

        
    }
}
