namespace WindowsForms
{
    partial class FrmContarPalabras
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
            richContarPalabras = new RichTextBox();
            btn_calcular = new Button();
            SuspendLayout();
            // 
            // richContarPalabras
            // 
            richContarPalabras.Location = new Point(3, 12);
            richContarPalabras.Name = "richContarPalabras";
            richContarPalabras.Size = new Size(492, 388);
            richContarPalabras.TabIndex = 0;
            richContarPalabras.Text = "";
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(341, 409);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(94, 29);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // FrmContarPalabras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(btn_calcular);
            Controls.Add(richContarPalabras);
            Name = "FrmContarPalabras";
            Text = "FrmContarPalabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richContarPalabras;
        private Button btn_calcular;
    }
}