using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTestApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void onlyNumber_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text.ToString()=="")
            {
                MessageBox.Show("Enter value");

            }
            else if (secondNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Entr value");
            }
            else
            {
                double firstNumber, secondNumber, result;

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                result = firstNumber + secondNumber;
                resultTextBox.Text = result.ToString();
            }
            

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter value");

            }
            else if (secondNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Entr value");
            }
            else
            {
                double firstNumber, secondNumber, result;

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                result = firstNumber - secondNumber;
                resultTextBox.Text = result.ToString();
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter value");

            }
            else if (secondNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Entr value");
            }
            else
            {
                double firstNumber, secondNumber, result;

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                result = firstNumber * secondNumber;
                resultTextBox.Text = result.ToString();
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Enter value");

            }
            else if (secondNumberTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Entr value");
            }
            else
            {
                double firstNumber, secondNumber, result;

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                result = firstNumber / secondNumber;
                resultTextBox.Text = result.ToString();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
