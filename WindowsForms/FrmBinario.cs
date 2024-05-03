using BibliotecaDeClases;
using Sobrecarga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmBinario : Form
    {
        public FrmBinario()
        {
            InitializeComponent();
        }

        private void btn_Binario_a_Decimal_Click(object sender, EventArgs e)
        {
            string inputBinario = cantidad_binario.Text;

            // Verificar si el input es un número binario válido.
            if (Regex.IsMatch(inputBinario, "^[01]+$"))
            {
                // Convertir el número binario a decimal.
                NumeroDecimal numeroDecimal = Conversor.BinarioADecimal(inputBinario);

                // Actualizar el texto del TextBox con el valor decimal.
                txtDecimal.Text = numeroDecimal.Numero.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número binario válido.");
            }
        }

        private void btn_Decimal_a_Binario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad_decimal.Text, out double cantidadDecimal))
            {
                // Asegurarse de que la cantidadDecimal es un número entero antes de convertirlo a binario.
                int valorEntero = (int)cantidadDecimal;

                // Utilizar el método Convert.ToString para realizar la conversión a binario.
                string binario = Convert.ToString(valorEntero, 2);

                // Actualizar el texto del TextBox con el valor binario.
                txtBinario.Text = binario;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número decimal válido.");
            }
        }


    }
}

