using CalculatorPrivateAssembly;
namespace BasicCalculator

{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result = 0;

            if (!float.TryParse(txtFirst.Text, out num1) ||
                !float.TryParse(txtSecond.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            switch (cboOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(num1, num2);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(num1, num2);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = BasicComputation.Division(num1, num2);
                    break;
            }

            lblTotal.Text = result.ToString();
        }

    }
}

