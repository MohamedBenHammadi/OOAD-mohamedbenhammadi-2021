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

namespace OXO
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
        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            
            i++;
            if (i % 2 == 0)
            {
                button.Content = "o";
            }
            else
            {
                button.Content = "x";
            }
            button.IsEnabled = false;

            //colum
            if (BTN1.Content == BTN4.Content && BTN1.Content == BTN7.Content)
            {
                if (BTN1.Content.ToString() == "x" && BTN4.Content.ToString() == "x" && BTN7.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";

                }
                if (BTN1.Content.ToString() == "o" && BTN4.Content.ToString() == "o" && BTN7.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";

                }
            }
            if (BTN2.Content == BTN5.Content && BTN2.Content == BTN8.Content)
            {
                if (BTN2.Content.ToString() == "x" && BTN5.Content.ToString() == "x" && BTN8.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";

                }
                if (BTN2.Content.ToString() == "o" && BTN5.Content.ToString() == "o" && BTN8.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";

                }
            }
            if (BTN3.Content == BTN6.Content && BTN3.Content == BTN9.Content)
            {
                if (BTN3.Content.ToString() == "x" && BTN6.Content.ToString() == "x" && BTN9.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";

                }
                if (BTN3.Content.ToString() == "o" && BTN6.Content.ToString() == "o" && BTN9.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";

                }
            }

            //rows
            if (BTN1.Content == BTN2.Content && BTN1.Content == BTN3.Content)
            {
                if (BTN1.Content.ToString() == "x" && BTN2.Content.ToString() == "x" &&  BTN3.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";
                  
                }
                if (BTN1.Content.ToString() == "o" && BTN2.Content.ToString() == "o" && BTN3.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";
                   
                }
            }
            if (BTN4.Content == BTN5.Content && BTN4.Content == BTN6.Content)
            {
                if (BTN4.Content.ToString() == "x" && BTN5.Content.ToString() == "x" && BTN6.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";
                    
                }
                if (BTN4.Content.ToString() == "o" && BTN5.Content.ToString() == "o" && BTN6.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";
                
                }
            }
            if (BTN7.Content == BTN8.Content && BTN7.Content == BTN9.Content)
            {
                if (BTN7.Content.ToString() == "x" && BTN8.Content.ToString() == "x" && BTN9.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";
                   
                }
                if (BTN7.Content.ToString() == "o" && BTN8.Content.ToString() == "o" && BTN9.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";
              
                }
            }

            

            //DIAGONAL
            if (BTN1.Content == BTN5.Content && BTN1.Content == BTN9.Content)
            {
                if (BTN1.Content.ToString() == "x" && BTN5.Content.ToString() == "x" && BTN9.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";
                   
                }
                if (BTN1.Content.ToString() == "o" && BTN5.Content.ToString() == "o" && BTN9.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";
            
                }
            }
            if (BTN3.Content == BTN5.Content && BTN3.Content == BTN7.Content)
            {
                if (BTN3.Content.ToString() == "x" && BTN5.Content.ToString() == "x" && BTN7.Content.ToString() == "x")
                {
                    lblWinnaar.Content = "Speler 1 heeft gewonnen";
             
                }
                if (BTN3.Content.ToString() == "o" && BTN5.Content.ToString() == "o" && BTN7.Content.ToString() == "o")
                {
                    lblWinnaar.Content = "Speler 2 heeft gewonnen";
                
                }
            }
        }
    }

       
    }

