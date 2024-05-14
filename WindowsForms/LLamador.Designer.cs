namespace WindowsForms
{
    partial class LLamador
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
            txtBoxDestino = new TextBox();
            SuspendLayout();
            // 
            // txtBoxDestino
            // 
            txtBoxDestino.Location = new Point(48, 29);
            txtBoxDestino.Name = "txtBoxDestino";
            txtBoxDestino.Size = new Size(326, 27);
            txtBoxDestino.TabIndex = 0;
            // 
            // LLamador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxDestino);
            Name = "LLamador";
            Text = "LLamador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxDestino;
    }
}