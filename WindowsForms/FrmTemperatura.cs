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
    public partial class FrmTemperatura : Form
    {
        public FrmTemperatura()
        {
            InitializeComponent();
        }


        private void clic_btn_f(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad_F.Text, out double cantidadFahrenheit))
            {
                // Crear un objeto Fahrenheit con la cantidad ingresada.
                Fahrenheit fahrenheit = new Fahrenheit(cantidadFahrenheit);

                // Realizar la conversión a Celsius y Kelvin.
                Celsius fahrenheitACelcius = (Celsius)fahrenheit;
                Kelvin fahrenheitAKelvin = (Kelvin)fahrenheit;

                // Actualizar el texto de los TextBox con los valores redondeados.
                f_f.Text = Math.Round(fahrenheit.GetCantidad(), 3).ToString();
                f_c.Text = Math.Round(fahrenheitACelcius.GetCantidad(), 3).ToString();
                f_k.Text = Math.Round(fahrenheitAKelvin.GetCantidad(), 3).ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de Fahrenheit.");
            }
        }


        private void clic_btn_c(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad_C.Text, out double cantidadCelsius))
            {
                // Crear un objeto Celsius con la cantidad ingresada.
                Celsius celsius = new Celsius(cantidadCelsius);

                // Realizar la conversión a Fahrenheit y Kelvin.
                Fahrenheit celsiusAFahrenheit = (Fahrenheit)celsius;
                Kelvin celsiusAKelvin = (Kelvin)celsius;

                // Actualizar el texto de los TextBox con los valores redondeados.
                c_f.Text = Math.Round(celsiusAFahrenheit.GetCantidad(), 3).ToString();
                c_c.Text = Math.Round(celsius.GetCantidad(), 3).ToString();
                c_k.Text = Math.Round(celsiusAKelvin.GetCantidad(), 3).ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de Celsius.");
            }
        }


        private void clic_btn_k(object sender, EventArgs e)
        {
            if (double.TryParse(cantidad__K.Text, out double cantidadKelvin))
            {
                // Crear un objeto Kelvin con la cantidad ingresada.
                Kelvin kelvin = new Kelvin(cantidadKelvin);

                // Realizar la conversión a Fahrenheit y Celsius.
                Fahrenheit kelvinAFahrenheit = (Fahrenheit)kelvin;
                Celsius kelvinACelsius = (Celsius)kelvin;

                // Actualizar el texto de los TextBox con los valores redondeados.
                k_f.Text = Math.Round(kelvinAFahrenheit.GetCantidad(), 3).ToString();
                k_c.Text = Math.Round(kelvinACelsius.GetCantidad(), 3).ToString();
                k_k.Text = Math.Round(kelvin.GetCantidad(), 3).ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido de Kelvin.");
            }
        }

    }
}
