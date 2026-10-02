using System.Windows;

namespace hamaikagarrenAriketa
{
    public partial class BigarrenLeihoa : Window
    {
        public BigarrenLeihoa()
        {
            InitializeComponent();

            lblIzena.Content = DatuOrokorrak.PertsonaDatuak.Izena;
            lblNAN.Content = DatuOrokorrak.PertsonaDatuak.NAN;
            lblLehenAbizena.Content = DatuOrokorrak.PertsonaDatuak.LehenAbizena;
            lblBigarrenAbizena.Content = DatuOrokorrak.PertsonaDatuak.BigarrenAbizena;
        }

        private void btnIrten_Click(object sender, RoutedEventArgs e)
        {
            MainWindow leihoa = new MainWindow();

            leihoa.Show();

            this.Close();
        }
    }
}