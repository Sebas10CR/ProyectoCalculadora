using System;
using System.Windows.Forms;
using static proyecto_calculadora.Operaciones;

namespace proyecto_calculadora
{
    public partial class Form1 : Form
    {
        private Operacion operacionActual;
        private double valorAnterior;
        private double valorActual;
        private bool nuevaEntrada;

        public Form1()
        {
            InitializeComponent();

            // Asignar eventos para botones numéricos
            btn0.Click += BtnNumero_Click;
            btn1.Click += BtnNumero_Click;
            btn2.Click += BtnNumero_Click;
            btn3.Click += BtnNumero_Click;
            btn4.Click += BtnNumero_Click;
            btn5.Click += BtnNumero_Click;
            btn6.Click += BtnNumero_Click;
            btn7.Click += BtnNumero_Click;
            btn8.Click += BtnNumero_Click;
            btn9.Click += BtnNumero_Click;

            // Asignar eventos para botones de operación básica
            btnSuma.Click += BtnOperacion_Click;
            btnResta.Click += BtnOperacion_Click;
            btnMultiplicacion.Click += BtnOperacion_Click;
            btnDivision.Click += BtnOperacion_Click;

            // Asignar eventos para botones de operación avanzada
            btnRaizCuadrada.Click += BtnOperacionAvanzada_Click;
            btnCuadrado.Click += BtnOperacionAvanzada_Click;
            btnPotencia.Click += BtnOperacionAvanzada_Click;
            btnPotenciaDiez.Click += BtnOperacionAvanzada_Click;
            btnLogaritmo.Click += BtnOperacionAvanzada_Click;
            btnFactorial.Click += BtnOperacionAvanzada_Click;
            btnCambioDeSigno.Click += BtnOperacionAvanzada_Click;

            // Asignar evento para el botón de igual
            btnIgual.Click += BtnIgual_Click;

            // Limpiar calculadora
            btnClear.Click += BtnClear_Click;

            // Borrar
            btnBorrar.Click += BtnBorrar_Click;

            nuevaEntrada = true;
        }

        // Método para manejar botones numéricos
        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            // Limpiamos el display si es una nueva entrada o si se realizó una operación previamente
            if (nuevaEntrada)
            {
                txtDisplay.Clear();
                nuevaEntrada = false;
            }

            txtDisplay.Text += boton.Text;
        }

        // Método para las operaciones básicas
        private void BtnOperacion_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out valorAnterior))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            Button boton = sender as Button;

            switch (boton.Text)
            {
                case "+":
                    operacionActual = new Suma();
                    break;
                case "-":
                    operacionActual = new Resta();
                    break;
                case "X":
                    operacionActual = new Multiplicacion();
                    break;
                case "÷":
                    operacionActual = new Division();
                    break;
            }

            nuevaEntrada = true; // Indicamos que debe limpiar el display en la próxima entrada
        }

        // Método para las operaciones avanzadas
        private void BtnOperacionAvanzada_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out valorActual))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            Button boton = sender as Button;

            // Define la operación avanzada según el botón presionado
            switch (boton.Text)
            {
                case "√":
                    operacionActual = new RaizCuadrada();
                    EjecutarOperacionAvanzada();
                    break;
                case "x²":
                    operacionActual = new Cuadrado();
                    EjecutarOperacionAvanzada();
                    break;
                case "x^y":
                    operacionActual = new Potencia();
                    valorAnterior = valorActual; // Almacena el primer valor como base
                    nuevaEntrada = true; // Limpiar el display para el segundo valor
                    txtDisplay.Clear();
                    return; // Esperar el segundo valor
                case "10^x":
                    operacionActual = new PotenciaDeDiez();
                    EjecutarOperacionAvanzada();
                    break;
                case "Log":
                    operacionActual = new Logaritmo();
                    EjecutarOperacionAvanzada();
                    break;
                case "n!":
                    operacionActual = new Factorial();
                    EjecutarOperacionAvanzada();
                    break;
                case "±":
                    valorActual = -valorActual; // Cambiar el signo
                    txtDisplay.Text = valorActual.ToString(); // Mostrar el valor cambiado
                    return;
            }
        }

        // Método para ejecutar operaciones avanzadas que no requieren un segundo valor
        private void EjecutarOperacionAvanzada()
        {
            try
            {
                if (operacionActual != null)
                {
                    double resultado = operacionActual.Calcular(valorActual);
                    txtDisplay.Text = resultado.ToString(); // Mostrar el resultado en el display
                    nuevaEntrada = true; // Marcar nueva entrada para limpiar el display en la próxima entrada numérica
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                txtDisplay.Text = "Error";
            }
        }

        // Método para calcular el resultado final
        private void BtnIgual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out valorActual))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            double resultado;

            try
            {
                if (operacionActual != null)
                {
                    // Verificamos si la operación es de potencia
                    if (operacionActual is Potencia)
                    {
                        resultado = operacionActual.Calcular(valorAnterior, valorActual); // Usar valorAnterior como base y valorActual como exponente
                    }
                    else
                    {
                        resultado = operacionActual.Calcular(valorAnterior, valorActual);
                    }

                    txtDisplay.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Seleccione una operación.");
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: División por cero.");
                txtDisplay.Text = "Error";
            }

            nuevaEntrada = true; // Indicamos que debe limpiar el display para la próxima entrada
        }

        // Método para limpiar el display y reiniciar la calculadora
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Limpiar el campo de texto (pantalla)
            txtDisplay.Clear();

            // Reiniciar valores de variables
            valorAnterior = 0;
            valorActual = 0;
            operacionActual = null;

            // Reiniciar el estado de la entrada
            nuevaEntrada = true;
        }

        // Método para manejar el botón Borrar (Backspace)
        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si el display no está vacío
            if (txtDisplay.Text.Length > 0)
            {
                // Eliminar el último carácter del display
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }
    }
}
