﻿using System;
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
    public partial class FrmDelegadoMostrar : Form
    {
        public FrmDelegadoMostrar()
        {
            InitializeComponent();
        }

        private void FrmDelegadoMostrar_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarNombre(string nombre)
        {
            labelNombre.Text = nombre;
        }
    }
}
