using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace dietak
{
    public partial class MainWindow : Window
    {
        const double PREZIO_GOSARIA = 3.0;
        const double PREZIO_BAZKARIA = 9.0;
        const double PREZIO_AFARIA = 15.5;

        const double PREZIO_KM = 0.25;
        const double PREZIO_BIDAIA_ORDUA = 18.0;
        const double PREZIO_LAN_ORDUA = 42.0;


        public MainWindow()
        {
            InitializeComponent();
        }



        private void Kalkulatu()
        {
            double guztiraDietak = 0;
            double guztiraBidaiak = 0;
            double guztiraLana = 0;


        

            if (chkGosaria.IsChecked == true)
            {
                guztiraDietak += PREZIO_GOSARIA;
            }

            if (chkBazkaria.IsChecked == true)
            {
                guztiraDietak += PREZIO_BAZKARIA;
            }

            if (chkAfaria.IsChecked == true)
            {
                guztiraDietak += PREZIO_AFARIA;
            }



            double km;

            if (double.TryParse(txtKm.Text, out km))
            {
                if (km >= 0)
                {
                    guztiraBidaiak += km * PREZIO_KM;
                }
            }


            double bidaiaOrduak;

            if (double.TryParse(txtBidaiOrduak.Text, out bidaiaOrduak))
            {
                if (bidaiaOrduak >= 0)
                {
                    guztiraBidaiak += bidaiaOrduak * PREZIO_BIDAIA_ORDUA;
                }
            }



            double lanOrduak;

            if (double.TryParse(txtLanOrduak.Text, out lanOrduak))
            {
                if (lanOrduak >= 0)
                {
                    guztiraLana = lanOrduak * PREZIO_LAN_ORDUA;
                }
            }



            txtDietak.Text = guztiraDietak.ToString("0.00") + " €";

            txtBidaiak.Text = guztiraBidaiak.ToString("0.00") + " €";

            txtLana.Text = guztiraLana.ToString("0.00") + " €";



            double guztira = guztiraDietak + guztiraBidaiak + guztiraLana;

            txtGuztira.Text = guztira.ToString("0.00") + " €";
        }


        private void Dieta_Changed(object sender, RoutedEventArgs e)
        {
            Kalkulatu();
        }



        private void Datuak_Changed(object sender, TextChangedEventArgs e)
        {
            Kalkulatu();
        }




        private void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;

                if (Keyboard.FocusedElement is UIElement elementoConFoco)
                {
                    elementoConFoco.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
                }
            }
        }



        private void btnGarbitu_Click(object sender, RoutedEventArgs e)
        {
            chkGosaria.IsChecked = false;
            chkBazkaria.IsChecked = false;
            chkAfaria.IsChecked = false;

            txtKm.Clear();
            txtBidaiOrduak.Clear();
            txtLanOrduak.Clear();

            txtDietak.Clear();
            txtBidaiak.Clear();
            txtLana.Clear();
            txtGuztira.Clear();
        }



        private void btnIrten_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}