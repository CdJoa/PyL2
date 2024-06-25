namespace WindowsForms
{
    partial class FrmTestDelegados
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
            btnActualizar = new Button();
            txtDel = new TextBox();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(56, 93);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(484, 47);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtDel
            // 
            txtDel.Location = new Point(56, 22);
            txtDel.Name = "txtDel";
            txtDel.Size = new Size(484, 27);
            txtDel.TabIndex = 1;
            // 
            // FrmTestDelegados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 183);
            Controls.Add(txtDel);
            Controls.Add(btnActualizar);
            Name = "FrmTestDelegados";
            Text = "FrmMostrarDelegados";
            Load += FrmTestDelegados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private TextBox txtDel;
    }
}