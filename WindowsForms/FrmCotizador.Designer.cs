namespace WindowsForms
{
    partial class FrmCotizador
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotizador));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cantidad_euros = new TextBox();
            cantidad_dolares = new TextBox();
            cantidad_pesos = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_traslado_euro = new Button();
            lb_cotiz_euro = new TextBox();
            lb_cotiz_dolar = new TextBox();
            lb_cotiz_peso = new TextBox();
            btn_traslado_dolar = new Button();
            candado = new ImageList(components);
            btn_candado = new Button();
            btn_traslado_peso = new Button();
            euro_euro = new TextBox();
            dolar_euro = new TextBox();
            peso_euro = new TextBox();
            euro_dolar = new TextBox();
            dolar_dolar = new TextBox();
            peso_dolar = new TextBox();
            euro_peso = new TextBox();
            dolar_peso = new TextBox();
            peso_peso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 52);
            label1.Name = "label1";
            label1.Size = new Size(132, 31);
            label1.TabIndex = 0;
            label1.Text = "Cotización";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(66, 31);
            label2.TabIndex = 1;
            label2.Text = "Euro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 247);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 2;
            label3.Text = "Dolar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 348);
            label4.Name = "label4";
            label4.Size = new Size(68, 31);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            // 
            // cantidad_euros
            // 
            cantidad_euros.Location = new Point(156, 150);
            cantidad_euros.Name = "cantidad_euros";
            cantidad_euros.Size = new Size(93, 27);
            cantidad_euros.TabIndex = 4;
            // 
            // cantidad_dolares
            // 
            cantidad_dolares.Location = new Point(156, 253);
            cantidad_dolares.Name = "cantidad_dolares";
            cantidad_dolares.Size = new Size(93, 27);
            cantidad_dolares.TabIndex = 5;
            // 
            // cantidad_pesos
            // 
            cantidad_pesos.Location = new Point(156, 348);
            cantidad_pesos.Name = "cantidad_pesos";
            cantidad_pesos.Size = new Size(93, 27);
            cantidad_pesos.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(382, 100);
            label5.Name = "label5";
            label5.Size = new Size(66, 31);
            label5.TabIndex = 7;
            label5.Text = "Euro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(528, 100);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 8;
            label6.Text = "Dolar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(671, 100);
            label7.Name = "label7";
            label7.Size = new Size(68, 31);
            label7.TabIndex = 9;
            label7.Text = "Peso";
            // 
            // btn_traslado_euro
            // 
            btn_traslado_euro.Location = new Point(278, 150);
            btn_traslado_euro.Name = "btn_traslado_euro";
            btn_traslado_euro.Size = new Size(69, 27);
            btn_traslado_euro.TabIndex = 10;
            btn_traslado_euro.Text = "->";
            btn_traslado_euro.UseVisualStyleBackColor = true;
            btn_traslado_euro.Click += clic_traslado_euros;
            // 
            // lb_cotiz_euro
            // 
            lb_cotiz_euro.Location = new Point(382, 56);
            lb_cotiz_euro.Name = "lb_cotiz_euro";
            lb_cotiz_euro.Size = new Size(93, 27);
            lb_cotiz_euro.TabIndex = 11;
            lb_cotiz_euro.TextChanged += textbox_cotizacion_euro;
            // 
            // lb_cotiz_dolar
            // 
            lb_cotiz_dolar.Enabled = false;
            lb_cotiz_dolar.Location = new Point(528, 56);
            lb_cotiz_dolar.Name = "lb_cotiz_dolar";
            lb_cotiz_dolar.ReadOnly = true;
            lb_cotiz_dolar.Size = new Size(93, 27);
            lb_cotiz_dolar.TabIndex = 12;
            lb_cotiz_dolar.Text = "1";
            lb_cotiz_dolar.TextAlign = HorizontalAlignment.Center;
            // 
            // lb_cotiz_peso
            // 
            lb_cotiz_peso.Location = new Point(671, 58);
            lb_cotiz_peso.Name = "lb_cotiz_peso";
            lb_cotiz_peso.Size = new Size(93, 27);
            lb_cotiz_peso.TabIndex = 13;
            lb_cotiz_peso.TextChanged += textbox_cotizacion_Peso;
            // 
            // btn_traslado_dolar
            // 
            btn_traslado_dolar.Location = new Point(278, 253);
            btn_traslado_dolar.Name = "btn_traslado_dolar";
            btn_traslado_dolar.Size = new Size(69, 27);
            btn_traslado_dolar.TabIndex = 14;
            btn_traslado_dolar.Text = "->";
            btn_traslado_dolar.UseVisualStyleBackColor = true;
            btn_traslado_dolar.Click += clic_traslado_dolares;
            // 
            // candado
            // 
            candado.ColorDepth = ColorDepth.Depth32Bit;
            candado.ImageStream = (ImageListStreamer)resources.GetObject("candado.ImageStream");
            candado.TransparentColor = Color.Transparent;
            candado.Images.SetKeyName(0, "candado_cerrado.png");
            candado.Images.SetKeyName(1, "candado_abierto.png");
            // 
            // btn_candado
            // 
            btn_candado.BackColor = Color.White;
            btn_candado.BackgroundImageLayout = ImageLayout.Center;
            btn_candado.ImageKey = "candado_cerrado.png";
            btn_candado.ImageList = candado;
            btn_candado.Location = new Point(235, 42);
            btn_candado.Name = "btn_candado";
            btn_candado.Size = new Size(64, 59);
            btn_candado.TabIndex = 15;
            btn_candado.UseVisualStyleBackColor = false;
            btn_candado.Click += candado_abre;
            // 
            // btn_traslado_peso
            // 
            btn_traslado_peso.Location = new Point(278, 348);
            btn_traslado_peso.Name = "btn_traslado_peso";
            btn_traslado_peso.Size = new Size(69, 27);
            btn_traslado_peso.TabIndex = 16;
            btn_traslado_peso.Text = "->";
            btn_traslado_peso.UseVisualStyleBackColor = true;
            btn_traslado_peso.Click += click_traslado_pesos;
            // 
            // euro_euro
            // 
            euro_euro.AccessibleRole = AccessibleRole.None;
            euro_euro.Location = new Point(382, 150);
            euro_euro.Name = "euro_euro";
            euro_euro.ReadOnly = true;
            euro_euro.Size = new Size(93, 27);
            euro_euro.TabIndex = 17;
            // 
            // dolar_euro
            // 
            dolar_euro.Location = new Point(382, 253);
            dolar_euro.Name = "dolar_euro";
            dolar_euro.ReadOnly = true;
            dolar_euro.Size = new Size(93, 27);
            dolar_euro.TabIndex = 18;
            // 
            // peso_euro
            // 
            peso_euro.Location = new Point(382, 348);
            peso_euro.Name = "peso_euro";
            peso_euro.ReadOnly = true;
            peso_euro.Size = new Size(93, 27);
            peso_euro.TabIndex = 19;
            // 
            // euro_dolar
            // 
            euro_dolar.Location = new Point(528, 150);
            euro_dolar.Name = "euro_dolar";
            euro_dolar.ReadOnly = true;
            euro_dolar.Size = new Size(93, 27);
            euro_dolar.TabIndex = 20;
            // 
            // dolar_dolar
            // 
            dolar_dolar.Location = new Point(528, 253);
            dolar_dolar.Name = "dolar_dolar";
            dolar_dolar.ReadOnly = true;
            dolar_dolar.Size = new Size(93, 27);
            dolar_dolar.TabIndex = 21;
            // 
            // peso_dolar
            // 
            peso_dolar.Location = new Point(528, 348);
            peso_dolar.Name = "peso_dolar";
            peso_dolar.ReadOnly = true;
            peso_dolar.Size = new Size(93, 27);
            peso_dolar.TabIndex = 22;
            // 
            // euro_peso
            // 
            euro_peso.Location = new Point(671, 154);
            euro_peso.Name = "euro_peso";
            euro_peso.ReadOnly = true;
            euro_peso.Size = new Size(93, 27);
            euro_peso.TabIndex = 23;
            // 
            // dolar_peso
            // 
            dolar_peso.Location = new Point(671, 253);
            dolar_peso.Name = "dolar_peso";
            dolar_peso.ReadOnly = true;
            dolar_peso.Size = new Size(93, 27);
            dolar_peso.TabIndex = 24;
            // 
            // peso_peso
            // 
            peso_peso.Location = new Point(671, 348);
            peso_peso.Name = "peso_peso";
            peso_peso.ReadOnly = true;
            peso_peso.Size = new Size(93, 27);
            peso_peso.TabIndex = 25;
            // 
            // FrmCotizador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(peso_peso);
            Controls.Add(dolar_peso);
            Controls.Add(euro_peso);
            Controls.Add(peso_dolar);
            Controls.Add(dolar_dolar);
            Controls.Add(euro_dolar);
            Controls.Add(peso_euro);
            Controls.Add(dolar_euro);
            Controls.Add(euro_euro);
            Controls.Add(btn_traslado_peso);
            Controls.Add(btn_candado);
            Controls.Add(btn_traslado_dolar);
            Controls.Add(lb_cotiz_peso);
            Controls.Add(lb_cotiz_dolar);
            Controls.Add(lb_cotiz_euro);
            Controls.Add(btn_traslado_euro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cantidad_pesos);
            Controls.Add(cantidad_dolares);
            Controls.Add(cantidad_euros);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCotizador";
            Text = "FrmCotizador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox cantidad_euros;
        private TextBox cantidad_dolares;
        private TextBox cantidad_pesos;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btn_traslado_euro;
        private TextBox lb_cotiz_euro;
        private TextBox lb_cotiz_dolar;
        private TextBox lb_cotiz_peso;
        private Button btn_traslado_dolar;
        private ImageList candado;
        private Button btn_candado;
        private Button btn_traslado_peso;
        private TextBox euro_euro;
        private TextBox dolar_euro;
        private TextBox peso_euro;
        private TextBox euro_dolar;
        private TextBox dolar_dolar;
        private TextBox peso_dolar;
        private TextBox euro_peso;
        private TextBox dolar_peso;
        private TextBox peso_peso;
    }
}