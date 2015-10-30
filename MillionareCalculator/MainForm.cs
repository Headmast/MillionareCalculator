using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MillionareCalculator.GameObject;

namespace MillionareCalculator
{
    public partial class MainForm : Form
    {
        private Int32 logCounter = 0;
        private Sector sector;
        private CompaniesList companies;

        public MainForm()
        {
            InitializeComponent();
            sector = new Sector();
            companies = new CompaniesList();
            this.conrols();
        }

        private void conrols()
        {
            Label namelabel = new Label();
            namelabel.Location = new Point(13, 90);
            namelabel.Text = "sadf";
            namelabel.AutoSize = true;
            this.panel3.Controls.Add(namelabel);

            CheckBox nameCheckBox = new CheckBox();
            nameCheckBox.Location = new Point(13, 105);
            nameCheckBox.Text = "sadf";
            nameCheckBox.AutoSize = true;
            this.panel3.Controls.Add(nameCheckBox);

            Panel panel = this.createCompanyPanel(null);
            panel.Location = new Point(13, 120);
            this.panel3.Controls.Add(panel);
            //this.createCompanyPanel(new Company(10, 10, 10, 10));
            //TextBox txtAmnt = (TextBox)this.Controls.Find("txtAmnt", false).FirstOrDefault();
            Panel currentPanel = (Panel)this.panel3.Controls.Find("CompanyName", false).FirstOrDefault();
        }


        private Panel createCompanyPanel(Company company)
        {
            Panel panel = new Panel();
            panel.Name = "CompanyName"/* + company.Id.ToString()*/;
            panel.Height = 20;
            panel.Width = 300;
            panel.BackColor = Color.White;

            CheckBox nameCheckBox = new CheckBox();
            nameCheckBox.Text = "Компания";
            nameCheckBox.Location = new Point(10, 0);
            panel.Controls.Add(nameCheckBox);
            return panel;
        }

        private void ThrowDice_Click(object sender, EventArgs e)
        {
            Int32 firstValue;
            Int32 secondValue;
            if (this.isManualThrowcheckBox.Checked)
            {
                bool isNumeric = Int32.TryParse(this.firstDiceTextBox.Text, out firstValue);
                isNumeric = Int32.TryParse(this.secondDiceTextBox.Text, out secondValue);
            }
            else
            {
                Random random = new Random();
                firstValue = random.Next(1, 6);
                secondValue = random.Next(1, 6);
            }
            this.firstDiceLabel.Text = firstValue.ToString();
            this.secondDiceLabel.Text = secondValue.ToString();
            this.sumDiceLabel.Text = (firstValue + secondValue).ToString();
            logCounter++;
            this.loggerTextBox.AppendText("\r\n" + logCounter.ToString() + " - " + this.sumDiceLabel.Text);
        }

        private void textBoxDice_TextChanged(object sender, EventArgs e)
        {
            Int32 firstValue;
            bool isNumeric = Int32.TryParse(this.firstDiceTextBox.Text, out firstValue);
            Int32 secondValue;
            isNumeric = Int32.TryParse(this.secondDiceTextBox.Text, out secondValue);
            this.firstDiceLabel.Text = firstValue.ToString();
            this.secondDiceLabel.Text = secondValue.ToString();
            this.sumDiceLabel.Text = (firstValue + secondValue).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

