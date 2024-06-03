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
            btn_Fact_Total = new Button();
            btn_Fact_Local = new Button();
            btn_Fact_Prov = new Button();
            btn_Salir_Menu = new Button();
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
            // btn_Fact_Total
            // 
            btn_Fact_Total.Location = new Point(82, 131);
            btn_Fact_Total.Name = "btn_Fact_Total";
            btn_Fact_Total.Size = new Size(180, 71);
            btn_Fact_Total.TabIndex = 1;
            btn_Fact_Total.Text = "Facturacion_Total";
            btn_Fact_Total.UseVisualStyleBackColor = true;
            btn_Fact_Total.Click += btn_Fact_Total_Click;
            // 
            // btn_Fact_Local
            // 
            btn_Fact_Local.Location = new Point(82, 224);
            btn_Fact_Local.Name = "btn_Fact_Local";
            btn_Fact_Local.Size = new Size(180, 71);
            btn_Fact_Local.TabIndex = 2;
            btn_Fact_Local.Text = "Facturacion_Local";
            btn_Fact_Local.UseVisualStyleBackColor = true;
            btn_Fact_Local.Click += btn_Fact_Local_Click;
            // 
            // btn_Fact_Prov
            // 
            btn_Fact_Prov.Location = new Point(82, 324);
            btn_Fact_Prov.Name = "btn_Fact_Prov";
            btn_Fact_Prov.Size = new Size(180, 71);
            btn_Fact_Prov.TabIndex = 3;
            btn_Fact_Prov.Text = "Facturacion_Provincial";
            btn_Fact_Prov.UseVisualStyleBackColor = true;
            btn_Fact_Prov.Click += btn_Fact_Prov_Click;
            // 
            // btn_Salir_Menu
            // 
            btn_Salir_Menu.Location = new Point(82, 412);
            btn_Salir_Menu.Name = "btn_Salir_Menu";
            btn_Salir_Menu.Size = new Size(180, 71);
            btn_Salir_Menu.TabIndex = 4;
            btn_Salir_Menu.Text = "Salir";
            btn_Salir_Menu.UseVisualStyleBackColor = true;
            btn_Salir_Menu.Click += btn_Salir_Menu_Click;
            // 
            // FrmCentralitaMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 495);
            Controls.Add(btn_Salir_Menu);
            Controls.Add(btn_Fact_Prov);
            Controls.Add(btn_Fact_Local);
            Controls.Add(btn_Fact_Total);
            Controls.Add(btn_generar_llamada);
            Name = "FrmCentralitaMenu";
            Text = "FrmCentralitaMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_generar_llamada;
        private Button btn_Fact_Total;
        private Button btn_Fact_Local;
        private Button btn_Fact_Prov;
        private Button btn_Salir_Menu;
    }
}