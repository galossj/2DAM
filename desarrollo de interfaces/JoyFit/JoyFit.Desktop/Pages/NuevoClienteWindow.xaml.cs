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
using System.Windows.Shapes;
using JoyFit.Desktop.Models;
using JoyFit.Desktop.Pages;

namespace JoyFit.Desktop.Pages
{
    /// <summary>
    /// Lógica de interacción para NuevoClienteWindow.xaml
    /// </summary>
    public partial class NuevoClienteWindow : Window
    {
        public NuevoClienteWindow()
        {
            InitializeComponent();
        }

        public NuevoClienteWindow(Cliente cliente)
        {
            InitializeComponent();

            clienteEditar = cliente;

            TxtNombre.Text = cliente.Nombre;
            TxtApellidos.Text = cliente.Apellidos;
            TxtDNI.Text = cliente.DNI;
            TxtTelefono.Text = cliente.Telefono;
            TxtCorreo.Text = cliente.Correo;
        }

        private void GuardarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (clienteEditar == null)
            {

                Cliente cliente = new Cliente();

                cliente.Nombre = TxtNombre.Text;
                cliente.Apellidos = TxtApellidos.Text;
                cliente.DNI = TxtDNI.Text;
                cliente.Telefono = TxtTelefono.Text;
                cliente.Correo = TxtCorreo.Text;

                ClientesPage.ListaClientes.Add(cliente);

            }
            else
            {

                clienteEditar.Nombre = TxtNombre.Text;
                clienteEditar.Apellidos = TxtApellidos.Text;
                clienteEditar.DNI = TxtDNI.Text;
                clienteEditar.Telefono = TxtTelefono.Text;
                clienteEditar.Correo = TxtCorreo.Text;

            }

            MessageBox.Show("Cliente guardado correctamente");

            this.Close();
        }

        private Cliente clienteEditar = null;
    }
}
