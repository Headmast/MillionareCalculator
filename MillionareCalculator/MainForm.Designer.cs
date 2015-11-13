namespace MillionareCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.throwDiceButton = new System.Windows.Forms.Button();
            this.firstDiceLabel = new System.Windows.Forms.Label();
            this.secondDiceLabel = new System.Windows.Forms.Label();
            this.sumDiceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.isManualThrowcheckBox = new System.Windows.Forms.CheckBox();
            this.firstDiceTextBox = new System.Windows.Forms.TextBox();
            this.secondDiceTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loggerTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Миллионер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Бросить кубики";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Недвижимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Игровое поле";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Игроки";
            // 
            // throwDiceButton
            // 
            this.throwDiceButton.Location = new System.Drawing.Point(10, 10);
            this.throwDiceButton.Name = "throwDiceButton";
            this.throwDiceButton.Size = new System.Drawing.Size(90, 50);
            this.throwDiceButton.TabIndex = 5;
            this.throwDiceButton.Text = "Бросок";
            this.throwDiceButton.UseVisualStyleBackColor = true;
            this.throwDiceButton.Click += new System.EventHandler(this.ThrowDice_Click);
            // 
            // firstDiceLabel
            // 
            this.firstDiceLabel.AutoSize = true;
            this.firstDiceLabel.Location = new System.Drawing.Point(110, 31);
            this.firstDiceLabel.Name = "firstDiceLabel";
            this.firstDiceLabel.Size = new System.Drawing.Size(13, 13);
            this.firstDiceLabel.TabIndex = 6;
            this.firstDiceLabel.Text = "0";
            // 
            // secondDiceLabel
            // 
            this.secondDiceLabel.AutoSize = true;
            this.secondDiceLabel.Location = new System.Drawing.Point(140, 31);
            this.secondDiceLabel.Name = "secondDiceLabel";
            this.secondDiceLabel.Size = new System.Drawing.Size(13, 13);
            this.secondDiceLabel.TabIndex = 7;
            this.secondDiceLabel.Text = "0";
            // 
            // sumDiceLabel
            // 
            this.sumDiceLabel.AutoSize = true;
            this.sumDiceLabel.Location = new System.Drawing.Point(165, 32);
            this.sumDiceLabel.Name = "sumDiceLabel";
            this.sumDiceLabel.Size = new System.Drawing.Size(13, 13);
            this.sumDiceLabel.TabIndex = 8;
            this.sumDiceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "II";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Всего";
            // 
            // isManualThrowcheckBox
            // 
            this.isManualThrowcheckBox.AutoSize = true;
            this.isManualThrowcheckBox.Location = new System.Drawing.Point(10, 65);
            this.isManualThrowcheckBox.Name = "isManualThrowcheckBox";
            this.isManualThrowcheckBox.Size = new System.Drawing.Size(94, 17);
            this.isManualThrowcheckBox.TabIndex = 12;
            this.isManualThrowcheckBox.Text = "ввод вручную";
            this.isManualThrowcheckBox.UseVisualStyleBackColor = true;
            // 
            // firstDiceTextBox
            // 
            this.firstDiceTextBox.Location = new System.Drawing.Point(110, 50);
            this.firstDiceTextBox.Name = "firstDiceTextBox";
            this.firstDiceTextBox.Size = new System.Drawing.Size(18, 20);
            this.firstDiceTextBox.TabIndex = 13;
            this.firstDiceTextBox.Text = "0";
            this.firstDiceTextBox.TextChanged += new System.EventHandler(this.textBoxDice_TextChanged);
            // 
            // secondDiceTextBox
            // 
            this.secondDiceTextBox.Location = new System.Drawing.Point(140, 50);
            this.secondDiceTextBox.Name = "secondDiceTextBox";
            this.secondDiceTextBox.Size = new System.Drawing.Size(18, 20);
            this.secondDiceTextBox.TabIndex = 14;
            this.secondDiceTextBox.Text = "0";
            this.secondDiceTextBox.TextChanged += new System.EventHandler(this.textBoxDice_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.throwDiceButton);
            this.panel1.Controls.Add(this.isManualThrowcheckBox);
            this.panel1.Controls.Add(this.secondDiceTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.firstDiceTextBox);
            this.panel1.Controls.Add(this.firstDiceLabel);
            this.panel1.Controls.Add(this.secondDiceLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.sumDiceLabel);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(170, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 100);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 100);
            this.panel2.TabIndex = 15;
            // 
            // loggerTextBox
            // 
            this.loggerTextBox.Location = new System.Drawing.Point(395, 10);
            this.loggerTextBox.Multiline = true;
            this.loggerTextBox.Name = "loggerTextBox";
            this.loggerTextBox.Size = new System.Drawing.Size(200, 100);
            this.loggerTextBox.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(10, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 247);
            this.panel3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Налог";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Аренда";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "       Название        Стр  Цена  Нал  Ар   Ц з  Игр";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.loggerTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Миллионер Elite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button throwDiceButton;
        private System.Windows.Forms.Label firstDiceLabel;
        private System.Windows.Forms.Label secondDiceLabel;
        private System.Windows.Forms.Label sumDiceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox isManualThrowcheckBox;
        private System.Windows.Forms.TextBox firstDiceTextBox;
        private System.Windows.Forms.TextBox secondDiceTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox loggerTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

