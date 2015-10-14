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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Int32 firstValue = random.Next(1, 6);
            Int32 secondValue = random.Next(1, 6);
            this.label6.Text = firstValue.ToString();
            this.label7.Text = secondValue.ToString();
            this.label8.Text = (firstValue + secondValue).ToString();
        }
    }
}
