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
    /// Interaction logic for OntelingenPage.xaml
    /// </summary>
    public partial class OntelingenPage : Page
    {
        public OntelingenPage()
        {
            InitializeComponent();
            Ontleningen();
        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {
         
            int id = Convert.ToInt32(txtInputSerach.Text);
            List<Ontelening> ontleningen = Ontelening.OntelingIdAll(id);

            foreach (Ontelening ontleing in ontleningen)
            {
                ListBoxItem lisbox = new ListBoxItem();
                lisbox.Content = ontleing.ToString();
                lisbox.Tag = ontleing.Id;
                lstOntelingen.Items.Add(lisbox);
            }
        }

        public void Ontleningen()
        {
            lstOntelingen.Items.Clear();
            List<Ontelening> ontleningen = Ontelening.AllOnteleningen();
            foreach (Ontelening ontleing in ontleningen)
            {
                ListBoxItem lisbox = new ListBoxItem();

                lisbox.Content = ontleing.ToString();
                lisbox.Tag = ontleing.Id;
                lstOntelingen.Items.Add(lisbox);
            }
        }

        private void btnTerugbrengen_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem listbox = (ListBoxItem)lstOntelingen.SelectedItem;
            int id = Convert.ToInt32(listbox.Tag);

            MessageBoxResult result = MessageBox.Show($"Ben je zeker dat je het boek wilt terugbrengen?", "Terugbrengen?", MessageBoxButton.YesNo);
            if (result != MessageBoxResult.Yes) return;

            Ontelening ontleing = Ontelening.OntelingID(id);
            ontleing.OntleningTerug();
            
        }
    }
}
