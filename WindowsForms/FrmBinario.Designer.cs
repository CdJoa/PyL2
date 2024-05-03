namespace WindowsForms
{
    partial class FrmBinario
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
            lb_bd = new Label();
            label1 = new Label();
            cantidad_decimal = new TextBox();
            cantidad_binario = new TextBox();
            btn_Binario_a_Decimal = new Button();
            btn_Decimal_a_Binario = new Button();
            txtDecimal = new TextBox();
            txtBinario = new TextBox();
            SuspendLayout();
            // 
            // lb_bd
            // 
            lb_bd.AutoSize = true;
            lb_bd.Location = new Point(50, 22);
            lb_bd.Name = "lb_bd";
            lb_bd.Size = new Size(127, 20);
            lb_bd.TabIndex = 0;
            lb_bd.Text = "Binario a Decimal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 84);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Decimal a Binario";
            // 
            // cantidad_decimal
            // 
            cantidad_decimal.Location = new Point(221, 81);
            cantidad_decimal.Name = "cantidad_decimal";
            cantidad_decimal.Size = new Size(125, 27);
            cantidad_decimal.TabIndex = 2;
            // 
            // cantidad_binario
            // 
            cantidad_binario.Location = new Point(221, 15);
            cantidad_binario.Name = "cantidad_binario";
            cantidad_binario.Size = new Size(125, 27);
            cantidad_binario.TabIndex = 3;
            // 
            // btn_Binario_a_Decimal
            // 
            btn_Binario_a_Decimal.Location = new Point(361, 13);
            btn_Binario_a_Decimal.Name = "btn_Binario_a_Decimal";
            btn_Binario_a_Decimal.Size = new Size(48, 29);
            btn_Binario_a_Decimal.TabIndex = 4;
            btn_Binario_a_Decimal.Text = "->";
            btn_Binario_a_Decimal.UseVisualStyleBackColor = true;
            btn_Binario_a_Decimal.Click += btn_Binario_a_Decimal_Click;
            // 
            // btn_Decimal_a_Binario
            // 
            btn_Decimal_a_Binario.Location = new Point(361, 79);
            btn_Decimal_a_Binario.Name = "btn_Decimal_a_Binario";
            btn_Decimal_a_Binario.Size = new Size(48, 29);
            btn_Decimal_a_Binario.TabIndex = 5;
            btn_Decimal_a_Binario.Text = "->";
            btn_Decimal_a_Binario.UseVisualStyleBackColor = true;
            btn_Decimal_a_Binario.Click += btn_Decimal_a_Binario_Click;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(438, 15);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.ReadOnly = true;
            txtDecimal.Size = new Size(125, 27);
            txtDecimal.TabIndex = 6;
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(438, 80);
            txtBinario.Name = "txtBinario";
            txtBinario.ReadOnly = true;
            txtBinario.Size = new Size(125, 27);
            txtBinario.TabIndex = 7;
            // 
            // FrmBinario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 135);
            Controls.Add(txtBinario);
            Controls.Add(txtDecimal);
            Controls.Add(btn_Decimal_a_Binario);
            Controls.Add(btn_Binario_a_Decimal);
            Controls.Add(cantidad_binario);
            Controls.Add(cantidad_decimal);
            Controls.Add(label1);
            Controls.Add(lb_bd);
            Name = "FrmBinario";
            Text = "FrmBinario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_bd;
        private Label label1;
        private TextBox cantidad_decimal;
        private TextBox cantidad_binario;
        private Button btn_Binario_a_Decimal;
        private Button btn_Decimal_a_Binario;
        private TextBox txtDecimal;
        private TextBox txtBinario;
    }
}