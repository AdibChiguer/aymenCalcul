using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpCalculette
{
    public partial class frmCalculette : Form
    {
        string op = "";
        string op1 = "";
        bool isOpClicked = false;
        string result = "";
        public frmCalculette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtAffichage.TextAlign = HorizontalAlignment.Right;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "+";
            op1 = txtAffichage.Text;
        }
        private void frmCalculette_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
        }

        private void txtAffichage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string c = e.KeyChar.ToString();
            //txtAffichage.Text += c;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button0.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button0.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button1.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button2.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button3.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button4.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button4.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button5.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button5.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button6.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button6.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button7.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button7.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button8.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button8.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked)
            {
                txtAffichage.Text = button9.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = (int.Parse(op1) + int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = (int.Parse(op1) * int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = (int.Parse(op1) / int.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "-":
                        result = (int.Parse(op1) - int.Parse(txtAffichage.Text)).ToString();
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button9.Text;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op = "+";
            op1 = txtAffichage.Text;
            isOpClicked = true;
        }

        private void moin_Click(object sender, EventArgs e)
        {
            op = "-";
            op1 = txtAffichage.Text;
            isOpClicked = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            op = "*";
            op1 = txtAffichage.Text;
            isOpClicked = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            op = "/";
            op1 = txtAffichage.Text;
            isOpClicked = true;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            try
            {
                txtAffichage.Text = result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text.Length > 0)
            {
                txtAffichage.Text = txtAffichage.Text.Substring(0, txtAffichage.Text.Length - 1);
            }
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            op = "";
            op1 = "";
            isOpClicked = false;
        }
    }
}
