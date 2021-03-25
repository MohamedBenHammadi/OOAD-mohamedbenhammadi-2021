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
using Microsoft.Win32;



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

        private void about_click(object sender, RoutedEventArgs e)
        {
            AboutWindow venster = new AboutWindow();
            venster.Show();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {


            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
            string chosenFileName, inhoud;
            if (dialog.ShowDialog() == true)
            {
                // user picked a file and pressed OK
                chosenFileName = dialog.FileName;
                tbHeader.Header = chosenFileName;
                mnuSave.IsEnabled = true;
                inhoud = File.ReadAllText(chosenFileName);
                txtText.Text = inhoud;

            }
            else
            {
                // user cancelled or escaped dialog window
            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (txtText.Text == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                dialog.Filter = "Tekstbestanden|*.TXT;*.TEXT";
                dialog.FileName = "savedfile.txt";

                File.WriteAllText(dialog.FileName, txtText.Text);
                mnuSave.IsEnabled = false;
            }
        }

        
        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = "Text|*.TXT;*.TEXT";
            dialog.FileName = "savedfile.txt";

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, txtText.Text);
            }
            else
            {
                // user pressed Cancel or escaped dialog window
            }
            mnuSaveAs.IsEnabled = false;
            mnuSave.IsEnabled = true;
        }

        private void txtText_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
            int tekens = Convert.ToInt32(txtText.Text.Length);
            stbAantalTekens.Content = $"#chars: {tekens}";


            if (tekens > 0)
            {

                mnuPaste.IsEnabled = true;
            }

            if (txtText.SelectedText == "")
            {
                mnuCopy.IsEnabled = true;
                mnuCut.IsEnabled = true;
                mnuOpen.IsEnabled = true;
                mnuSaveAs.IsEnabled = true;


            }
        }

       

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            if (mnuSave.IsEnabled == true || mnuSaveAs.IsEnabled == true )
            {
                if (MessageBox.Show(
                $"als je nu het programma verlaat, gaan de wijzigingen verloren", // boodschap
               "Warning!", // titel
                MessageBoxButton.YesNo, // buttons
                MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {

                }
            }
            else
            {
                Environment.Exit(0);
            } 
            
            }

        TabItem Tabitem2 = new TabItem();
       
        private void New_Click(object sender, RoutedEventArgs e)
        {
            
            tabControl.Items.Add(Tabitem2);
            Tabitem2.Header = "Untiteled";
            NewTexbox();
        }
    
        private void NewTexbox()
        {
            TextBox textbox2 = new TextBox();
            Tabitem2.Content = textbox2;
            textbox2.AcceptsReturn = true;
            textbox2.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            textbox2.TextWrapping = TextWrapping.Wrap;
            textbox2.TextChanged += new TextChangedEventHandler(txtText_SelectionChanged);
            int tekens2 = Convert.ToInt32(textbox2.Text.Length);
            stbAantalTekens.Content = $"#chars: {tekens2}";
        }

        private void mnuCut_Click(object sender, RoutedEventArgs e)
        {
            txtText.Cut();
        }

        private void mnuCopy_Click(object sender, RoutedEventArgs e)
        {
            txtText.Copy();
            mnuPaste.IsEnabled = true;
        }

        private void mnuPaste_Click(object sender, RoutedEventArgs e)
        {
            txtText.Paste();
        }
    }
    }
