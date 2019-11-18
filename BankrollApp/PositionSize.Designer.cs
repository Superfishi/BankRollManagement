namespace BankrollApp
{
	partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankroll = new System.Windows.Forms.TextBox();
            this.TxtEntryLevel = new System.Windows.Forms.TextBox();
            this.txtLooseMaxPerc = new System.Windows.Forms.TextBox();
            this.txtStopLossLevel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblRiskPerc2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSlippage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFeesPerc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultCurrency = new System.Windows.Forms.Label();
            this.lblMaxTradeSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPositonSize2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankroll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loose % max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entry level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop loss level";
            // 
            // txtBankroll
            // 
            this.txtBankroll.Location = new System.Drawing.Point(104, 31);
            this.txtBankroll.Name = "txtBankroll";
            this.txtBankroll.Size = new System.Drawing.Size(100, 20);
            this.txtBankroll.TabIndex = 5;
            this.txtBankroll.Text = "10000";
            // 
            // TxtEntryLevel
            // 
            this.TxtEntryLevel.Location = new System.Drawing.Point(104, 144);
            this.TxtEntryLevel.Name = "TxtEntryLevel";
            this.TxtEntryLevel.Size = new System.Drawing.Size(100, 20);
            this.TxtEntryLevel.TabIndex = 1;
            // 
            // txtLooseMaxPerc
            // 
            this.txtLooseMaxPerc.Location = new System.Drawing.Point(104, 109);
            this.txtLooseMaxPerc.Name = "txtLooseMaxPerc";
            this.txtLooseMaxPerc.Size = new System.Drawing.Size(55, 20);
            this.txtLooseMaxPerc.TabIndex = 7;
            this.txtLooseMaxPerc.Text = "2";
            // 
            // txtStopLossLevel
            // 
            this.txtStopLossLevel.Location = new System.Drawing.Point(104, 169);
            this.txtStopLossLevel.Name = "txtStopLossLevel";
            this.txtStopLossLevel.Size = new System.Drawing.Size(100, 20);
            this.txtStopLossLevel.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Euro";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 247);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(238, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "%";
            // 
            // lblRiskPerc2
            // 
            this.lblRiskPerc2.AutoSize = true;
            this.lblRiskPerc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskPerc2.Location = new System.Drawing.Point(168, 322);
            this.lblRiskPerc2.Name = "lblRiskPerc2";
            this.lblRiskPerc2.Size = new System.Drawing.Size(19, 20);
            this.lblRiskPerc2.TabIndex = 46;
            this.lblRiskPerc2.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(19, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 45;
            this.label16.Tag = "";
            this.label16.Text = "Risk:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Pips";
            // 
            // txtSlippage
            // 
            this.txtSlippage.Location = new System.Drawing.Point(104, 83);
            this.txtSlippage.Name = "txtSlippage";
            this.txtSlippage.Size = new System.Drawing.Size(100, 20);
            this.txtSlippage.TabIndex = 28;
            this.txtSlippage.Text = "8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Slippage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "%";
            // 
            // txtFeesPerc
            // 
            this.txtFeesPerc.Location = new System.Drawing.Point(104, 57);
            this.txtFeesPerc.Name = "txtFeesPerc";
            this.txtFeesPerc.Size = new System.Drawing.Size(100, 20);
            this.txtFeesPerc.TabIndex = 25;
            this.txtFeesPerc.Text = "0.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fees %";
            // 
            // txtResultCurrency
            // 
            this.txtResultCurrency.AutoSize = true;
            this.txtResultCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtResultCurrency.Location = new System.Drawing.Point(238, 302);
            this.txtResultCurrency.Name = "txtResultCurrency";
            this.txtResultCurrency.Size = new System.Drawing.Size(47, 20);
            this.txtResultCurrency.TabIndex = 33;
            this.txtResultCurrency.Text = "Euro";
            // 
            // lblMaxTradeSize
            // 
            this.lblMaxTradeSize.AutoSize = true;
            this.lblMaxTradeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTradeSize.Location = new System.Drawing.Point(168, 302);
            this.lblMaxTradeSize.Name = "lblMaxTradeSize";
            this.lblMaxTradeSize.Size = new System.Drawing.Size(19, 20);
            this.lblMaxTradeSize.TabIndex = 32;
            this.lblMaxTradeSize.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Max position size:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Position size";
            // 
            // txtPositonSize2
            // 
            this.txtPositonSize2.Location = new System.Drawing.Point(104, 202);
            this.txtPositonSize2.Name = "txtPositonSize2";
            this.txtPositonSize2.Size = new System.Drawing.Size(83, 20);
            this.txtPositonSize2.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(224, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Euro";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(19, 383);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 55;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 412);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPositonSize2);
            this.Controls.Add(this.lblRiskPerc2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtResultCurrency);
            this.Controls.Add(this.lblMaxTradeSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSlippage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFeesPerc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLooseMaxPerc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBankroll);
            this.Controls.Add(this.TxtEntryLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStopLossLevel);
            this.Controls.Add(this.label4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bankroll Application";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBankroll;
		private System.Windows.Forms.TextBox TxtEntryLevel;
		private System.Windows.Forms.TextBox txtLooseMaxPerc;
		private System.Windows.Forms.TextBox txtStopLossLevel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRiskPerc2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSlippage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFeesPerc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtResultCurrency;
        private System.Windows.Forms.Label lblMaxTradeSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPositonSize2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblError;
    }
}

