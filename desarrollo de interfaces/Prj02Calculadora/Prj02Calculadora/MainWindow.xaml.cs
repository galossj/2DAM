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

namespace Prj02Calculadora
{
    public partial class MainWindow : Window
    {
        double numero1 = 0;
        double numero2 = 0;
        string operacion = "";
        bool nuevoNumero = false;

        public MainWindow()
        {
            InitializeComponent();

            // Botones numéricos
            Btt_0.Click += Numero_Click;
            Btt_1.Click += Numero_Click;
            Btt_2.Click += Numero_Click;
            Btt_3.Click += Numero_Click;
            Btt_4.Click += Numero_Click;
            Btt_5.Click += Numero_Click;
            Btt_6.Click += Numero_Click;
            Btt_7.Click += Numero_Click;
            Btt_8.Click += Numero_Click;
            Btt_9.Click += Numero_Click;

            // Botones de operaciones
            Btt_Suma.Click += Operacion_Click;
            Btt_Resta.Click += Operacion_Click;
            Btt_Mult.Click += Operacion_Click;
            Btt_Div.Click += Operacion_Click;

            // Botones especiales
            Btt_Igual.Click += Btt_Igual_Click;
            Btt_Delete.Click += Btt_Delete_Click;
            Btt_Coma.Click += Btt_Coma_Click;
        }


        // Maneja el evento de clic en los botones numéricos (0-9)
        private void Numero_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            if (nuevoNumero || txtResult.Text == "0")
            {
                txtResult.Text = boton.Content.ToString();
                nuevoNumero = false;
            }
            else
            {
                txtResult.Text += boton.Content.ToString();
            }
        }


        // Maneja el evento de clic en los botones de operación (+, -, X, ÷)
        private void Operacion_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;

            // Si ya hay una operación pendiente y no se ha ingresado un nuevo número,
            // realiza el cálculo
            if (operacion != "" && !nuevoNumero)
            {
                numero2 = double.Parse(
                    txtResult.Text.Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture
                );

                numero1 = Calcular(numero1, numero2, operacion);

                txtResult.Text = numero1.ToString().Replace('.', ',');
            }

            // Si no hay una operación pendiente, almacena el primer número ingresado
            else if (operacion == "")
            {
                numero1 = double.Parse(
                    txtResult.Text.Replace(',', '.'),
                    System.Globalization.CultureInfo.InvariantCulture
                );
            }


            // Guardamos la operación pulsada
            operacion = boton.Content.ToString();


            // Mostramos la operación en la parte superior
            // Por ejemplo: 25 +
            txtOperation.Text = numero1.ToString().Replace('.', ',')
                                  + " "
                                  + operacion;


            // El siguiente número que se escriba será un número nuevo
            nuevoNumero = true;
        }


        // Maneja el evento de clic en el botón "=" para realizar el cálculo final
        private void Btt_Igual_Click(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                return;
            }

            numero2 = double.Parse(
                txtResult.Text.Replace(',', '.'),
                System.Globalization.CultureInfo.InvariantCulture
            );

            numero1 = Calcular(numero1, numero2, operacion);

            txtResult.Text = numero1.ToString().Replace('.', ',');

            // Limpiamos la operación mostrada
            txtOperation.Text = "";

            operacion = "";
            nuevoNumero = true;
        }


        // Realiza el cálculo según la operación especificada
        private double Calcular(double n1, double n2, string op)
        {
            if (op == "+")
            {
                return n1 + n2;
            }
            else if (op == "-")
            {
                return n1 - n2;
            }
            else if (op == "X")
            {
                return n1 * n2;
            }
            else if (op == "÷")
            {
                if (n2 == 0)
                {
                    txtResult.Text = "Error";
                    return 0;
                }

                return n1 / n2;
            }

            return n2;
        }


        // Maneja el evento de clic en el botón "C" para borrar la calculadora
        private void Btt_Delete_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";

            // También limpiamos la operación mostrada
            txtOperation.Text = "";

            numero1 = 0;
            numero2 = 0;
            operacion = "";
            nuevoNumero = false;
        }


        // Maneja el evento de clic en el botón "," para agregar un punto decimal
        private void Btt_Coma_Click(object sender, RoutedEventArgs e)
        {
            if (nuevoNumero)
            {
                txtResult.Text = "0,";
                nuevoNumero = false;
            }
            else if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
        }
    }
}
