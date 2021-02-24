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

namespace WpfChat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string [] Vuilewoorden = { "homo", "hoer", "fuck", "nique"  };

            chatBlock.Text.ToCharArray();  

            if (chatBlock.Text == "")
            {
                chatBlock.Text +=  txtNaam.Text + " says" + Environment.NewLine + txtBericht.Text.Replace("fuck", "***") + Environment.NewLine;
            }
            else
            {
                chatBlock.Text += Environment.NewLine + txtNaam.Text + " says" + Environment.NewLine + txtBericht.Text.Replace("fuck", "***") + Environment.NewLine;
            }

            txtBericht.Clear();
            txtNaam.Clear();
         
        }
    }
}
