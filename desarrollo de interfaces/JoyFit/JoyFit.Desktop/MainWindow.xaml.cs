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
using JoyFit.Desktop.Pages;

namespace JoyFit.Desktop
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
        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InicioPage());
        }
        private void Clientes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientesPage());
        }

        private void Suscripciones_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SuscripcionesPage());
        }

        private void Rutinas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RutinasPage());
        }

        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TiendaPage());
        }
    }
}