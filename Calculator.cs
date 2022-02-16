using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtruderEstepsCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

            tabControl1.SelectedTab = tabPage1;
            this.Focus();
            this.ActiveControl = label1;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.txtcurrent.KeyPress += this.tbs_KeyPress;
            this.txtmeasured.KeyPress += this.tbs_KeyPress;
            this.txtnew.KeyPress += this.tbs_KeyPress;
            this.txtreal.KeyPress += this.tbs_KeyPress;

            this.txtwall1a.KeyPress += this.tbs_KeyPress;
            this.txtwall1b.KeyPress += this.tbs_KeyPress;
            this.txtwall2a.KeyPress += this.tbs_KeyPress;
            this.txtwall2b.KeyPress += this.tbs_KeyPress;
            this.txtwall3a.KeyPress += this.tbs_KeyPress;
            this.txtwall3b.KeyPress += this.tbs_KeyPress;
            this.txtwall4a.KeyPress += this.tbs_KeyPress;
            this.txtwall4b.KeyPress += this.tbs_KeyPress;
            this.txtwallThickness.KeyPress += this.tbs_KeyPress;
        }

        public void CurrentRemoveText(object sender, EventArgs e)
        {
            if (txtcurrent.Text == "Please enter the STEPS/MM of your printer")
            {
                txtcurrent.Text = "";
                txtcurrent.ForeColor = Color.Black;
            }
        }

        public void CurrentAddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcurrent.Text))
            {
                txtcurrent.Text = "Please enter the STEPS/MM of your printer";
                txtcurrent.ForeColor = Color.Gray;
            }
        }

        public void MeasuredRemoveText(object sender, EventArgs e)
        {
            if (txtmeasured.Text == "Please enter the measured length")
            {
                txtmeasured.Text = "";

                txtmeasured.ForeColor = Color.Black;
            }
        }

        public void MeasuredAddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmeasured.Text))
            {
                txtmeasured.Text = "Please enter the measured length";
                txtmeasured.ForeColor = Color.Gray;
            }
        }

        public void RealRemoveText(object sender, EventArgs e)
        {
            if (txtreal.Text == "Real length")
            {
                txtreal.Text = "";

                txtreal.ForeColor = Color.Black;
            }
        }

        public void RealAddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtreal.Text))
            {
                txtreal.Text = "Real length";
                txtreal.ForeColor = Color.Gray;
            }
        }

        public void NewRemoveText(object sender, EventArgs e)
        {
            if (txtnew.Text == "New steps of your printer")
            {
                txtnew.Text = "";

                txtnew.ForeColor = Color.Black;
            }
        }

        public void NewAddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnew.Text))
            {
                txtnew.Text = "New steps of your printer";
                txtnew.ForeColor = Color.Gray;
            }
        }

        public void RemoveWallsText(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Please enter thickness")
            {
                (sender as TextBox).Text = "";

                TextBox tb = new TextBox();
                tb.ForeColor = Color.Black;
            }
        }

        public void AddWallsText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "Please enter thickness";

                TextBox tb = new TextBox();
                tb.ForeColor = Color.Gray;
            }
        }

        public void FlowRateRemoveText(object sender, EventArgs e)
        {
            if (txtnewflow.Text == "New FlowRate")
            {
                txtnewflow.Text = "";

                txtnewflow.ForeColor = Color.Black;
            }
        }

        public void FlowRateAddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnewflow.Text))
            {
                txtnewflow.Text = "New FlowRate";
                txtnewflow.ForeColor = Color.Gray;
            }
        }

        private void tbs_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnFlowRate_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, num5, num6, num7, num8, num9, sum, sum1, sum2, sum3;
            num1 = double.Parse(txtwall1a.Text);
            num2 = double.Parse(txtwall1b.Text);
            num3 = double.Parse(txtwall2a.Text);
            num4 = double.Parse(txtwall2b.Text);
            num5 = double.Parse(txtwall3a.Text);
            num6 = double.Parse(txtwall3b.Text);
            num7 = double.Parse(txtwall4a.Text);
            num8 = double.Parse(txtwall4b.Text);
            num9 = double.Parse(txtwallThickness.Text);

            sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8;

            sum1 = sum / 8;

            sum2 = num9 / Math.Round(sum1, 2);

            sum3 = Math.Round(sum2, 2) * 100;

            txtnewflow.Text = Convert.ToString(sum3);
        }

        private void btnEsteps_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, sum, sum1;
            num1 = double.Parse(txtcurrent.Text);
            num2 = double.Parse(txtreal.Text);
            num3 = double.Parse(txtmeasured.Text);

            sum1 = num2 * num1;
            sum = sum1 / num3;
            txtnew.Text = Convert.ToString(sum);
        }
    }
}
