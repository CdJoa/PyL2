namespace WindowsForms
{
    partial class FrmTemperatura
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
            lb_Fharenheit = new Label();
            lb_fahrenheit2 = new Label();
            cantidad_F = new TextBox();
            f_f = new TextBox();
            btn_convertidor_F = new Button();
            lb_Celsius2 = new Label();
            f_c = new TextBox();
            lb_kelvin2 = new Label();
            f_k = new TextBox();
            lb_celsius1 = new Label();
            cantidad_C = new TextBox();
            btn_convertidor_C = new Button();
            c_f = new TextBox();
            c_c = new TextBox();
            c_k = new TextBox();
            lb_kelvin1 = new Label();
            cantidad__K = new TextBox();
            btn_convertidor_K = new Button();
            k_f = new TextBox();
            k_c = new TextBox();
            k_k = new TextBox();
            SuspendLayout();
            // 
            // lb_Fharenheit
            // 
            lb_Fharenheit.AutoSize = true;
            lb_Fharenheit.Location = new Point(28, 61);
            lb_Fharenheit.Name = "lb_Fharenheit";
            lb_Fharenheit.Size = new Size(78, 20);
            lb_Fharenheit.TabIndex = 0;
            lb_Fharenheit.Text = "Fharenheit";
            // 
            // lb_fahrenheit2
            // 
            lb_fahrenheit2.AutoSize = true;
            lb_fahrenheit2.Location = new Point(338, 18);
            lb_fahrenheit2.Name = "lb_fahrenheit2";
            lb_fahrenheit2.Size = new Size(78, 20);
            lb_fahrenheit2.TabIndex = 1;
            lb_fahrenheit2.Text = "Fharenheit";
            // 
            // cantidad_F
            // 
            cantidad_F.Location = new Point(122, 54);
            cantidad_F.Name = "cantidad_F";
            cantidad_F.Size = new Size(103, 27);
            cantidad_F.TabIndex = 2;
            // 
            // f_f
            // 
            f_f.Location = new Point(322, 54);
            f_f.Name = "f_f";
            f_f.ReadOnly = true;
            f_f.Size = new Size(125, 27);
            f_f.TabIndex = 3;
            // 
            // btn_convertidor_F
            // 
            btn_convertidor_F.Location = new Point(245, 52);
            btn_convertidor_F.Name = "btn_convertidor_F";
            btn_convertidor_F.Size = new Size(54, 29);
            btn_convertidor_F.TabIndex = 4;
            btn_convertidor_F.Text = "->";
            btn_convertidor_F.UseVisualStyleBackColor = true;
            btn_convertidor_F.Click += clic_btn_f;
            // 
            // lb_Celsius2
            // 
            lb_Celsius2.AutoSize = true;
            lb_Celsius2.Location = new Point(523, 18);
            lb_Celsius2.Name = "lb_Celsius2";
            lb_Celsius2.Size = new Size(54, 20);
            lb_Celsius2.TabIndex = 5;
            lb_Celsius2.Text = "Celsius";
            // 
            // f_c
            // 
            f_c.Location = new Point(488, 54);
            f_c.Name = "f_c";
            f_c.ReadOnly = true;
            f_c.Size = new Size(125, 27);
            f_c.TabIndex = 6;
            // 
            // lb_kelvin2
            // 
            lb_kelvin2.AutoSize = true;
            lb_kelvin2.Location = new Point(673, 18);
            lb_kelvin2.Name = "lb_kelvin2";
            lb_kelvin2.Size = new Size(49, 20);
            lb_kelvin2.TabIndex = 7;
            lb_kelvin2.Text = "Kelvin";
            // 
            // f_k
            // 
            f_k.Location = new Point(637, 54);
            f_k.Name = "f_k";
            f_k.ReadOnly = true;
            f_k.Size = new Size(125, 27);
            f_k.TabIndex = 8;
            // 
            // lb_celsius1
            // 
            lb_celsius1.AutoSize = true;
            lb_celsius1.Location = new Point(28, 102);
            lb_celsius1.Name = "lb_celsius1";
            lb_celsius1.Size = new Size(54, 20);
            lb_celsius1.TabIndex = 9;
            lb_celsius1.Text = "Celsius";
            // 
            // cantidad_C
            // 
            cantidad_C.Location = new Point(122, 95);
            cantidad_C.Name = "cantidad_C";
            cantidad_C.Size = new Size(103, 27);
            cantidad_C.TabIndex = 10;
            // 
            // btn_convertidor_C
            // 
            btn_convertidor_C.Location = new Point(245, 93);
            btn_convertidor_C.Name = "btn_convertidor_C";
            btn_convertidor_C.Size = new Size(54, 29);
            btn_convertidor_C.TabIndex = 11;
            btn_convertidor_C.Text = "->";
            btn_convertidor_C.UseVisualStyleBackColor = true;
            btn_convertidor_C.Click += clic_btn_c;
            // 
            // c_f
            // 
            c_f.Location = new Point(322, 99);
            c_f.Name = "c_f";
            c_f.ReadOnly = true;
            c_f.Size = new Size(125, 27);
            c_f.TabIndex = 12;
            // 
            // c_c
            // 
            c_c.Location = new Point(488, 99);
            c_c.Name = "c_c";
            c_c.ReadOnly = true;
            c_c.Size = new Size(125, 27);
            c_c.TabIndex = 13;
            // 
            // c_k
            // 
            c_k.Location = new Point(637, 99);
            c_k.Name = "c_k";
            c_k.ReadOnly = true;
            c_k.Size = new Size(125, 27);
            c_k.TabIndex = 14;
            // 
            // lb_kelvin1
            // 
            lb_kelvin1.AutoSize = true;
            lb_kelvin1.Location = new Point(28, 141);
            lb_kelvin1.Name = "lb_kelvin1";
            lb_kelvin1.Size = new Size(49, 20);
            lb_kelvin1.TabIndex = 15;
            lb_kelvin1.Text = "Kelvin";
            // 
            // cantidad__K
            // 
            cantidad__K.Location = new Point(122, 138);
            cantidad__K.Name = "cantidad__K";
            cantidad__K.Size = new Size(103, 27);
            cantidad__K.TabIndex = 16;
            // 
            // btn_convertidor_K
            // 
            btn_convertidor_K.Location = new Point(245, 136);
            btn_convertidor_K.Name = "btn_convertidor_K";
            btn_convertidor_K.Size = new Size(54, 29);
            btn_convertidor_K.TabIndex = 17;
            btn_convertidor_K.Text = "->";
            btn_convertidor_K.UseVisualStyleBackColor = true;
            btn_convertidor_K.Click += clic_btn_k;
            // 
            // k_f
            // 
            k_f.Location = new Point(322, 138);
            k_f.Name = "k_f";
            k_f.ReadOnly = true;
            k_f.Size = new Size(125, 27);
            k_f.TabIndex = 18;
            // 
            // k_c
            // 
            k_c.Location = new Point(488, 141);
            k_c.Name = "k_c";
            k_c.ReadOnly = true;
            k_c.Size = new Size(125, 27);
            k_c.TabIndex = 19;
            // 
            // k_k
            // 
            k_k.Location = new Point(637, 141);
            k_k.Name = "k_k";
            k_k.ReadOnly = true;
            k_k.Size = new Size(125, 27);
            k_k.TabIndex = 20;
            // 
            // FrmTemperatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 185);
            Controls.Add(k_k);
            Controls.Add(k_c);
            Controls.Add(k_f);
            Controls.Add(btn_convertidor_K);
            Controls.Add(cantidad__K);
            Controls.Add(lb_kelvin1);
            Controls.Add(c_k);
            Controls.Add(c_c);
            Controls.Add(c_f);
            Controls.Add(btn_convertidor_C);
            Controls.Add(cantidad_C);
            Controls.Add(lb_celsius1);
            Controls.Add(f_k);
            Controls.Add(lb_kelvin2);
            Controls.Add(f_c);
            Controls.Add(lb_Celsius2);
            Controls.Add(btn_convertidor_F);
            Controls.Add(f_f);
            Controls.Add(cantidad_F);
            Controls.Add(lb_fahrenheit2);
            Controls.Add(lb_Fharenheit);
            Name = "FrmTemperatura";
            Text = "FrmTemperatura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Fharenheit;
        private Label lb_fahrenheit2;
        private TextBox cantidad_F;
        private TextBox f_f;
        private Button btn_convertidor_F;
        private Label lb_Celsius2;
        private TextBox f_c;
        private Label lb_kelvin2;
        private TextBox f_k;
        private Label lb_celsius1;
        private TextBox cantidad_C;
        private Button btn_convertidor_C;
        private TextBox c_f;
        private TextBox c_c;
        private TextBox c_k;
        private Label lb_kelvin1;
        private TextBox cantidad__K;
        private Button btn_convertidor_K;
        private TextBox k_f;
        private TextBox k_c;
        private TextBox k_k;
    }
}