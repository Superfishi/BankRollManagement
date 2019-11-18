using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarEuroApp
{
    public partial class ExchangeRate : Form
    {
        public ExchangeRate()
        {
            InitializeComponent();
        }

        private void btnDollarToEuro_Click(object sender, EventArgs e)
        {
            double euroDollarRate = Double.Parse(txtEuroDollarRate.Text);
            double dollar = Double.Parse(txtDollar.Text);

            double euro = dollar / euroDollarRate;
            txtEuro.Text = euro.ToString("#.##");
        }

        private void btnEuroToDollar_Click(object sender, EventArgs e)
        {
            double euroDollarRate = Double.Parse(txtEuroDollarRate.Text);
            double euro = Double.Parse(txtEuro.Text);

            double dollar = euro * euroDollarRate;
            txtDollar.Text = dollar.ToString("#.##");
        }

    }
}
