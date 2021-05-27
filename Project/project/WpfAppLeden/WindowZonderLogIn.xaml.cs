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
    /// Interaction logic for WindowZonderLogIn.xaml
    /// </summary>
    public partial class WindowZonderLogIn : Window
    {
        static string connString = ConfigurationManager.AppSettings["connString"];
        public WindowZonderLogIn()
        {
            InitializeComponent();
            LoadItem(null);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new PageZoek();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new CheckStock();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LoginLeden venster = new LoginLeden();
            this.Close();
            venster.Show();
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
            txbBescharijving.Text = item.Beschrijving;
            lblLeeftijdVan.Content = $"{item.LeeftijdVan}";
            lblLeeftijdTot.Content = $"{item.LeeftijdTot}";
            lblTaal.Content = item.Taal;
        }
    }
}
