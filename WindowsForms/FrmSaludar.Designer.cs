namespace WindowsForms
{
    partial class FrmSaludar
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
            lb_mensaje = new Label();
            SuspendLayout();
            // 
            // lb_mensaje
            // 
            lb_mensaje.AutoSize = true;
            lb_mensaje.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_mensaje.Location = new Point(232, 150);
            lb_mensaje.Name = "lb_mensaje";
            lb_mensaje.Size = new Size(84, 41);
            lb_mensaje.TabIndex = 0;
            lb_mensaje.Tag = "";
            lb_mensaje.Text = "Hola";
            // 
            // FrmSaludar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_mensaje);
            Name = "FrmSaludar";
            Text = "Saludar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_mensaje;
    }
}