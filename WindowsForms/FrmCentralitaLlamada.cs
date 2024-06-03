using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCentralita;
using static BibliotecaCentralita.Provincial;

namespace WindowsForms
{
    public partial class FrmCentralitaLlamada : Form
    {
        private Centralita centralita;

        public FrmCentralitaLlamada(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            GenerarNumeroAleatorio();
            comboBox1.DataSource = Enum.GetValues(typeof(Provincial.Franja));

        }

        private void GenerarNumeroAleatorio()
        {
            // Crear una instancia de la clase Random
            Random rnd = new Random();

            // Generar 6 dígitos aleatorios
            string digitosAleatorios = rnd.Next(1000000, 9999999).ToString();

            // Concatenar "4" al principio de los dígitos aleatorios
            string numeroAleatorio = "4" + digitosAleatorios;

            // Mostrar el número aleatorio en el TextBox txtNroOrigen.Text
            txtNroOrigen.Text = numeroAleatorio;
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            string cero = this.button0.Text;

            // Concatenar el texto del botón 0 al texto actual del TextBox
            txtNroDestino.Text += cero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uno = this.button1.Text;

            txtNroDestino.Text += uno;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dos = this.button2.Text;
            txtNroDestino.Text += dos;
        }

        // Repite este patrón para los botones 3 al 9, el asterisco (*) y la almohadilla (#)
        // Por ejemplo:
        private void button3_Click(object sender, EventArgs e)
        {
            string tres = this.button3.Text;
            txtNroDestino.Text += tres;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string cuatro = this.button4.Text;
            txtNroDestino.Text += cuatro;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cinco = this.button5.Text;
            txtNroDestino.Text += cinco;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string seis = this.button6.Text;
            txtNroDestino.Text += seis;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string siete = this.button7.Text;
            txtNroDestino.Text += siete;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ocho = this.button8.Text;
            txtNroDestino.Text += ocho;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string nueve = this.button9.Text;
            txtNroDestino.Text += nueve;
        }


        private void buttonHash_Click(object sender, EventArgs e)
        {
            // Verificar si el TextBox txtNroDestino está vacío
            if (txtNroDestino.Text == "")
            {
                // Si está vacío, agregar el carácter #
                txtNroDestino.Text += "#";
            }
            else
            {
                // Si no está vacío, establecer el TextBox como solo lectura
                txtNroDestino.ReadOnly = true;
            }
        }


        private void buttonasterisco_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text == "")
                txtNroDestino.Text += "*";
            else
            {
                // Si no está vacío, establecer el TextBox como solo lectura
                txtNroDestino.ReadOnly = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLLamar_Click(object sender, EventArgs e)
        {
            string origen = txtNroOrigen.Text;
            string destino = txtNroDestino.Text;

            if (string.IsNullOrEmpty(origen) || string.IsNullOrEmpty(destino))
            {
                MessageBox.Show("Por favor, ingrese un origen y un destino válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            float duracion = (float)random.Next(1, 51);
            float costo = (float)(random.NextDouble() * (5.6 - 0.5) + 0.5);

            try
            {
                if (destino.StartsWith("#"))
                {
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una franja horaria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Provincial.Franja franja = (Provincial.Franja)comboBox1.SelectedItem;
                    Provincial lProvincial = new Provincial(destino, franja, duracion, origen);
                    centralita += lProvincial;
                }
                else
                {
                    Local lLocal = new Local(destino, duracion, origen, costo);
                    centralita += lLocal;
                }

                txtNroDestino.Text = "";
                txtNroOrigen.Text = "";
                GenerarNumeroAleatorio();
            }
            catch (CentralitaException ex)
            {
                MessageBox.Show(ex.Message, "Error en la centralita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
            GenerarNumeroAleatorio();

        }
        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el texto en txtNroDestino comienza con "#"
            bool empiezaConNumeral = !string.IsNullOrEmpty(txtNroDestino.Text) && txtNroDestino.Text.StartsWith("#");

            // Habilitar o deshabilitar la selección de la franja horaria en el ComboBox según el resultado
            comboBox1.Enabled = empiezaConNumeral;

            // Si no cumple la condición, restablecer el ComboBox seleccionando el índice -1
            if (!empiezaConNumeral)
            {
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}



