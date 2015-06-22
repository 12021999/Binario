namespace CalculadoraBinária
{
    partial class calculadoraBinaria
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
            this.BinarioLabel = new System.Windows.Forms.Label();
            this.BinarioText = new System.Windows.Forms.TextBox();
            this.DecimalLabel = new System.Windows.Forms.Label();
            this.DecimalText = new System.Windows.Forms.TextBox();
            this.HexadecimalLabel = new System.Windows.Forms.Label();
            this.HexadecimalText = new System.Windows.Forms.TextBox();
            this.Zero = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BinarioLabel
            // 
            this.BinarioLabel.AutoSize = true;
            this.BinarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.BinarioLabel.Location = new System.Drawing.Point(525, 9);
            this.BinarioLabel.Name = "BinarioLabel";
            this.BinarioLabel.Size = new System.Drawing.Size(124, 39);
            this.BinarioLabel.TabIndex = 0;
            this.BinarioLabel.Text = "Binário";
            // 
            // BinarioText
            // 
            this.BinarioText.Location = new System.Drawing.Point(12, 51);
            this.BinarioText.Name = "BinarioText";
            this.BinarioText.ReadOnly = true;
            this.BinarioText.Size = new System.Drawing.Size(628, 20);
            this.BinarioText.TabIndex = 1;
            this.BinarioText.TextChanged += new System.EventHandler(this.Binario);
            // 
            // DecimalLabel
            // 
            this.DecimalLabel.AutoSize = true;
            this.DecimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DecimalLabel.Location = new System.Drawing.Point(508, 83);
            this.DecimalLabel.Name = "DecimalLabel";
            this.DecimalLabel.Size = new System.Drawing.Size(141, 39);
            this.DecimalLabel.TabIndex = 2;
            this.DecimalLabel.Text = "Decimal";
            // 
            // DecimalText
            // 
            this.DecimalText.Location = new System.Drawing.Point(12, 135);
            this.DecimalText.Name = "DecimalText";
            this.DecimalText.ReadOnly = true;
            this.DecimalText.Size = new System.Drawing.Size(628, 20);
            this.DecimalText.TabIndex = 3;
            // 
            // HexadecimalLabel
            // 
            this.HexadecimalLabel.AutoSize = true;
            this.HexadecimalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.HexadecimalLabel.Location = new System.Drawing.Point(428, 173);
            this.HexadecimalLabel.Name = "HexadecimalLabel";
            this.HexadecimalLabel.Size = new System.Drawing.Size(221, 39);
            this.HexadecimalLabel.TabIndex = 4;
            this.HexadecimalLabel.Text = "HexaDecimal";
            // 
            // HexadecimalText
            // 
            this.HexadecimalText.Location = new System.Drawing.Point(12, 226);
            this.HexadecimalText.Name = "HexadecimalText";
            this.HexadecimalText.ReadOnly = true;
            this.HexadecimalText.Size = new System.Drawing.Size(628, 20);
            this.HexadecimalText.TabIndex = 5;
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Zero.Location = new System.Drawing.Point(12, 270);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(129, 98);
            this.Zero.TabIndex = 6;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.AddZero);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.One.Location = new System.Drawing.Point(180, 270);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(129, 98);
            this.One.TabIndex = 7;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.AddOne);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Plus.Location = new System.Drawing.Point(349, 270);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(129, 98);
            this.Plus.TabIndex = 8;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Minus.Location = new System.Drawing.Point(512, 270);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(129, 98);
            this.Minus.TabIndex = 9;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // calculadoraBinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 380);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.HexadecimalText);
            this.Controls.Add(this.HexadecimalLabel);
            this.Controls.Add(this.DecimalText);
            this.Controls.Add(this.DecimalLabel);
            this.Controls.Add(this.BinarioText);
            this.Controls.Add(this.BinarioLabel);
            this.Name = "calculadoraBinaria";
            this.Text = "Calculadora Binária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinarioLabel;
        private System.Windows.Forms.TextBox BinarioText;
        private System.Windows.Forms.Label DecimalLabel;
        private System.Windows.Forms.TextBox DecimalText;
        private System.Windows.Forms.Label HexadecimalLabel;
        private System.Windows.Forms.TextBox HexadecimalText;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
    }
}

