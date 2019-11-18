namespace DollarEuroApp
{
    partial class ExchangeRate
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEuroDollarRate = new System.Windows.Forms.TextBox();
            this.txtDollar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDollarToEuro = new System.Windows.Forms.Button();
            this.btnEuroToDollar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koers From - To";
            // 
            // txtEuroDollarRate
            // 
            this.txtEuroDollarRate.Location = new System.Drawing.Point(93, 25);
            this.txtEuroDollarRate.Name = "txtEuroDollarRate";
            this.txtEuroDollarRate.Size = new System.Drawing.Size(56, 20);
            this.txtEuroDollarRate.TabIndex = 1;
            this.txtEuroDollarRate.Text = "1.1152";
            // 
            // txtDollar
            // 
            this.txtDollar.Location = new System.Drawing.Point(333, 91);
            this.txtDollar.Name = "txtDollar";
            this.txtDollar.Size = new System.Drawing.Size(100, 20);
            this.txtDollar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(33, 91);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // btnDollarToEuro
            // 
            this.btnDollarToEuro.Location = new System.Drawing.Point(168, 113);
            this.btnDollarToEuro.Name = "btnDollarToEuro";
            this.btnDollarToEuro.Size = new System.Drawing.Size(75, 23);
            this.btnDollarToEuro.TabIndex = 6;
            this.btnDollarToEuro.Text = "<<";
            this.btnDollarToEuro.UseVisualStyleBackColor = true;
            this.btnDollarToEuro.Click += new System.EventHandler(this.btnDollarToEuro_Click);
            // 
            // btnEuroToDollar
            // 
            this.btnEuroToDollar.Location = new System.Drawing.Point(168, 84);
            this.btnEuroToDollar.Name = "btnEuroToDollar";
            this.btnEuroToDollar.Size = new System.Drawing.Size(75, 23);
            this.btnEuroToDollar.TabIndex = 7;
            this.btnEuroToDollar.Text = ">>";
            this.btnEuroToDollar.UseVisualStyleBackColor = true;
            this.btnEuroToDollar.Click += new System.EventHandler(this.btnEuroToDollar_Click);
            // 
            // ExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.btnEuroToDollar);
            this.Controls.Add(this.btnDollarToEuro);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEuroDollarRate);
            this.Controls.Add(this.label1);
            this.Name = "ExchangeRate";
            this.Text = "DollarEuro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEuroDollarRate;
        private System.Windows.Forms.TextBox txtDollar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDollarToEuro;
        private System.Windows.Forms.Button btnEuroToDollar;
    }
}

