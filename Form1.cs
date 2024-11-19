using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVladi
{
    public partial class Form1 : Form
    {
        // Declaracion de las variables
        private double valor1; // Representa el primer número
        private double valor2; // Representa el segundo número
        private double resultado; // Guardará el resultado de las operaciones
        private int operacion; // Variable para manejar los casos con switch() para poder diferenciar la suma, resta, multiplicación y división


        public Form1()
        {
            InitializeComponent();
        }



        #region Bótones de Números y Punto
        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        #endregion



        #region Botón de Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }
        #endregion


      

        #region Botón de Suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = 1;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }
        #endregion


        #region Botón de Resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            // Boton de la resta
            operacion = 2;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }
        #endregion



        #region Botón de Multiplicación
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operacion = 3;
            valor1 = Convert.ToDouble((txtDisplay.Text));
            txtDisplay.Text = "";
        }
        #endregion


        #region Botón de División
        private void btnDivision_Click(object sender, EventArgs e)
        {
            operacion = 4;
            valor1 = Convert.ToDouble((txtDisplay.Text));
            txtDisplay.Text = "";
        }
        #endregion


        #region Botón de Igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtDisplay.Text);
            switch (operacion) // Manejo de un menú
            {
                case 1: // Caso 1 para la suma
                    resultado = valor1 + valor2;
                    resultado = Math.Round(resultado,2); // Se aproxima y muestra 2 decimales
                    break;
                case 2: // Caso 2 para la resta
                    resultado = valor1 - valor2;
                    resultado = Math.Round(resultado, 2); // Se aproxima y muestra 2 decimales
                    break;
                case 3: // Caso 3 para la multipliación
                    resultado = valor1 * valor2;
                    resultado = Math.Round(resultado,2);// Se aproxima y muestra 2 decimales
                    break;
                case 4: // Caso 4 para la resta
                    if(valor2 == 0) // Una condición para evitar la división con 0.
                    {
                        // Si el segundo número es 0 entonces se muestra el mensaje de error
                        MessageBox.Show("No se puede dividir con 0.", "Indeterminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else // Si el segundo número no es 0, entonces se procede a dividir.
                    {
                        resultado = valor1 / valor2;
                        resultado = Math.Round(resultado,2);// Se aproxima y muestra 2 decimales

                    }
                    break;
            }
            txtDisplay.Text = resultado.ToString();
        }
        #endregion


    }
}