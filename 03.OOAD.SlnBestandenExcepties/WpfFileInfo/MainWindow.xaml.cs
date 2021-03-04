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
using Microsoft.Win32;
using System.IO;

namespace WpfFileInfo
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "Tekstbestanden|.TXT;.TEXT";
          
            bool? dialogResult = dialog.ShowDialog();

            if (dialogResult == true)
            {
                string chosenFileName;
                chosenFileName = dialog.FileName; // user accepted
                char[] leestekens = new char[] { '.', ',', ' ' };
                int aantalWoorden;
                int textLengte = 0;
                int aantalLeestekens = chosenFileName.Count(leesteken => leestekens.Contains(leesteken));
                leestekens = chosenFileName.ToCharArray();

                for (int i = 0; i < chosenFileName.Length; i++)
                {
                    textLengte++;
                }
                aantalWoorden = textLengte - aantalLeestekens;

                lblInfo.Content = "De text bevat " + Convert.ToString(aantalWoorden) + "woorden" + Environment.NewLine;
                FileInfo fi = new FileInfo(chosenFileName);
                lblInfo.Content += $"bestandsnaam: {fi.Name}{Environment.NewLine}";
                lblInfo.Content += $"extensie: {fi.Extension}{Environment.NewLine}";
                lblInfo.Content += $"gemaakt op: {fi.CreationTime.ToString()}{Environment.NewLine}";
                lblInfo.Content += $"mapnaam: {fi.Directory.Name}{Environment.NewLine}";

            }
            else
            {
                // user cancelled or escaped dialog window
                lblInfo.Content = "geen bestand gekozen";
            }


         

        }


    }
}
