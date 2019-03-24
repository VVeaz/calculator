using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void adding_Click(object sender, EventArgs e)
        {
            number1.Text = Calculations.RemoveWhiteCahracters(number1.Text);
            number2.Text = Calculations.RemoveWhiteCahracters(number2.Text);
            if (!Calculations.IsItNumber(number1.Text))
            {
                MessageBox.Show("Number 1 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            if (!Calculations.IsItNumber(number2.Text))
            {
                MessageBox.Show("Number 2 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            result.Text = Calculations.Add(number1.Text, number2.Text);
        }

        private void subtracting_Click(object sender, EventArgs e)
        {
            number1.Text = Calculations.RemoveWhiteCahracters(number1.Text);
            number2.Text = Calculations.RemoveWhiteCahracters(number2.Text);
            if (!Calculations.IsItNumber(number1.Text))
            {
                MessageBox.Show("Number 1 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            if (!Calculations.IsItNumber(number2.Text))
            {
                MessageBox.Show("Number 2 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            result.Text = Calculations.Subtract(number1.Text, number2.Text);
        }

        private void multiplying_Click(object sender, EventArgs e)
        {
            number1.Text=Calculations.RemoveWhiteCahracters(number1.Text);
            number2.Text=Calculations.RemoveWhiteCahracters(number2.Text);
            if (!Calculations.IsItNumber(number1.Text))
            {
                MessageBox.Show("Number 1 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            if (!Calculations.IsItNumber(number2.Text))
            {
                MessageBox.Show("Number 2 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            
            result.Text = Calculations.Multiply(number1.Text, number2.Text);
        }

        private void dividing_Click(object sender, EventArgs e)
        {
            number1.Text = Calculations.RemoveWhiteCahracters(number1.Text);
            number2.Text = Calculations.RemoveWhiteCahracters(number2.Text);
            if (!Calculations.IsItNumber(number1.Text))
            {
                MessageBox.Show("Number 1 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            if (!Calculations.IsItNumber(number2.Text))
            {
                MessageBox.Show("Number 2 is not really a number.\nYou can use digits, one comma and one minus at the front.");
                return;
            }
            result.Text = Calculations.Divide(number1.Text, number2.Text);
        }
    }
}
