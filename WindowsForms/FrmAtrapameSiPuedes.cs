using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excepcion;

namespace WindowsForms
{
    public partial class FrmAtrapameSiPuedes : Form
    {
        public FrmAtrapameSiPuedes()
        {
            InitializeComponent();
        }

        private void btnCalcularAtrapame_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.txtKM.Text == "" || this.txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException("Por favor, ingrese valores en ambos campos.");
                }

                int km = int.Parse(txtKM.Text);
                int litros = int.Parse(txtLitros.Text);

                if (km < 0 || litros < 0)
                {
                    MessageBox.Show("Por favor, ingresar números reales positivos en ambos campos.");
                }
                else
                {
                    this.RichAtrapame.Text = $"km/lts : {calculo.Calcular(km, litros)}";
                }
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }

        }
    }
}
