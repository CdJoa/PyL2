namespace WindowsForms
{
    partial class FrmDelegadoMostrar
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
            labelNombre = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(60, 43);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(181, 59);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "label1";
            // 
            // FrmDelegadoMostrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNombre);
            Name = "FrmDelegadoMostrar";
            Text = "FrmDelegadoMostrar";
            Load += FrmDelegadoMostrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
    }
}