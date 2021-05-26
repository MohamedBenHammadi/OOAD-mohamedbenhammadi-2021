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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {
            InitializeComponent();
            LoadItem(null);
        }

        LoginLeden lidnummer = new LoginLeden();
        
        public void LoadItem(int? selectedId)
        {
            WrpLijst.Children.Clear();
            List<Item> item = Item.GetAll();
            int i = 0;
            foreach (Item items in item)
            {

                Button btn = new Button();
                btn.Name = $"btn{i + 1}";
                btn.Tag = items.Id;

                btn.Background = new SolidColorBrush(Colors.White);
                btn.BorderBrush = Brushes.White;
                btn.Click += new RoutedEventHandler(ItemClick);

                StackPanel stack = new StackPanel();

                Image cover = new Image();
                cover.Width = 60;
                cover.Height = 90;
                cover.Source = items.Coverfoto;

                Label lblInvoer = new Label();
                lblInvoer.Content = items.ToString();
                lblInvoer.Width = 180;
                lblInvoer.HorizontalContentAlignment = HorizontalAlignment.Center;

                stack.Children.Add(cover);
                stack.Children.Add(lblInvoer);
                btn.Content = stack;
                WrpLijst.Children.Add(btn);

            }
        }

        private void ItemClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Tag);
            Item item = Item.GetElementId(id);

            lblid.Content = item.Id;
            lblTitel.Content = item.Titel;
            txbBescharijving.Text = item.Beschrijving;
            lblLeeftijdVan.Content = $"{item.LeeftijdVan}";
            lblLeeftijdTot.Content = $"{item.LeeftijdTot}";
            lblTaal.Content = item.Taal;
        }

        private void btnReserveren_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new ReserverenPage();
        }
        int id;
        private void btnOntlene_Click(object sender, RoutedEventArgs e)
        {
            
            MainToevoegen.Content = new OntelingPage();
            int nummer = Convert.ToInt32(lidnummer.txtBarcode.Text);
            Leden lid = Leden.GetKlanttId(nummer);
            lid.OntleenLid(id, lid.Lidnummer);
            LoadItem(null);
        }

        private void btnBoete_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
