namespace WindowsForms
{
    partial class IngresanteRegistro
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
            groupBox1 = new GroupBox();
            lb_edad = new NumericUpDown();
            lb_direccion = new TextBox();
            lb_nombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            group_genero = new GroupBox();
            radio_no_binario = new RadioButton();
            radio_femenino = new RadioButton();
            radio_Masculino = new RadioButton();
            group_cursos = new GroupBox();
            ch_javascript = new CheckBox();
            ch_c_mas_mas = new CheckBox();
            ch_csharp = new CheckBox();
            lista_paises = new ListBox();
            label_paises = new Label();
            btn_ingreso = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lb_edad).BeginInit();
            group_genero.SuspendLayout();
            group_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_edad);
            groupBox1.Controls.Add(lb_direccion);
            groupBox1.Controls.Add(lb_nombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 174);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles del Usuario";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lb_edad
            // 
            lb_edad.Location = new Point(108, 137);
            lb_edad.Name = "lb_edad";
            lb_edad.Size = new Size(79, 27);
            lb_edad.TabIndex = 5;
            lb_edad.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lb_direccion
            // 
            lb_direccion.Location = new Point(108, 85);
            lb_direccion.Name = "lb_direccion";
            lb_direccion.PlaceholderText = "Ingrese Dirección";
            lb_direccion.Size = new Size(125, 27);
            lb_direccion.TabIndex = 4;
            // 
            // lb_nombre
            // 
            lb_nombre.Location = new Point(108, 35);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.PlaceholderText = "Ingrese Nombre";
            lb_nombre.Size = new Size(125, 27);
            lb_nombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 137);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // group_genero
            // 
            group_genero.Controls.Add(radio_no_binario);
            group_genero.Controls.Add(radio_femenino);
            group_genero.Controls.Add(radio_Masculino);
            group_genero.Location = new Point(362, 29);
            group_genero.Name = "group_genero";
            group_genero.Size = new Size(161, 174);
            group_genero.TabIndex = 2;
            group_genero.TabStop = false;
            group_genero.Text = "Género";
            // 
            // radio_no_binario
            // 
            radio_no_binario.AutoSize = true;
            radio_no_binario.Location = new Point(25, 133);
            radio_no_binario.Name = "radio_no_binario";
            radio_no_binario.Size = new Size(101, 24);
            radio_no_binario.TabIndex = 2;
            radio_no_binario.TabStop = true;
            radio_no_binario.Text = "No Binario";
            radio_no_binario.UseVisualStyleBackColor = true;
            // 
            // radio_femenino
            // 
            radio_femenino.AutoSize = true;
            radio_femenino.Location = new Point(25, 81);
            radio_femenino.Name = "radio_femenino";
            radio_femenino.Size = new Size(95, 24);
            radio_femenino.TabIndex = 1;
            radio_femenino.TabStop = true;
            radio_femenino.Text = "Femenino";
            radio_femenino.UseVisualStyleBackColor = true;
            // 
            // radio_Masculino
            // 
            radio_Masculino.AutoSize = true;
            radio_Masculino.Location = new Point(25, 35);
            radio_Masculino.Name = "radio_Masculino";
            radio_Masculino.Size = new Size(97, 24);
            radio_Masculino.TabIndex = 0;
            radio_Masculino.TabStop = true;
            radio_Masculino.Text = "Masculino";
            radio_Masculino.UseVisualStyleBackColor = true;
            // 
            // group_cursos
            // 
            group_cursos.Controls.Add(ch_javascript);
            group_cursos.Controls.Add(ch_c_mas_mas);
            group_cursos.Controls.Add(ch_csharp);
            group_cursos.Location = new Point(362, 237);
            group_cursos.Name = "group_cursos";
            group_cursos.Size = new Size(150, 185);
            group_cursos.TabIndex = 3;
            group_cursos.TabStop = false;
            group_cursos.Text = "Cursos";
            // 
            // ch_javascript
            // 
            ch_javascript.AutoSize = true;
            ch_javascript.Location = new Point(21, 137);
            ch_javascript.Name = "ch_javascript";
            ch_javascript.Size = new Size(97, 24);
            ch_javascript.TabIndex = 2;
            ch_javascript.Text = "JavaScript";
            ch_javascript.UseVisualStyleBackColor = true;
            // 
            // ch_c_mas_mas
            // 
            ch_c_mas_mas.AutoSize = true;
            ch_c_mas_mas.Location = new Point(21, 94);
            ch_c_mas_mas.Name = "ch_c_mas_mas";
            ch_c_mas_mas.Size = new Size(60, 24);
            ch_c_mas_mas.TabIndex = 1;
            ch_c_mas_mas.Text = "C++";
            ch_c_mas_mas.UseVisualStyleBackColor = true;
            // 
            // ch_csharp
            // 
            ch_csharp.AutoSize = true;
            ch_csharp.Location = new Point(21, 47);
            ch_csharp.Name = "ch_csharp";
            ch_csharp.Size = new Size(49, 24);
            ch_csharp.TabIndex = 0;
            ch_csharp.Text = "C#";
            ch_csharp.UseVisualStyleBackColor = true;
            // 
            // lista_paises
            // 
            lista_paises.FormattingEnabled = true;
            lista_paises.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lista_paises.Location = new Point(30, 269);
            lista_paises.Name = "lista_paises";
            lista_paises.Size = new Size(230, 144);
            lista_paises.TabIndex = 4;
            // 
            // label_paises
            // 
            label_paises.AutoSize = true;
            label_paises.Location = new Point(27, 237);
            label_paises.Name = "label_paises";
            label_paises.Size = new Size(48, 20);
            label_paises.TabIndex = 5;
            label_paises.Text = "Países";
            // 
            // btn_ingreso
            // 
            btn_ingreso.Location = new Point(216, 442);
            btn_ingreso.Name = "btn_ingreso";
            btn_ingreso.Size = new Size(164, 29);
            btn_ingreso.TabIndex = 6;
            btn_ingreso.Text = "Ingresar";
            btn_ingreso.UseVisualStyleBackColor = true;
            btn_ingreso.Click += boton_ingresar;
            // 
            // IngresanteRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 511);
            Controls.Add(btn_ingreso);
            Controls.Add(label_paises);
            Controls.Add(lista_paises);
            Controls.Add(group_cursos);
            Controls.Add(group_genero);
            Controls.Add(groupBox1);
            Name = "IngresanteRegistro";
            Text = "IngresanteRegistro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lb_edad).EndInit();
            group_genero.ResumeLayout(false);
            group_genero.PerformLayout();
            group_cursos.ResumeLayout(false);
            group_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox lb_direccion;
        private TextBox lb_nombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown lb_edad;
        private GroupBox group_genero;
        private RadioButton radio_no_binario;
        private RadioButton radio_femenino;
        private RadioButton radio_Masculino;
        private GroupBox group_cursos;
        private CheckBox ch_csharp;
        private CheckBox ch_javascript;
        private CheckBox ch_c_mas_mas;
        private ListBox lista_paises;
        private Label label_paises;
        private Button btn_ingreso;
    }
}