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

namespace WindowsForms
{
    public partial class FrmCentralitaMenu : Form
    {
        private static Centralita centralita;
        private static bool centralitaCreada = false;

        public FrmCentralitaMenu()
        {
            InitializeComponent();

            /*si no existe nada mas*/
            if (!centralitaCreada)
            {
                centralita = new Centralita("Joaco Center");
                centralitaCreada = true;
            }
        }

        private void btn_generar_llamada_Click(object sender, EventArgs e)
        {
            FrmCentralitaLlamada centralitaLlamada = new FrmCentralitaLlamada(centralita);
            this.Hide();
            DialogResult resultado = centralitaLlamada.ShowDialog();
            this.Show();
        }

        private void btn_Fact_Total_Click(object sender, EventArgs e)
        {

            float totalFacturacion = centralita.GananciaPorTotal;

            // Display the results (you can adapt this to your UI)
            MessageBox.Show(
                            $"Facturacion total: {totalFacturacion:C}",
                            "Ganancias",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void btn_Fact_Local_Click(object sender, EventArgs e)
        {
            float totalFacturacionLocal = centralita.GananciaPorLocal;

            // Display the results (you can adapt this to your UI)
            MessageBox.Show(
                            $"Facturacion local total: {totalFacturacionLocal:C}",
                            "Ganancias",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn_Fact_Prov_Click(object sender, EventArgs e)
        {
            float totalFacturacionProvincial = centralita.GananciaPorProvincial;

            // Display the results (you can adapt this to your UI)
            MessageBox.Show(
                            $"Facturacion Provincial total: {totalFacturacionProvincial:C}",
                            "Ganancias",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btn_Salir_Menu_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
