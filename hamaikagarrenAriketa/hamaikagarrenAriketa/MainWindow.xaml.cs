using System.Windows;

namespace hamaikagarrenAriketa
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOnartu_Click(object sender, RoutedEventArgs e)
        {
            DatuOrokorrak.PertsonaDatuak = new Pertsona
            {
                Izena = txtIzena.Text,
                LehenAbizena = txtLehenAbizena.Text,
                BigarrenAbizena = txtBigarrenAbizena.Text,
                NAN = txtNAN.Text
            };

            MessageBox.Show("Datuak gorde dira.");
        }

        private void btnKargatu_Click(object sender, RoutedEventArgs e)
        {
            BigarrenLeihoa leihoa = new BigarrenLeihoa();

            leihoa.Show();

            this.Hide();
        }

        private void btnIrten_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}