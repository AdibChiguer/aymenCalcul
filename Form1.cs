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
        public frmCalculette()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           txtAffichage.TextAlign = HorizontalAlignment.Right;
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                txtAffichage.Text = (int.Parse(txtAffichage.Text) + int.Parse(op1)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btnCalculer_MouseMove(object sender, MouseEventArgs e)
        {
          //txtAffichage.Text=  e.X.ToString();
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
            txtAffichage.Text = button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button6.Text; ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!isOpClicked)
            {
                txtAffichage.Text = "";
                isOpClicked = true;
            }

            txtAffichage.Text += button9.Text;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op = "+";
            op1 = txtAffichage.Text;

        }
    }
}
