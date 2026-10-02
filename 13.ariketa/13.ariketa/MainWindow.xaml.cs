using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace _13.ariketa
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                Clipboard.SetText(txtEditor.SelectedText);
                txtEditor.SelectedText = string.Empty;
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (txtEditor.SelectionLength > 0)
            {
                Clipboard.SetText(txtEditor.SelectedText);
            }
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtEditor.SelectedText = Clipboard.GetText();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.SelectedText = string.Empty;
        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem && menuItem.Tag is string fontName)
            {
                txtEditor.FontFamily = new FontFamily(fontName);
            }
        }

    }
}