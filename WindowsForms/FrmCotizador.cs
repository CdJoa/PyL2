using Sobrecarga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FrmCotizador : Form
    {
        public FrmCotizador()
        {
            InitializeComponent();
            ActualizarCotizaciones();
        }
        private void ActualizarCotizaciones()
        {
            double cotizacionEuro = Euro.GetCotizacion();
            lb_cotiz_euro.Text = cotizacionEuro.ToString("F2");

            double cotizacionPeso = Peso.GetCotizacion();
            lb_cotiz_peso.Text = cotizacionPeso.ToString("F3");
        }

        private void textbox_cotizacion_euro(object sender, EventArgs e)
        {
            if (double.TryParse(lb_cotiz_euro.Text, out double nuevaCotizacionEuro))
            {
                Euro.SetCotizacion(nuevaCotizacionEuro);
            }
            else
            {
                MessageBox.Show("Cotización inválida. Por favor ingrese números válidos.");
            }
        }

        private void textbox_cotizacion_Peso(object sender, EventArgs e)
        {
            if (double.TryParse(lb_cotiz_peso.Text, out double nuevaCotizacionPeso))
            {
                Peso.SetCotizacion(nuevaCotizacionPeso);
            }
            else
            {
                MessageBox.Show("Cotización inválida. Por favor ingrese números válidos.");
            }
        }


        private void candado_abre(object sender, EventArgs e)
        {
            if (btn_candado.ImageIndex == 1)
            {
                btn_candado.ImageIndex = 0;

                lb_cotiz_euro.ReadOnly = false;
                lb_cotiz_peso.ReadOnly = false;

            }
            else
            {
                btn_candado.ImageIndex = 1;
                lb_cotiz_euro.ReadOnly = true;
                lb_cotiz_peso.ReadOnly = true;

            }

        }

        private void clic_traslado_euros(object sender, EventArgs e)
        {
            // Asumiendo que 'cantidad_euros' es un TextBox donde se ingresa la cantidad de euros a convertir.
            if (double.TryParse(cantidad_euros.Text, out double cantidadEuros))
            {
                // Crear un objeto Euro con la cantidad ingresada.
                Euro euros = new Euro(cantidadEuros);

                // Realizar la conversión y actualizar el texto del TextBox 'euro_dolar'.
                euro_dolar.Text = Math.Round(euros.GetCantidad() * Euro.GetCotizacion(),3).ToString();
                euro_euro.Text = (Math.Round(euros.GetCantidad(),3).ToString());
                euro_peso.Text = Math.Round((euros.GetCantidad() * Euro.GetCotizacion()) * Peso.GetCotizacion(),5).ToString();


            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de euros.");
            }
        }

        private void clic_traslado_dolares(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad_dolares.Text, out double cantidadDolares))
            {
                // Crear un objeto Euro con la cantidad ingresada.
                Dolar dolar = new Dolar(cantidadDolares);

                // Realizar la conversión y actualizar el texto del TextBox 'euro_dolar'.
                dolar_euro.Text = Math.Round(dolar.GetCantidad() / Euro.GetCotizacion(),3).ToString();
                dolar_dolar.Text = (Math.Round(dolar.GetCantidad(),3).ToString());
                dolar_peso.Text = (Math.Round(dolar.GetCantidad() / Peso.GetCotizacion(),5).ToString());

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de dolares.");
            }
        }

        private void click_traslado_pesos(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad_pesos.Text, out double cantidadPesos))
            {
                // Crear un objeto Euro con la cantidad ingresada.
                Peso pesos = new Peso(cantidadPesos);

                // Realizar la conversión y actualizar el texto del TextBox 'euro_dolar'.
                peso_euro.Text = Math.Round(((pesos.GetCantidad() * Peso.GetCotizacion()) / Euro.GetCotizacion()),5).ToString();
                peso_peso.Text = (Math.Round(pesos.GetCantidad(),3).ToString());
                peso_dolar.Text = (Math.Round(pesos.GetCantidad() * Peso.GetCotizacion(),3).ToString());

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de pesos.");
            }
        }
    }
}




