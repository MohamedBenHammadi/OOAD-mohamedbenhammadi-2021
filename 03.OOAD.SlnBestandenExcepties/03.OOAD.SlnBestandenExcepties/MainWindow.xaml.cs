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
using System.IO;

namespace _03.OOAD.SlnBestandenExcepties
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {

         

            try
            {
                // define working folder
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // 4: read using StreamReader and ReadLine()
                List<string> lines = new List<string>();
                string filePath = System.IO.Path.Combine(folderPath, txbFileIn.Text);
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                // WRITING FILES

                // 1: write using StreamWriter and WriteLine()
                string filePath2 = System.IO.Path.Combine(folderPath, txbFileOut.Text);
                using (StreamWriter writer = File.CreateText(filePath2))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                lblBericht.Content = "Bestand is overgezet";
            }
            catch (FileNotFoundException )
            {
                MessageBox.Show(
                $"{txbFileIn.Text} kon niet gevonden worden", // boodschap
                "Oeps!", // titel
                MessageBoxButton.OK, // buttons
                MessageBoxImage.Error
                ); // error icoon
            }


        }
    }
}
