using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ExtruderEstepsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            base.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.ActiveControl = label1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtcurrent.Text, "^[0-9]*$") || !System.Text.RegularExpressions.Regex.IsMatch(txtmeasured.Text, "^[0-9]*$") || !System.Text.RegularExpressions.Regex.IsMatch(txtreal.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Please fill text boxes with numbers only", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double num1, num2, sum;
                num1 = double.Parse(txtcurrent.Text);
                num2 = double.Parse(txtreal.Text);
                sum = num1 / num2 * 100;
                //txtnew.Text = Convert.ToString(sum).Substring(0, 5).Trim();
                txtnew.Text = Convert.ToString(sum);
            }
        }

    }
}
