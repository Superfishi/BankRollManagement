using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace BankrollApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //(Bankroll*%loose)/((entry-sl)/entry)

            try
            {
                decimal bankroll = decimal.Parse(txtBankroll.Text);
                decimal maxLoosePerc = decimal.Parse(txtLooseMaxPerc.Text);
                decimal feesPerc = decimal.Parse(txtFeesPerc.Text);
                decimal entryLevel = decimal.Parse(TxtEntryLevel.Text);
                decimal stopLossLevel = decimal.Parse(txtStopLossLevel.Text);
                decimal slippage = decimal.Parse(txtSlippage.Text);
                decimal positionSize = decimal.Parse(txtPositonSize2.Text);
                decimal stopLossInclSlippage = GetStopLossInclSlipage(entryLevel, stopLossLevel, slippage);

                // calculate max position size exclude fees
                decimal maxPositionSizeExclFees = (bankroll * (maxLoosePerc / 100)) / ((entryLevel - (stopLossInclSlippage)) / entryLevel);

                // include fees
                decimal maxPositionSize = maxPositionSizeExclFees - (maxPositionSizeExclFees * (feesPerc / 100));
                
                lblMaxTradeSize.Text = Abs(maxPositionSize).ToString("#");

                // calculate risk
                decimal risk = (positionSize * ((entryLevel - stopLossInclSlippage) / entryLevel)) / bankroll * 100;

                lblRiskPerc2.Text = Abs(risk).ToString("0.##");

                lblError.Visible = false;
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "Enter a correct entry and stop loss level";
            }

        }

        decimal GetStopLossInclSlipage(decimal entryLevel, decimal stopLossLevel, decimal slippage)
        {
            bool longTrade = entryLevel > stopLossLevel ? true : false;
            int count = BitConverter.GetBytes(decimal.GetBits(entryLevel)[3])[2];

            if (count == 0)
            {
                // do nothing
            }
            else if (count == 1)
            {
                slippage = slippage / 10;
            }
            else if (count == 2)
            {
                slippage = slippage / 100;
            }
            else if (count == 3)
            {
                slippage = slippage / 1000;
            }
            else if (count == 4)
            {
                slippage = slippage / 100000;
            }
            else if (count == 5)
            {
                slippage = slippage / 10000;
            }
            decimal stopLossInclSlippage = longTrade ? (stopLossLevel - slippage) : (stopLossLevel + slippage);


            return stopLossInclSlippage;
        }

    }
}
