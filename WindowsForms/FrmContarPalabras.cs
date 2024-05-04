using BibliotecaDeClases;
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
    public partial class FrmContarPalabras : Form
    {
        public FrmContarPalabras()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string palabras = richContarPalabras.Text;

            // Verificar si no se ingresaron palabras
            if (string.IsNullOrWhiteSpace(palabras))
            {
                MessageBox.Show(this, "NO SE INGRESARON PALABRAS", "Advertencia", MessageBoxButtons.OK);
                return;
            }

            // Utilizar una expresión regular para encontrar todas las palabras en el texto
            MatchCollection matches = Regex.Matches(palabras, @"\b\w+\b");

            // Crear un diccionario para almacenar las frecuencias de las palabras
            Dictionary<string, int> frecuenciaPalabras = new Dictionary<string, int>();

            // Contar la frecuencia de cada palabra
            foreach (Match match in matches)
            {
                string palabraNormalizada = match.Value.ToLower(); // Convertir a minúsculas para considerar mayúsculas y minúsculas iguales
                if (frecuenciaPalabras.ContainsKey(palabraNormalizada))
                {
                    frecuenciaPalabras[palabraNormalizada]++;
                }
                else
                {
                    frecuenciaPalabras[palabraNormalizada] = 1;
                }
            }

            // Ordenar el diccionario por valor (frecuencia) en orden descendente
            var palabrasOrdenadas = frecuenciaPalabras.OrderByDescending(x => x.Value);

            // Tomar las tres palabras con mayor frecuencia
            var top3Palabras = palabrasOrdenadas.Take(3).ToList();

            // Crear un string con las palabras y sus frecuencias, incluyendo números
            string mensaje = "Top 3 palabras más repetidas:\n";
            for (int i = 0; i < top3Palabras.Count; i++)
            {
                mensaje += $"{i + 1}. {top3Palabras[i].Key}: {top3Palabras[i].Value} veces\n";
            }

            // Mostrar los datos en un cuadro de mensaje
            DialogResult result = MessageBox.Show(this, mensaje, "Top 3 palabras más repetidas", MessageBoxButtons.OK);

            // Manejar el resultado del diálogo si es necesario
            if (result == DialogResult.OK)
            {
                // El usuario hizo clic en 'Aceptar'
                // Puedes agregar código adicional aquí si es necesario
            }
        }



    }

}

