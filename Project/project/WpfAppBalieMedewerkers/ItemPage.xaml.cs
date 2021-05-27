using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Interaction logic for ItemPage.xaml
    /// </summary>
    public partial class ItemPage : Page
    {
        static string connString = ConfigurationManager.AppSettings["connString"];
        public ItemPage()
        {
            InitializeComponent();
            LoadItem(null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblActie.Content = "Toevoegen";
            MainToevoegen.Content = new ItemToevoegen();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblActie.Content = "Aanpassen";
            int id = Convert.ToInt32(lblid.Content);
            MainToevoegen.Content = new ItemAanpassen(this, id);


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lblActie.Content = "Zoeken";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lblActie.Content = "Verwijderen";

            int id = Convert.ToInt32(lblid.Content);


            Button btn = (Button)sender;


            MessageBoxResult result = MessageBox.Show($"U zal het boek {lblTitel.Content}  verwijderen?", "verwijderen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result != MessageBoxResult.Yes) return;

            Item item = Item.GetElementId(id);
            item.VerwijderItem();
            LoadItem(null);


        }


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
                cover.Width = 70;
                cover.Height = 90;
                cover.Source = items.Coverfoto;

                Label lblInvoer = new Label();
                lblInvoer.Content = items.ToString();
                lblInvoer.Width = 160;
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
            lblLeeftijdVan.Content = $"{item.LeeftijdVan}";
            lblLeeftijdTot.Content = $"{item.LeeftijdTot}";
            lblTaal.Content = item.Taal;
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            Zoeken venster = new Zoeken();
            venster.Show();
        }
    }
}
