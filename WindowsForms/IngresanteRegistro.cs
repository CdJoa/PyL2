using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsForms
{
    public partial class IngresanteRegistro : Form
    {

        public IngresanteRegistro()
        {
            InitializeComponent();
        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        { }


        private void boton_ingresar(object sender, EventArgs e)
        {
            // Obtener los cursos seleccionados del grupo de CheckBox (asumiendo selecciones múltiples permitidas)
            string[] cursos = group_cursos.Controls.OfType<CheckBox>()
                                                   .Where(cb => cb.Checked)
                                                   .Select(cb => cb.Text)
                                                   .ToArray(); // Convertir a arreglo

            string direccion = lb_direccion.Text;

            // Manejar errores de conversión potenciales de manera elegante (considerar usar int.TryParse)
            int edad;
            if (!int.TryParse(lb_edad.Text, out edad))
            {
                MessageBox.Show("Ingrese un número válido para la edad.");
                return; // Salir de la función si el análisis falla
            }

            string genero = group_genero.Controls.OfType<RadioButton>()
                                             .Where(rb => rb.Checked)
                                             .FirstOrDefault()?.Text ?? "No ha asignado género";

            string nombre = lb_nombre.Text;
            string pais = lista_paises.SelectedItem?.ToString(); // Manejar valor nulo potencial de SelectedItem

            // Crear el objeto Ingresante con los datos proporcionados por el usuario
            Ingresante ingresante = new Ingresante(direccion, edad, genero, nombre, pais, cursos);

            // Mostrar los datos de ingresante en un cuadro de mensaje
            DialogResult result = MessageBox.Show(this, ingresante.Mostrar(), "Datos del Ingresante", MessageBoxButtons.OKCancel);

            // Manejar el resultado del diálogo
            if (result == DialogResult.OK)
            {
                // El usuario hizo clic en 'Aceptar'
                // Aquí puedes agregar el código para manejar la confirmación
            }
            else if (result == DialogResult.Cancel)
            {
                // El usuario hizo clic en 'Cancelar'
                // Aquí puedes agregar el código para manejar la cancelación
            }
        }

    }
}
