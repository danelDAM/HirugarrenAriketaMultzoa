using System.Windows;
using System.Windows.Controls;

namespace ariketa10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == checkImagen1)
            {
                irudi4.Visibility = Visibility.Visible;
            }
            else if (sender == checkImagen2)
            {
                irudi5.Visibility = Visibility.Visible;
            }
            else if (sender == checkImagen3)
            {
                irudi6.Visibility = Visibility.Visible;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (sender == checkImagen1)
            {
                irudi4.Visibility = Visibility.Hidden;
            }
            else if (sender == checkImagen2)
            {
                irudi5.Visibility = Visibility.Hidden;
            }
            else if (sender == checkImagen3)
            {
                irudi6.Visibility = Visibility.Hidden;
            }
        }

        private void comboImagen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            irudi1.Visibility = Visibility.Hidden;
            irudi2.Visibility = Visibility.Hidden;
            irudi3.Visibility = Visibility.Hidden;

            if (comboImagen.SelectedIndex == 0)
            {
                irudi1.Visibility = Visibility.Visible;
            }
            else if (comboImagen.SelectedIndex == 1)
            {
                irudi2.Visibility = Visibility.Visible;
            }
            else if (comboImagen.SelectedIndex == 2)
            {
                irudi3.Visibility = Visibility.Visible;
            }
        }

        private void irten(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}