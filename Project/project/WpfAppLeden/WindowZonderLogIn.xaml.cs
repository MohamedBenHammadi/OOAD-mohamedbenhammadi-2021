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

namespace WpfAppLeden
{
    /// <summary>
    /// Interaction logic for WindowZonderLogIn.xaml
    /// </summary>
    public partial class WindowZonderLogIn : Window
    {
        public WindowZonderLogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new PageZoek();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            MainToevoegen.Content = new CheckStock();
        }
    }
}
