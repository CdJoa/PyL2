namespace WindowsForms
{
    partial class FrmAtrapameSiPuedes
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
            lbKM = new Label();
            lbLitros = new Label();
            txtKM = new TextBox();
            txtLitros = new TextBox();
            btnCalcularAtrapame = new Button();
            RichAtrapame = new RichTextBox();
            SuspendLayout();
            // 
            // lbKM
            // 
            lbKM.AutoSize = true;
            lbKM.Location = new Point(72, 9);
            lbKM.Name = "lbKM";
            lbKM.Size = new Size(81, 20);
            lbKM.TabIndex = 0;
            lbKM.Text = "Kilometros";
            // 
            // lbLitros
            // 
            lbLitros.AutoSize = true;
            lbLitros.Location = new Point(72, 106);
            lbLitros.Name = "lbLitros";
            lbLitros.Size = new Size(45, 20);
            lbLitros.TabIndex = 1;
            lbLitros.Text = "Litros";
            // 
            // txtKM
            // 
            txtKM.Location = new Point(72, 55);
            txtKM.Name = "txtKM";
            txtKM.Size = new Size(125, 27);
            txtKM.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(72, 150);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(125, 27);
            txtLitros.TabIndex = 3;
            // 
            // btnCalcularAtrapame
            // 
            btnCalcularAtrapame.Location = new Point(72, 204);
            btnCalcularAtrapame.Name = "btnCalcularAtrapame";
            btnCalcularAtrapame.Size = new Size(94, 29);
            btnCalcularAtrapame.TabIndex = 4;
            btnCalcularAtrapame.Text = "Calcular";
            btnCalcularAtrapame.UseVisualStyleBackColor = true;
            btnCalcularAtrapame.Click += btnCalcularAtrapame_Click;
            // 
            // RichAtrapame
            // 
            RichAtrapame.Location = new Point(289, 21);
            RichAtrapame.Name = "RichAtrapame";
            RichAtrapame.ReadOnly = true;
            RichAtrapame.Size = new Size(262, 233);
            RichAtrapame.TabIndex = 5;
            RichAtrapame.Text = "";
            // 
            // FrmAtrapameSiPuedes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 282);
            Controls.Add(RichAtrapame);
            Controls.Add(btnCalcularAtrapame);
            Controls.Add(txtLitros);
            Controls.Add(txtKM);
            Controls.Add(lbLitros);
            Controls.Add(lbKM);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAtrapameSiPuedes";
            Text = "FrmAtrapameSiPuedes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKM;
        private Label lbLitros;
        private TextBox txtKM;
        private TextBox txtLitros;
        private Button btnCalcularAtrapame;
        private RichTextBox RichAtrapame;
    }
}