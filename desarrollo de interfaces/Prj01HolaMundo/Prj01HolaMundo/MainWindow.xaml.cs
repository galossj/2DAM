using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prj01HolaMundo
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
            MessageBox.Show(
                "Hola Mundo",
                "Hola Mundo",
                MessageBoxButton.YesNoCancel,
                MessageBoxImage.Warning
                );
        }

        private void txtMensaje_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = txtMensaje.Text;

            if (str.Any(Char.IsDigit))
                {
            str = str.Remove(str.Length - 1);
            }
        }
    }
}