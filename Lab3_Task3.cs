using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Take input from a richtextbox or textbox
            String input = richTextBox1.Text;

            // Split the input based on space or other delimiters
            String[] words = input.Split(' ');

            // Regular expression to match words starting with 't' or 'm'
            Regex regex = new Regex(@"^[tm].*", RegexOptions.IgnoreCase);

            // Iterate through each word to check if it matches the regex
            for (int i = 0; i < words.Length; i++)
            {
                Match match = regex.Match(words[i]);

                if (match.Success)
                {
                    richTextBox2.Text += words[i] + " ";  // Output valid matches
                }
                else
                {
                    MessageBox.Show("Invalid: " + words[i]); // Notify invalid input
                }
            }
        }
    }
}
