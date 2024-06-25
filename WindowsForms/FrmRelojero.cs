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
        public partial class FrmRelojero : Form
        {
            // Declarar el temporizador como un campo de la clase para acceso global
            private System.Windows.Forms.Timer timer;

            public FrmRelojero()
            {
                InitializeComponent();
            }

            private void Relojero_Load(object sender, EventArgs e)
            {
                AsignarHora();

                // Inicializar el temporizador
                timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000; // 1 segundo
                timer.Tick += Timer_Tick;
                timer.Start(); // Iniciar el temporizador al cargar el formulario
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                AsignarHora();
            }

            private void AsignarHora()
            {
                DateTime now = DateTime.Now;
                string horaActual = now.ToString("dd/MM/yyyy HH:mm:ss");
                lblHora.Text = horaActual;
            }

            private void btnActivar_Click(object sender, EventArgs e)
            {
                // Iniciar el temporizador
                if (timer != null)
                {
                    timer.Start();
                }
            }

            private void btnDesactivar_Click(object sender, EventArgs e)
            {
                // Detener el temporizador
                if (timer != null)
                {
                    timer.Stop();
                }
            }
        }
    }

