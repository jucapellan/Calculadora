namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string thisOperator = string.Empty;
        bool operatorSet = false;
        bool pointSet = false;
        decimal firstNumber;
        decimal secondNumber;

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
            operatorSet = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (operatorSet == false)
            {
                operatorSet = true;
                thisOperator = "+";
                firstNumber = decimal.Parse(tbxScreen.Text);
                tbxScreen.Text = tbxScreen.Text + "+";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operatorSet == false)
            {
                operatorSet = true;
                thisOperator = "-";
                firstNumber = decimal.Parse(tbxScreen.Text);
                tbxScreen.Text = tbxScreen.Text + "-";
            }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (operatorSet == false)
            {
                operatorSet = true;
                thisOperator = "*";
                firstNumber = decimal.Parse(tbxScreen.Text);
                tbxScreen.Text = tbxScreen.Text + "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (operatorSet == false)
            {
                operatorSet = true;
                thisOperator = "/";
                firstNumber = decimal.Parse(tbxScreen.Text);
                tbxScreen.Text = tbxScreen.Text + "/";
            }
        }
    }
}