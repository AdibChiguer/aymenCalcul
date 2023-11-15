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

        private void btn8_Click(object sender, EventArgs e)
        {
            txtAffichage.Text =btn8.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "+";
            op1 = txtAffichage.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = btn5.Text;
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
    }
}
