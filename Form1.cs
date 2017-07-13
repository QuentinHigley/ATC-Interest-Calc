using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            const decimal decInterest = .005m;
            decimal decBalance;
            int intMonths;
            int X = 1;
            if (decimal.TryParse(txtStarting.Text, out decBalance))
            {
                if (int.TryParse(txtMonths.Text, out intMonths))
                {
                    while (X <= intMonths)
                    {
                        decBalance += (decInterest * decBalance);
                        lstOut.Items.Add("The Ending Balance For Month " + X + " is " + decBalance.ToString("c"));
                        X++;
                    }
                    lblOutput.Text = "Ending Balance:" + decBalance.ToString("c");
                }
                else {
                    MessageBox.Show("Invalid value for months.");
                }
            }
            else {
                MessageBox.Show("Invalid Value for Starting Balance");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMonths.Text = "";
            txtStarting.Text = "";
            lstOut.Items.Clear();
            lblOutput.Text = "Ending Balance";
            txtStarting.Focus(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
