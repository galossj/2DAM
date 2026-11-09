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
using System.Collections.Generic;
using JoyFit.Desktop.Models;
using System.Linq;

namespace JoyFit.Desktop.Pages
{
    /// <summary>
    /// Lógica de interacción para ClientesPage.xaml
    /// </summary>
    public partial class ClientesPage : Page
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();
        public ClientesPage()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void AñadirCliente_Click(object sender, RoutedEventArgs e)
        {
            NuevoClienteWindow window = new NuevoClienteWindow();
            window.ShowDialog();

            CargarClientes();
        }

        private void CargarClientes()
        {
            DataGridClientes.ItemsSource = null;
            DataGridClientes.ItemsSource = ListaClientes;
        }

        private void TxtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string Busqueda = TxtBuscar.Text.ToLower();

            var clientesFiltrados = ListaClientes.Where(c =>
                (c.Nombre ?? "").ToLower().Contains(Busqueda) ||
                (c.Apellidos ?? "").ToLower().Contains(Busqueda) ||
                (c.DNI ?? "").ToLower().Contains(Busqueda)
                ).ToList();

            DataGridClientes.ItemsSource = clientesFiltrados;
        }

        private void EditarCliente_Click(object sender, EventArgs e)
        {
            if(DataGridClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente primero.");
                return;
            }

            Cliente clienteSeleccionado = (Cliente)DataGridClientes.SelectedItem;

            NuevoClienteWindow window = new NuevoClienteWindow(clienteSeleccionado);
            window.ShowDialog();

            DataGridClientes.Items.Refresh();
        }

        private void EliminarCliente_Click(Object sender, EventArgs e) 
        {

            if(DataGridClientes.SelectedItem == null)
            {
                MessageBox.Show("Para eliminar un cliente debe seleccionarlo.");
                return;
            }

            Cliente clienteSeleccionado = (Cliente)DataGridClientes.SelectedItem;

            MessageBoxResult resultado = MessageBox.Show(
                "¿Estás seguro de que quiere eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (resultado == MessageBoxResult.Yes)
            {

                ListaClientes.Remove(clienteSeleccionado);
                CargarClientes();

                MessageBox.Show("Cliente eliminado correctamente");
            }
        }
    }
}
