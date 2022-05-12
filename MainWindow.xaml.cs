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

namespace taschenrechner_original
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public string ausgabe;
        public string zahl1;
        public string zahl2;
        public bool konvertieren = true;
        public bool fertig = false;
        public bool naechstezahl = false;
        public string operatorauswahl;
        public int ausgabe1;
        public int ausgabe2;

        public void Zusammenzaehlen(string neu)
        {
            if (neu == "geteilt")
            {
                neu = string.Empty;
                operatorauswahl = "g";
                naechstezahl = true ;
            }
           
            if (neu == "mal")
            {
                neu = String.Empty;
                operatorauswahl = "mal";
                naechstezahl = true;
            }
            if (neu == "plus")
            {
                neu = String.Empty;
                operatorauswahl = "p";
                naechstezahl = true;
            }
            if (neu == "minus")
            {
                neu = String.Empty;
                operatorauswahl = "m";
                naechstezahl = true;
            }
            if (neu == "gleich")
            {
                neu = String.Empty;
                fertig = true;
                


            }
            ausgabe = ausgabe += neu;
            if (naechstezahl)
            {
               ausgabe1 = Convert.ToInt32(ausgabe);
               ausgabe = "";



            }
            

            ausgabe_lbl.Content = ausgabe;

            neu = string.Empty;

            


            if (fertig)
            {
                ausgabe2 = Convert.ToInt32(ausgabe);
                ausgabe_lbl.Content = ausgabe1 + "   " + ausgabe2 + "   ";
                
                if (operatorauswahl == "p")
                {
                    
                    
                }
                if (operatorauswahl == "m")
                {

                }
                if (operatorauswahl == "mal")
                {

                }
                if (operatorauswahl == "g")
                {

                }
            }


           



        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string neu = "1";
            Zusammenzaehlen( neu );
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string neu = "2";
            Zusammenzaehlen(neu);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string neu = "3";
            Zusammenzaehlen(neu);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string neu = "4";
            Zusammenzaehlen(neu);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string neu = "5";
            Zusammenzaehlen(neu);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            string neu = "6";
            Zusammenzaehlen(neu);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            string neu = "7";
            Zusammenzaehlen(neu);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            string neu = "8";
            Zusammenzaehlen(neu);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            string neu = "9";
            Zusammenzaehlen(neu);
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            string neu = "0";
            Zusammenzaehlen(neu);
        }

        private void buttonmal_Click(object sender, RoutedEventArgs e)
        {
            string neu = "mal";
            Zusammenzaehlen(neu);
        }

        private void buttongeteilt_Click(object sender, RoutedEventArgs e)
        {
            string neu = "geteilt";
            Zusammenzaehlen(neu);
        }

        private void buttonplus_Click(object sender, RoutedEventArgs e)
        {
            string neu = "plus";
            Zusammenzaehlen(neu);
        }

        private void buttonminus_Click(object sender, RoutedEventArgs e)
        {
            string neu = "minus";
            Zusammenzaehlen(neu);
        }

        private void Button_Click_gleich(object sender, RoutedEventArgs e)
        {
            string neu = "gleich";
            Zusammenzaehlen(neu);
        }
    }
}
