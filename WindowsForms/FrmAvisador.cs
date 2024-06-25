using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HilosYEventos;
namespace WindowsForms
{
    public partial class FrmAvisador : Form
    {
        private PersonaH persona;
        public delegate void DelegadoString(string mensaje);

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void FrmAvisador_Load(object sender, EventArgs e)
        {

        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                string nombre = txtBnombre.Text;
                string apellido = txtBapellido.Text;
                persona = new PersonaH(nombre, apellido);
                persona.PropertyChanged += Persona_PropertyChanged;
            }
            else
            {
                string nombre = txtBnombre.Text;
                string apellido = txtBapellido.Text;
                persona.Nombre = nombre;
                persona.Apellido = apellido;
            }

            lbl_persona.Text = persona.Mostrar();
        }

        private void Persona_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MessageBox.Show("Se ha modificado " + e.PropertyName);
        }
    }
}
