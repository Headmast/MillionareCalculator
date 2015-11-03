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
            
            companies = new CompaniesList();
            sector = new Sector(new List<Company>());
            this.conrols();
        }

        private void conrols()
        {
            Label sectorNameLabel = new Label();
            sectorNameLabel.Text = "Промышленность";
            sectorNameLabel.Location = new Point(13, 7);
            this.panel3.Controls.Add(sectorNameLabel);


            Panel panel = this.createCompanyPanel(null);
            panel.Location = new Point(13, 30);
            this.panel3.Controls.Add(panel);
            panel = this.createCompanyPanel(null);
            panel.Location = new Point(13, 70);
            this.panel3.Controls.Add(panel);
            panel = this.createCompanyPanel(null);
            panel.Location = new Point(13, 110);
            this.panel3.Controls.Add(panel);
            panel = this.createCompanyPanel(null);
            panel.Location = new Point(13, 150);
            this.panel3.Controls.Add(panel);
            //Panel currentPanel = (Panel)this.panel3.Controls.Find("CompanyName", false).FirstOrDefault();
        }

        private Panel createSectorPanel(Sector sector)
        {
            Panel panel = new Panel();
            //sector name
            //array of panels company
            return panel;
        }

        // get rent value

        // get tax value


        private Panel createCompanyPanel(Company company)
        {
            Panel panel = new Panel();
            panel.Name = "CompanyName"/* + company.Id.ToString()*/;
            panel.Height = 30;
            panel.Width = 225;
            panel.AutoSize = true;
            panel.BackColor = Color.Gray;

            CheckBox nameCheckBox = new CheckBox();
            nameCheckBox.Text = "Компания";
            nameCheckBox.Location = new Point(5, 3);
            nameCheckBox.Width = 90;
            panel.Controls.Add(nameCheckBox);

            TextBox buildings = new TextBox();
            buildings.Location = new Point(100, 5);
            buildings.Width = 20;
            panel.Controls.Add(buildings);

            Label priceList = new Label();
            priceList.Location = new Point(125, 8);
            priceList.Width = 70;
            priceList.Text = "100, 5, 7, 50";
            priceList.AutoSize = true;
            panel.Controls.Add(priceList);

            TextBox player = new TextBox();
            player.Location = new Point(200, 5);
            player.Width = 20;
            panel.Controls.Add(player);
            
            panel.BackColor = Color.CadetBlue;
            panel.AutoSize = true;
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

       
    }
}

