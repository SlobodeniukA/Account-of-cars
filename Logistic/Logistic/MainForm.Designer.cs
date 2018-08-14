namespace Logistic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.routeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dellabel = new System.Windows.Forms.Label();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.truncateButton = new System.Windows.Forms.Button();
            this.usersControlButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.автомобільBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logisticDBDataSet = new Logistic.logisticDBDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.рейсBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.водійBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.автомобільTableAdapter = new Logistic.logisticDBDataSetTableAdapters.АвтомобільTableAdapter();
            this.водійTableAdapter = new Logistic.logisticDBDataSetTableAdapters.ВодійTableAdapter();
            this.рейсTableAdapter = new Logistic.logisticDBDataSetTableAdapters.РейсTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDBDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.водійBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.routeButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.truncateButton);
            this.panel1.Controls.Add(this.usersControlButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 643);
            this.panel1.TabIndex = 0;
            // 
            // routeButton
            // 
            this.routeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.routeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.routeButton.Location = new System.Drawing.Point(21, 522);
            this.routeButton.Name = "routeButton";
            this.routeButton.Size = new System.Drawing.Size(297, 44);
            this.routeButton.TabIndex = 13;
            this.routeButton.Text = "Створити рейс";
            this.routeButton.UseVisualStyleBackColor = true;
            this.routeButton.Click += new System.EventHandler(this.routeButton_Click);
            // 
            // editButton
            // 
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.editButton.Location = new System.Drawing.Point(21, 123);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(297, 41);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Редагувати дані";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxFilter);
            this.groupBox2.Controls.Add(this.textBoxFilter);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(22, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 113);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фільтрування";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(18, 31);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(196, 21);
            this.comboBoxFilter.TabIndex = 9;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            this.comboBoxFilter.Enter += new System.EventHandler(this.comboBoxFilter_Enter);
            this.comboBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFilter_KeyPress);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(18, 71);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(256, 20);
            this.textBoxFilter.TabIndex = 8;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            this.textBoxFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilter_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dellabel);
            this.groupBox1.Controls.Add(this.deleteTextBox);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Видалення  ";
            // 
            // dellabel
            // 
            this.dellabel.AutoSize = true;
            this.dellabel.Location = new System.Drawing.Point(77, 16);
            this.dellabel.Name = "dellabel";
            this.dellabel.Size = new System.Drawing.Size(0, 13);
            this.dellabel.TabIndex = 10;
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(19, 43);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(256, 20);
            this.deleteTextBox.TabIndex = 8;
            this.deleteTextBox.TextChanged += new System.EventHandler(this.deleteTextBox_TextChanged);
            this.deleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deleteTextBox_KeyPress);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteButton.Location = new System.Drawing.Point(19, 80);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(256, 37);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Видалити з таблиці";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(57, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Облік компанії";
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addButton.Location = new System.Drawing.Point(21, 68);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(298, 39);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Додати дані";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // truncateButton
            // 
            this.truncateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truncateButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.truncateButton.Location = new System.Drawing.Point(22, 458);
            this.truncateButton.Name = "truncateButton";
            this.truncateButton.Size = new System.Drawing.Size(297, 44);
            this.truncateButton.TabIndex = 6;
            this.truncateButton.Text = "Очистити таблицю";
            this.truncateButton.UseVisualStyleBackColor = true;
            this.truncateButton.Click += new System.EventHandler(this.truncateButton_Click);
            // 
            // usersControlButton
            // 
            this.usersControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersControlButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usersControlButton.Location = new System.Drawing.Point(21, 587);
            this.usersControlButton.Name = "usersControlButton";
            this.usersControlButton.Size = new System.Drawing.Size(297, 45);
            this.usersControlButton.TabIndex = 5;
            this.usersControlButton.Text = "Керування користувачами";
            this.usersControlButton.UseVisualStyleBackColor = true;
            this.usersControlButton.Click += new System.EventHandler(this.usersControlButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 32);
            this.panel2.TabIndex = 3;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(37, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Головне вікно";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "◈";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(841, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "❒";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(874, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "х";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобілі";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // автомобільBindingSource
            // 
            this.автомобільBindingSource.DataMember = "Автомобіль";
            this.автомобільBindingSource.DataSource = this.logisticDBDataSet;
            // 
            // logisticDBDataSet
            // 
            this.logisticDBDataSet.DataSetName = "logisticDBDataSet";
            this.logisticDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(552, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Рейси";
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(552, 492);
            this.dataGridView3.TabIndex = 0;
            // 
            // рейсBindingSource
            // 
            this.рейсBindingSource.DataMember = "Рейс";
            this.рейсBindingSource.DataSource = this.logisticDBDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Водії";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(546, 486);
            this.dataGridView2.TabIndex = 0;
            // 
            // водійBindingSource
            // 
            this.водійBindingSource.DataMember = "Водій";
            this.водійBindingSource.DataSource = this.logisticDBDataSet;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(340, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 518);
            this.tabControl1.TabIndex = 1;
            // 
            // автомобільTableAdapter
            // 
            this.автомобільTableAdapter.ClearBeforeFill = true;
            // 
            // водійTableAdapter
            // 
            this.водійTableAdapter.ClearBeforeFill = true;
            // 
            // рейсTableAdapter
            // 
            this.рейсTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.exportButton);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.changeStatusButton);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(340, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 125);
            this.panel3.TabIndex = 13;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.FlatAppearance.BorderSize = 2;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exportButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.exportButton.Location = new System.Drawing.Point(294, 14);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(240, 42);
            this.exportButton.TabIndex = 11;
            this.exportButton.Text = "Експортувати в таблицю Excel";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton4.Location = new System.Drawing.Point(141, 91);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeStatusButton.FlatAppearance.BorderSize = 2;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeStatusButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.changeStatusButton.Location = new System.Drawing.Point(294, 72);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(240, 42);
            this.changeStatusButton.TabIndex = 9;
            this.changeStatusButton.Text = "Зробити рейс виконаним";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton3.Location = new System.Drawing.Point(141, 27);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton2.Location = new System.Drawing.Point(29, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton1.Location = new System.Drawing.Point(29, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне вікно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.автомобільBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logisticDBDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейсBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.водійBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button truncateButton;
        private System.Windows.Forms.Button usersControlButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button routeButton;
        private logisticDBDataSetTableAdapters.АвтомобільTableAdapter автомобільTableAdapter;
        private logisticDBDataSetTableAdapters.ВодійTableAdapter водійTableAdapter;
        private logisticDBDataSetTableAdapters.РейсTableAdapter рейсTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавїздуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавиїздуDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label dellabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private logisticDBDataSet logisticDBDataSet;
        private System.Windows.Forms.BindingSource рейсBindingSource;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.BindingSource автомобільBindingSource;
        private System.Windows.Forms.BindingSource водійBindingSource;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

