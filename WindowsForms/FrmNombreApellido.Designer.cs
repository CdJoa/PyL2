namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            label2 = new Label();
            Apellido = new Label();
            Saludador = new Button();
            lb_Nombre = new TextBox();
            lb_Apellido = new TextBox();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nombre.ImageAlign = ContentAlignment.BottomLeft;
            Nombre.Location = new Point(94, 33);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(93, 28);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(478, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Apellido.Location = new Point(478, 33);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(95, 28);
            Apellido.TabIndex = 4;
            Apellido.Text = "Apellido";
            // 
            // Saludador
            // 
            Saludador.Location = new Point(372, 218);
            Saludador.Name = "Saludador";
            Saludador.Size = new Size(379, 33);
            Saludador.TabIndex = 5;
            Saludador.Text = "Saludar";
            Saludador.UseVisualStyleBackColor = true;
            Saludador.Click += button3_Click;
            // 
            // lb_Nombre
            // 
            lb_Nombre.Location = new Point(94, 109);
            lb_Nombre.Name = "lb_Nombre";
            lb_Nombre.PlaceholderText = "Ingrese Nombre";
            lb_Nombre.Size = new Size(280, 27);
            lb_Nombre.TabIndex = 6;
            lb_Nombre.Tag = "";
            // 
            // lb_Apellido
            // 
            lb_Apellido.Location = new Point(478, 109);
            lb_Apellido.Name = "lb_Apellido";
            lb_Apellido.PlaceholderText = "Ingrese Apellido";
            lb_Apellido.Size = new Size(280, 27);
            lb_Apellido.TabIndex = 7;
            lb_Apellido.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(lb_Apellido);
            Controls.Add(lb_Nombre);
            Controls.Add(Saludador);
            Controls.Add(Apellido);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "¡Hola, Windows Forms!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Nombre;
        private Label label2;
        private Label Apellido;
        private Button Saludador;
        private TextBox lb_Nombre;
        private TextBox lb_Apellido;




    }
}
