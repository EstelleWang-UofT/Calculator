namespace Calculator
{
    public partial class FormCalculator : Form
    {

        public FormCalculator()
        {
            InitializeComponent();
        }

        private string valIn = "";
        private string tempOp = "";
        private string result = "";
        private string prevIn = "";
        private bool prevEquals = false;
        private bool haveInput = false;

        private void numButtonClick(object sender, EventArgs e)
        {
            valIn = valIn + ((Button)(sender)).Text;
            haveInput = true;
            textBox.Text = valIn;
            // textBox.show()
        }

        private void opButtonClick(object sender, EventArgs e)
        {
            if (result == "")
            {
                result = valIn;

            }
            else if (!prevEquals && haveInput)
            {
                result = calculate().ToString();
            }
            textBox.Text = result;
            valIn = "";
            tempOp = ((Button)(sender)).Text;
            prevEquals = false;
            haveInput = false;
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            numButtonClick(sender, e);
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            result = Convert.ToString(calculate());
            textBox.Text = result;
            if (valIn != "") { prevIn = valIn; }
            valIn = "";
            prevEquals = true;
        }

        private Single calculate()
        {
            Single num1 = 0;
            if (result == "") { num1 = 0; }
            else { num1 = Convert.ToSingle(result); }

            Single num2 = 0;
            if (valIn == "" && prevIn == "") { num2 = 0; }
            else if (valIn == "" && prevIn != "") { num2 = Convert.ToSingle(prevIn); }
            else { num2 = Convert.ToSingle(valIn); }

            if (tempOp == "/" && num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0, please try again!");
            }

            Single res = 0;
            if (tempOp == "") { res = num2; }
            else if (tempOp == "+") { res = num1 + num2; }
            else if (tempOp == "-") { res = num1 - num2; }
            else if (tempOp == "*") { res = num1 * num2; }
            else { res = num1 / num2; }
            return res;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            opButtonClick(sender, e);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            opButtonClick(sender, e);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            opButtonClick(sender, e);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            opButtonClick(sender, e);
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            valIn = "";
            tempOp = "";
            result = "";
            textBox.Text = result;
        }

    }
}
