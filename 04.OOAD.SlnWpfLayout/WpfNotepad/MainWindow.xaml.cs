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

namespace WpfNotepad
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

        private void txtText_TextChanged(object sender, TextChangedEventArgs e)
        {
            int tekens = Convert.ToInt32(txtText.Text.Length);
            stbAantalTekens.Content = $"#chars: {tekens}" ;
        }

       

        private void about_click(object sender, RoutedEventArgs e)
        {
            AboutWindow venster = new AboutWindow();
            venster.Show();
        }
    }
}
