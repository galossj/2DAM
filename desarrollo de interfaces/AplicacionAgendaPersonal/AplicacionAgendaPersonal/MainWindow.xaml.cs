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

namespace AgendaPersonal
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

        private void OnClickMenu(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Seccion Menu";
        }
        private void OnClickContactos(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Seccion Contactos";
        }
        private void OnClickCitas(object sender, RoutedEventArgs e)
        {
            txtSeccion.Text = "Seccion Citas";
        }
    }
}