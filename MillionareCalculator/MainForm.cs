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
        private Int32 logCounter = 0;   //move counter for logger
        private Sector sector;          //sector of companies
        private CompaniesList companies;
        private Label taxLabel;
        private List<Company> companiesList;


        public MainForm()
        {
            InitializeComponent();
            
            companies = new CompaniesList();
            sector = new Sector(new List<Company>());
            this.conrols();
        }

        /// <summary>
        /// 
        /// </summary>
        private void conrols()
        {
            Label sectorNameLabel = new Label();
            sectorNameLabel.Text = "Промышленность";
            sectorNameLabel.Location = new Point(13, 7);
            sectorNameLabel.BackColor = Color.Gray;
            sectorNameLabel.AutoSize = true;
            this.panel3.Controls.Add(sectorNameLabel);

            List<Company> companies = new List<Company>();
            Company company = new Company(1, "Магазин", 100, 5, 15, 50);
            companies.Add(company);
            company = new Company(2, "Лавка", 150, 5, 15, 50);
            companies.Add(company);
            company = new Company(3, "Ресторан", 200, 5, 15, 50);
            companies.Add(company);

            this.companiesList = companies;


            Panel panel = this.createCompanyPanel(companies[0]);
            panel.Location = new Point(13, 30);
            this.panel3.Controls.Add(panel);
            panel = this.createCompanyPanel(companies[1]);
            panel.Location = new Point(13, 70);
            this.panel3.Controls.Add(panel);
            panel = this.createCompanyPanel(companies[2]);
            panel.Location = new Point(13, 110);
            this.panel3.Controls.Add(panel);
            Panel currentPanel = (Panel)this.panel3.Controls.Find("CompanyName", false).FirstOrDefault();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sector"></param>
        /// <returns></returns>
        private Panel createSectorPanel(Sector sector)
        {
            Panel panel = new Panel();
            //sector name
            //array of panels company
            return panel;
        }

        // get rent value
        private int calculateRent ()
        {
            return 0;
        }

        // get tax value
        private int calculateTax()
        {
            return 0;
        }
        
        /// <summary>
        /// Создание панели с информацией про организацию, со всеми элементами
        /// Ценой покупки, аренды, налогов и построек плюс принадлежность игроку
        /// </summary>
        /// <param name="company"></param>
        /// <returns></returns>
        private Panel createCompanyPanel(Company company)
        {
            Panel panel = new Panel();
            panel.Name = "CompanyName"/* + company.Id.ToString()*/;
            panel.Height = 30;
            panel.Width = 225;
            panel.AutoSize = true;

            CheckBox nameCheckBox = new CheckBox();
            nameCheckBox.Text = company.Name;
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
            priceList.Text = company.Price.ToString() + ", " + company.Tax.ToString() + ", " + company.Rent.ToString();
            priceList.AutoSize = true;
            panel.Controls.Add(priceList);

            TextBox player = new TextBox();
            player.Location = new Point(200, 5);
            player.Name = "PlayerTextBox" + company.Id.ToString();
            player.Width = 20;
            panel.Controls.Add(player);
            
            panel.BackColor = Color.CadetBlue;
            panel.AutoSize = true;
            return panel;
        }

        /// <summary>
        /// Бросок двух кубиков, возможны случайных бросок или специальный ввод
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Событие отлавливашющее ввод значений кубика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.taxLabel == null)
            {
                this.taxLabel = new Label();
                this.taxLabel.Location = new Point(430, 121);
                this.taxLabel.AutoSize = true;
                this.Controls.Add(this.taxLabel);
            }
            

            Int32 tax = 0;
            foreach (Company company in this.companiesList)
            {
                TextBox playerTextBox = (TextBox)this.panel3.Controls.Find("PlayerTextBox" + company.Id.ToString(), true).FirstOrDefault();
                String playerId = playerTextBox.Text;
                if (playerId.Equals("1"))
                {
                    tax += company.Tax;
                }
            }

            this.taxLabel.Text = tax.ToString();
        }
    }
}

