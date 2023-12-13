using System;
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

        private void frmCalculette_Shown(object sender, EventArgs e)
        {
            txtAffichage.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAffichage.TextAlign = HorizontalAlignment.Right;
            txtAffichage.Focus();
            txtAffichage.Enabled = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "+";
            op1 = txtAffichage.Text;
        }

        // numbers button on click event handling
        private void button0_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button0.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1) , double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button1.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button2.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button3.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button4.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button5.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button6.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button7.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button8.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
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
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = button9.Text;
                isOpClicked = false;
                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                }
            }
            else
            {
                txtAffichage.Text += button9.Text;
            }
        }

        // operation handling
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
            catch (FormatException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void nigatifBtn_Click(object sender, EventArgs e)
        {
            if (txtAffichage.Text.StartsWith("-")){
                txtAffichage.Text = txtAffichage.Text.Substring(1);
            } else {
                txtAffichage.Text = "-" + txtAffichage.Text;
            }
        }

        private void divisionSur1Bnt_Click(object sender, EventArgs e)
        {
            result = (1 / double.Parse(txtAffichage.Text)).ToString();
            txtAffichage.Text = result;
        }

        private void moduloBtn_Click(object sender, EventArgs e)
        {
            op = "%";
            op1 = txtAffichage.Text;
            isOpClicked = true;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (!txtAffichage.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(txtAffichage.Text))
                {
                    txtAffichage.Text = "0.";
                }
                else
                {
                    txtAffichage.Text += dotBtn.Text;
                }
            }
        }

        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAffichage.Text, out double currentValue) && currentValue >= 0)
            {
                txtAffichage.Text = Math.Sqrt(currentValue).ToString();
                result = txtAffichage.Text;
            }
            else
            {
                txtAffichage.Text = "Invalid input";
                result = "Invalid input";
            }
        }

        private void twoSubBtn_Click(object sender, EventArgs e)
        {
            result = (double.Parse(txtAffichage.Text) * double.Parse(txtAffichage.Text)).ToString();
            txtAffichage.Text = result;
        }

        private void txtAffichage_TextChanged(object sender, EventArgs e)
        {

        }

        // operations
        private double plus_op(double n1 , double n2) {
            return n1 + n2;
        }

        private double multiplication_op(double n1, double n2) {  
            return n1 * n2; 
        }

        private string division_op(double n1, double n2) {
            if(n2 != 0)
            {
                return (n1 / n2).ToString();
            } else
            {
                return "Error";
            }
        }

        private double moin_op(double n1, double n2)
        {
            return n1 - n2;
        }

        private string modulo_op(double n1, double n2)
        {
            if (n2 != 0)
            {
                  if (n2 != 0)
                  {
                    return (n1 % n2).ToString();
                  }
                  else {
                    return "Error";
                  }
            }
            else {
                return "Error";
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            txtAffichage.Text = "0";
            isOpClicked = false;
            result = "";
        }


        // handling the press events 
        private void txtAffichage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            // Handle numeric keys
            if (char.IsDigit(keyPressed))
            {
                HandleNumericKeyPress(keyPressed);
            }
            // Handle operator keys
            else if (IsOperator(keyPressed))
            {
                HandleOperatorKeyPress(keyPressed);
            }
            // Handle equal key
            else if (keyPressed == '=' || keyPressed == '\r')
            {
                egal_Click(sender, e);
            }
            // Handle clear entry key
            else if (keyPressed == 'c' || keyPressed == 'C')
            {
                cBtn_Click(sender, e);
            }
        }

        private void HandleNumericKeyPress(char key)
        {
            if (txtAffichage.Text == "0" || isOpClicked || txtAffichage.Text == "Invalid input" || txtAffichage.Text == "Error")
            {
                txtAffichage.Text = key.ToString();
                isOpClicked = false;
                Console.Write(txtAffichage.Text);

                switch (op)
                {
                    case "+":
                        result = plus_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "*":
                        result = multiplication_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "/":
                        result = division_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                    case "-":
                        result = moin_op(double.Parse(op1), double.Parse(txtAffichage.Text)).ToString();
                        break;
                    case "%":
                        result = modulo_op(double.Parse(op1), double.Parse(txtAffichage.Text));
                        break;
                }
            }
            else
            {
                txtAffichage.Text += key;
                Console.Write(txtAffichage.Text);
            }
        }

        private void HandleOperatorKeyPress(char key)
        {
            switch (key)
            {
                case '+':
                    plus_Click(this, EventArgs.Empty);
                    break;
                case '-':
                    moin_Click(this, EventArgs.Empty);
                    break;
                case '*':
                    multiplication_Click(this, EventArgs.Empty);
                    break;
                case '/':
                    division_Click(this, EventArgs.Empty);
                    break;
                case '%':
                    moduloBtn_Click(this, EventArgs.Empty);
                    break;
            }
        }

        private bool IsOperator(char key)
        {
            return key == '+' || key == '-' || key == '*' || key == '/' || key == '%';
        }


    }
}
