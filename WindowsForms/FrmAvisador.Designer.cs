namespace WindowsForms
{
    partial class FrmAvisador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelnombre = new Label();
            labelapellido = new Label();
            txtBnombre = new TextBox();
            txtBapellido = new TextBox();
            btnAct = new Button();
            lbl_persona = new Label();
            SuspendLayout();
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(99, 77);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(61, 20);
            labelnombre.TabIndex = 0;
            labelnombre.Text = "nombre";
            // 
            // labelapellido
            // 
            labelapellido.AutoSize = true;
            labelapellido.Location = new Point(99, 220);
            labelapellido.Name = "labelapellido";
            labelapellido.Size = new Size(64, 20);
            labelapellido.TabIndex = 1;
            labelapellido.Text = "apellido";
            // 
            // txtBnombre
            // 
            txtBnombre.Location = new Point(226, 74);
            txtBnombre.Name = "txtBnombre";
            txtBnombre.Size = new Size(268, 27);
            txtBnombre.TabIndex = 2;
            // 
            // txtBapellido
            // 
            txtBapellido.Location = new Point(231, 220);
            txtBapellido.Name = "txtBapellido";
            txtBapellido.Size = new Size(263, 27);
            txtBapellido.TabIndex = 3;
            // 
            // btnAct
            // 
            btnAct.Location = new Point(288, 281);
            btnAct.Name = "btnAct";
            btnAct.Size = new Size(94, 29);
            btnAct.TabIndex = 4;
            btnAct.Text = "actualizar";
            btnAct.UseVisualStyleBackColor = true;
            btnAct.Click += btnAct_Click;
            // 
            // lbl_persona
            // 
            lbl_persona.AutoSize = true;
            lbl_persona.Location = new Point(213, 383);
            lbl_persona.Name = "lbl_persona";
            lbl_persona.Size = new Size(0, 20);
            lbl_persona.TabIndex = 5;
            // 
            // FrmAvisador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_persona);
            Controls.Add(btnAct);
            Controls.Add(txtBapellido);
            Controls.Add(txtBnombre);
            Controls.Add(labelapellido);
            Controls.Add(labelnombre);
            Name = "FrmAvisador";
            Text = "FrmAvisador";
            Load += FrmAvisador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnombre;
        private Label labelapellido;
        private TextBox txtBnombre;
        private TextBox txtBapellido;
        private Button btnAct;
        private Label lbl_persona;
    }
}