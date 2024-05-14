namespace WindowsForms
{
    partial class FrmCentralitaMenu
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
            btn_generar_llamada = new Button();
            SuspendLayout();
            // 
            // btn_generar_llamada
            // 
            btn_generar_llamada.Location = new Point(82, 36);
            btn_generar_llamada.Name = "btn_generar_llamada";
            btn_generar_llamada.Size = new Size(180, 71);
            btn_generar_llamada.TabIndex = 0;
            btn_generar_llamada.Text = "Generar LLamada";
            btn_generar_llamada.UseVisualStyleBackColor = true;
            btn_generar_llamada.Click += btn_generar_llamada_Click;
            // 
            // FrmCentralitaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 495);
            Controls.Add(btn_generar_llamada);
            Name = "FrmCentralitaMenu";
            Text = "FrmCentralitaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_generar_llamada;
    }
}