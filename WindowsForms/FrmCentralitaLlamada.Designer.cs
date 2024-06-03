namespace WindowsForms
{
    partial class FrmCentralitaLlamada
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
            txtNroDestino = new TextBox();
            groupBox1 = new GroupBox();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            buttonHash = new Button();
            buttonasterisco = new Button();
            button0 = new Button();
            txtNroOrigen = new TextBox();
            btnLLamar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNroDestino
            // 
            txtNroDestino.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNroDestino.Location = new Point(77, 12);
            txtNroDestino.Name = "txtNroDestino";
            txtNroDestino.PlaceholderText = "Nro Destino";
            txtNroDestino.ReadOnly = true;
            txtNroDestino.Size = new Size(323, 43);
            txtNroDestino.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonHash);
            groupBox1.Controls.Add(buttonasterisco);
            groupBox1.Controls.Add(button0);
            groupBox1.Location = new Point(77, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 328);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Panel";
            // 
            // button9
            // 
            button9.Location = new Point(235, 37);
            button9.Name = "button9";
            button9.Size = new Size(73, 50);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(128, 37);
            button8.Name = "button8";
            button8.Size = new Size(73, 50);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(25, 37);
            button7.Name = "button7";
            button7.Size = new Size(73, 50);
            button7.TabIndex = 5;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(235, 113);
            button6.Name = "button6";
            button6.Size = new Size(73, 50);
            button6.TabIndex = 8;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(128, 113);
            button5.Name = "button5";
            button5.Size = new Size(73, 50);
            button5.TabIndex = 7;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(25, 113);
            button4.Name = "button4";
            button4.Size = new Size(73, 50);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(235, 187);
            button3.Name = "button3";
            button3.Size = new Size(73, 50);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 187);
            button2.Name = "button2";
            button2.Size = new Size(73, 50);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 187);
            button1.Name = "button1";
            button1.Size = new Size(73, 50);
            button1.TabIndex = 3;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonHash
            // 
            buttonHash.Location = new Point(235, 263);
            buttonHash.Name = "buttonHash";
            buttonHash.RightToLeft = RightToLeft.No;
            buttonHash.Size = new Size(73, 50);
            buttonHash.TabIndex = 2;
            buttonHash.Text = "#";
            buttonHash.UseVisualStyleBackColor = true;
            buttonHash.Click += buttonHash_Click;
            // 
            // buttonasterisco
            // 
            buttonasterisco.Location = new Point(25, 263);
            buttonasterisco.Name = "buttonasterisco";
            buttonasterisco.Size = new Size(73, 50);
            buttonasterisco.TabIndex = 1;
            buttonasterisco.Text = "*";
            buttonasterisco.UseVisualStyleBackColor = true;
            buttonasterisco.Click += buttonasterisco_Click;
            // 
            // button0
            // 
            button0.Location = new Point(128, 263);
            button0.Name = "button0";
            button0.Size = new Size(73, 50);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += boton0_Click;
            // 
            // txtNroOrigen
            // 
            txtNroOrigen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNroOrigen.Location = new Point(453, 255);
            txtNroOrigen.Name = "txtNroOrigen";
            txtNroOrigen.PlaceholderText = "Nro Origen";
            txtNroOrigen.ReadOnly = true;
            txtNroOrigen.Size = new Size(323, 43);
            txtNroOrigen.TabIndex = 3;
            // 
            // btnLLamar
            // 
            btnLLamar.Location = new Point(453, 99);
            btnLLamar.Name = "btnLLamar";
            btnLLamar.Size = new Size(323, 49);
            btnLLamar.TabIndex = 4;
            btnLLamar.Text = "LLamar";
            btnLLamar.UseVisualStyleBackColor = true;
            btnLLamar.Click += btnLLamar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(453, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(323, 49);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(453, 325);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(323, 49);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Franja_1", "Franja_2", "Franja_3" });
            comboBox1.Location = new Point(102, 395);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Franja";
            // 
            // FrmCentralitaLlamada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLLamar);
            Controls.Add(txtNroOrigen);
            Controls.Add(groupBox1);
            Controls.Add(txtNroDestino);
            Name = "FrmCentralitaLlamada";
            Text = "FrmCentralitaLlamada";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNroDestino;
        private GroupBox groupBox1;
        private Button button0;
        private Button buttonasterisco;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonHash;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private TextBox txtNroOrigen;
        private Button btnLLamar;
        private Button btnLimpiar;
        private Button btnSalir;
        private ComboBox comboBox1;
    }
}