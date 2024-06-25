namespace WindowsForms
{
    partial class FrmRelojero
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
            richTextBox1 = new RichTextBox();
            lblHora = new Label();
            btnActivar = new Button();
            btnDesactivar = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(58, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(666, 309);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(108, 24);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 20);
            lblHora.TabIndex = 1;
            lblHora.Text = "label1";
            // 
            // btnActivar
            // 
            btnActivar.Location = new Point(260, 38);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(94, 29);
            btnActivar.TabIndex = 2;
            btnActivar.Text = "activar reloj";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(379, 38);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(94, 29);
            btnDesactivar.TabIndex = 3;
            btnDesactivar.Text = "desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // FrmRelojero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDesactivar);
            Controls.Add(btnActivar);
            Controls.Add(lblHora);
            Controls.Add(richTextBox1);
            Name = "FrmRelojero";
            Text = "Relojero";
            Load += Relojero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label lblHora;
        private Button btnActivar;
        private Button btnDesactivar;
    }
}