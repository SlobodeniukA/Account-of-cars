namespace Logistic
{
    partial class routeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(routeForm));
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuto = new System.Windows.Forms.ComboBox();
            this.автомобільBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.водійBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.textBoxDeparturePoint = new System.Windows.Forms.TextBox();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelShowNumber = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelShowExperience = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.petrolLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водійBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(409, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "х";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 32);
            this.panel2.TabIndex = 4;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вікно створення рейсу";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "◈";
            // 
            // comboBoxAuto
            // 
            this.comboBoxAuto.FormattingEnabled = true;
            this.comboBoxAuto.Location = new System.Drawing.Point(166, 141);
            this.comboBoxAuto.Name = "comboBoxAuto";
            this.comboBoxAuto.Size = new System.Drawing.Size(218, 21);
            this.comboBoxAuto.TabIndex = 5;
            this.comboBoxAuto.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuto_SelectedIndexChanged);
            this.comboBoxAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAuto_KeyPress);
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(166, 68);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(218, 21);
            this.comboBoxDriver.TabIndex = 6;
            this.comboBoxDriver.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriver_SelectedIndexChanged);
            this.comboBoxDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDriver_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 253);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 295);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(166, 391);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(218, 20);
            this.textBoxDestination.TabIndex = 9;
            this.textBoxDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDestination_KeyPress);
            // 
            // textBoxDeparturePoint
            // 
            this.textBoxDeparturePoint.Location = new System.Drawing.Point(166, 349);
            this.textBoxDeparturePoint.Name = "textBoxDeparturePoint";
            this.textBoxDeparturePoint.Size = new System.Drawing.Size(218, 20);
            this.textBoxDeparturePoint.TabIndex = 10;
            this.textBoxDeparturePoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeparturePoint_KeyPress);
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(166, 471);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(218, 20);
            this.textBoxArticle.TabIndex = 12;
            this.textBoxArticle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxArticle_KeyPress);
            // 
            // labelShowNumber
            // 
            this.labelShowNumber.AutoSize = true;
            this.labelShowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowNumber.ForeColor = System.Drawing.Color.White;
            this.labelShowNumber.Location = new System.Drawing.Point(163, 174);
            this.labelShowNumber.Name = "labelShowNumber";
            this.labelShowNumber.Size = new System.Drawing.Size(0, 15);
            this.labelShowNumber.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addButton.Location = new System.Drawing.Point(73, 537);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(266, 39);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Додати рейс";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Оберіть водія";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Оберіть авто";
            // 
            // labelShowExperience
            // 
            this.labelShowExperience.AutoSize = true;
            this.labelShowExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShowExperience.ForeColor = System.Drawing.Color.White;
            this.labelShowExperience.Location = new System.Drawing.Point(163, 106);
            this.labelShowExperience.Name = "labelShowExperience";
            this.labelShowExperience.Size = new System.Drawing.Size(0, 15);
            this.labelShowExperience.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Дата відправлення";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дата прибуття";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Пункт відправлення";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Пункт прибуття";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Товар";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightLabel.ForeColor = System.Drawing.Color.White;
            this.weightLabel.Location = new System.Drawing.Point(163, 202);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(0, 15);
            this.weightLabel.TabIndex = 24;
            // 
            // petrolLabel
            // 
            this.petrolLabel.AutoSize = true;
            this.petrolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.petrolLabel.ForeColor = System.Drawing.Color.White;
            this.petrolLabel.Location = new System.Drawing.Point(163, 227);
            this.petrolLabel.Name = "petrolLabel";
            this.petrolLabel.Size = new System.Drawing.Size(0, 15);
            this.petrolLabel.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Вартість";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(166, 432);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(218, 20);
            this.textBoxCost.TabIndex = 26;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCost_KeyPress);
            // 
            // routeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(435, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.petrolLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelShowExperience);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.labelShowNumber);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.textBoxDeparturePoint);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDriver);
            this.Controls.Add(this.comboBoxAuto);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "routeForm";
            this.Text = "Вікно додавання маршруту";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водійBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuto;
        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.TextBox textBoxDeparturePoint;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private System.Windows.Forms.BindingSource автомобільBindingSource;
        private System.Windows.Forms.BindingSource водійBindingSource;
        private System.Windows.Forms.Label labelShowNumber;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelShowExperience;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label petrolLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCost;
    }
}