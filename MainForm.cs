using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionareCalculator
{
    public partial class MainForm : Form
    {
        Int32 logCounter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 firstValue;
            Int32 secondValue;
            if (this.checkBox1.Checked)
            {
                bool isNumeric = Int32.TryParse(this.textBox1.Text, out firstValue);
                isNumeric = Int32.TryParse(this.textBox2.Text, out secondValue);
            }
            else
            {
                Random random = new Random();
                firstValue = random.Next(1, 6);
                secondValue = random.Next(1, 6);
            }
            this.label6.Text = firstValue.ToString();
            this.label7.Text = secondValue.ToString();
            this.label8.Text = (firstValue + secondValue).ToString();
            logCounter++;
            this.textBox3.AppendText("\r\n" + logCounter.ToString() + " - " + this.label8.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Int32 firstValue;
            bool isNumeric = Int32.TryParse(this.textBox1.Text, out firstValue);
            Int32 secondValue;
            isNumeric = Int32.TryParse(this.textBox2.Text, out secondValue);
            this.label6.Text = firstValue.ToString();
            this.label7.Text = secondValue.ToString();
            this.label8.Text = (firstValue + secondValue).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
