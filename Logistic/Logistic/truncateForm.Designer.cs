namespace Logistic
{
    partial class truncateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(truncateForm));
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.truncButton2 = new System.Windows.Forms.Button();
            this.truncButton1 = new System.Windows.Forms.Button();
            this.truncButton3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delRouteButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
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
            this.label4.Location = new System.Drawing.Point(514, 0);
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
            this.panel2.Size = new System.Drawing.Size(540, 32);
            this.panel2.TabIndex = 4;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вікно повного очищення таблиць";
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
            // truncButton2
            // 
            this.truncButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truncButton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.truncButton2.Location = new System.Drawing.Point(185, 179);
            this.truncButton2.Name = "truncButton2";
            this.truncButton2.Size = new System.Drawing.Size(155, 91);
            this.truncButton2.TabIndex = 10;
            this.truncButton2.Text = "Повністю очистити таблицю водіїв";
            this.truncButton2.UseVisualStyleBackColor = true;
            this.truncButton2.Click += new System.EventHandler(this.truncButton2_Click);
            // 
            // truncButton1
            // 
            this.truncButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truncButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.truncButton1.Location = new System.Drawing.Point(22, 179);
            this.truncButton1.Name = "truncButton1";
            this.truncButton1.Size = new System.Drawing.Size(155, 91);
            this.truncButton1.TabIndex = 9;
            this.truncButton1.Text = "Повністю очистити таблицю автомобілів";
            this.truncButton1.UseVisualStyleBackColor = true;
            this.truncButton1.Click += new System.EventHandler(this.truncButton1_Click);
            // 
            // truncButton3
            // 
            this.truncButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.truncButton3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.truncButton3.Location = new System.Drawing.Point(349, 179);
            this.truncButton3.Name = "truncButton3";
            this.truncButton3.Size = new System.Drawing.Size(155, 91);
            this.truncButton3.TabIndex = 11;
            this.truncButton3.Text = "Повністю очистити таблицю рейсів";
            this.truncButton3.UseVisualStyleBackColor = true;
            this.truncButton3.Click += new System.EventHandler(this.truncButton3_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Після натиснення кнопки очищення всі дані таблиці будуть знищені!\r\n              " +
    "                                                     Поверненню дані не підлягаю" +
    "ть!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(22, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Активізувати видалення";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "УВАГА! Очистивши таблицю \'Автомобіль\' або \'Водій\' Ви автоматично \r\n              " +
    "                                                                   очистите табл" +
    "ицю \'Рейс\'!!";
            // 
            // delRouteButton
            // 
            this.delRouteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delRouteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delRouteButton.Location = new System.Drawing.Point(22, 276);
            this.delRouteButton.Name = "delRouteButton";
            this.delRouteButton.Size = new System.Drawing.Size(482, 48);
            this.delRouteButton.TabIndex = 15;
            this.delRouteButton.Text = "Повністю видалити виконані рейси";
            this.delRouteButton.UseVisualStyleBackColor = true;
            this.delRouteButton.Click += new System.EventHandler(this.delRouteButton_Click);
            // 
            // truncateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.delRouteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.truncButton3);
            this.Controls.Add(this.truncButton2);
            this.Controls.Add(this.truncButton1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "truncateForm";
            this.Text = "Вікно повного очищення таблиць";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button truncButton2;
        private System.Windows.Forms.Button truncButton1;
        private System.Windows.Forms.Button truncButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delRouteButton;
    }
}