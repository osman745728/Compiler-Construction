using System;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sine Function
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtInput.Text);
                double result = Math.Sin(value); // Calculate sine
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        // Cosine Function
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtInput.Text);
                double result = Math.Cos(value); // Calculate cosine
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        // Tangent Function
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtInput.Text);
                double result = Math.Tan(value); // Calculate tangent
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        // Logarithm Function
        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtInput.Text);
                double result = Math.Log(value); // Calculate natural logarithm (log base e)
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }
    }
}
