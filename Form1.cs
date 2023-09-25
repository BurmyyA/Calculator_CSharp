using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Burmeister
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum, calculation;

            firstNum = Convert.ToDouble(firstNumTextBox.Text);
            secondNum = Convert.ToDouble(secondNumTextBox.Text);

            calculation = firstNum + secondNum;

            calculateListBox.Items.Add(firstNum + " + " + secondNum + " = " + calculation);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calculateListBox.Items.Clear();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum, calculation;

            firstNum = Convert.ToDouble(firstNumTextBox.Text);
            secondNum = Convert.ToDouble(secondNumTextBox.Text);

            calculation = firstNum - secondNum;

            calculateListBox.Items.Add(firstNum + " - " + secondNum + " = " + calculation);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum, calculation;

            firstNum = Convert.ToDouble(firstNumTextBox.Text);
            secondNum = Convert.ToDouble(secondNumTextBox.Text);

            calculation = firstNum * secondNum;

            calculateListBox.Items.Add(firstNum + " * " + secondNum + " = " + calculation);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double firstNum, secondNum, calculation;

            firstNum = Convert.ToDouble(firstNumTextBox.Text);
            secondNum = Convert.ToDouble(secondNumTextBox.Text);

            calculation = firstNum / secondNum;

            calculateListBox.Items.Add(firstNum + " / " + secondNum + " = " + calculation);
        }
    }
}
