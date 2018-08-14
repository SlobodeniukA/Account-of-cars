using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Logistic
{
    public partial class AddForm : Form
    {
        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddForm(SqlConnection sql)
        {
            InitializeComponent();
            sqlCnn = sql;

            tableComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string comboData;
            SqlCommand sqlCommand;

            switch (tableComboBox.SelectedIndex)
            {
                case 0:
                    {
                        string query = "SELECT COUNT(*) FROM Автомобіль WHERE Номерний_знак = '" + addTextBox1.Text + "';";
                        sqlCommand = new SqlCommand(query, sqlCnn);

                        object result = sqlCommand.ExecuteScalar();
                        int counter = Convert.ToInt32(result);

                        if (counter > 0)
                        {
                            MessageBox.Show("Номерний знак автомобіля не може повторюватись!\nМожливо автомобіль вже є в базі даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            addTextBox1.Text = "";
                        }
                        else
                        {
                             comboData = statusComboBox.Items[statusComboBox.SelectedIndex].ToString();
                             sqlCommand.CommandText = "INSERT INTO Автомобіль VALUES " + "(N'" + addTextBox1.Text + "', N'" + addTextBox2.Text + "', N'" +  addTextBox3.Text + "', N'" +  addTextBox4.Text + "', N'" +  comboData + "')";
                             sqlCommand.ExecuteNonQuery();
                             MessageBox.Show("Дані успішно додані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case 1:
                    {
                        statusComboBox.SelectedIndex = 0;
                        sqlCommand = new SqlCommand();
                        sqlCommand.CommandText = "INSERT INTO Водій VALUES (N'" + addTextBox1.Text + "',N'" + addTextBox2.Text + "',N'" + statusComboBox.Text + "')";
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Дані успішно додані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tableComboBox.SelectedIndex)
            {
                case 0:
                    {
                        statusComboBox.Items.Clear();

                        statusComboBox.Text = "Вільний";
                        labelAddName1.Text = "Номерний знак";
                        labelAddName2.Text = "Марка";
                        labelAddName3.Text = "Вантажопідйомність";
                        labelAddName4.Text = "Витрата палива на 100км";
                        labelAddName5.Text = "Статус";

                        statusComboBox.Items.Add("Вільний");
                        statusComboBox.Items.Add("Ремонт");

                        addTextBox1.Enabled = true;
                        addTextBox2.Enabled = true;
                        addTextBox3.Enabled = true;
                        addTextBox4.Enabled = true;

                        addTextBox1.Text = "";
                        addTextBox2.Text = "";
                        addTextBox3.Text = "";
                        addTextBox4.Text = "";

                        break;
                    }
                case 1:
                    {
                        statusComboBox.Items.Clear();

                        statusComboBox.Text = "Вільний";
                        labelAddName1.Text = "ПІБ";
                        labelAddName2.Text = "Стаж(рік)";
                        labelAddName3.Text = "";
                        labelAddName4.Text = "";
                        labelAddName5.Text = "Статус";

                        addTextBox1.Enabled = true;
                        addTextBox2.Enabled = true;
                        addTextBox3.Enabled = false;
                        addTextBox4.Enabled = false;

                        statusComboBox.Items.Add("Вільний");
                        statusComboBox.Items.Add("Відпустка");
                        addTextBox1.Text = "";
                        addTextBox2.Text = "";
                        addTextBox3.Text = "";
                        addTextBox4.Text = "";

                        break;
                    }
            }
        }

        private void addTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(tableComboBox.SelectedIndex == 0)
            {
                addTextBox1.MaxLength = 8;

                char l = e.KeyChar;

                if (addTextBox1.Text.Length < 2 || addTextBox1.Text.Length > 5)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);

                    if ((l < 'А' || l > 'я')  && l != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else if (addTextBox1.Text.Length > 1 && addTextBox1.Text.Length < 8)
                {
                    if ((l < '0' || l > '9') && l != '\b')
                    {
                        e.Handled = true;
                    }
                }
            }
            else if (tableComboBox.SelectedIndex == 1)
            {
                addTextBox1.MaxLength = 70;

                char l = e.KeyChar;

                if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
                {
                    e.Handled = true;
                }
            }
        }

        private void addTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (tableComboBox.SelectedIndex == 0)
            {
                addTextBox2.MaxLength = 70;

                    if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && (l < '0' || l > '9') && l != '\b' && l != ' ')
                    {
                        e.Handled = true;
                    }
            }
            else if (tableComboBox.SelectedIndex == 1)
            {
                addTextBox2.MaxLength = 2;

                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void addTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            addTextBox3.MaxLength = 10;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void addTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            addTextBox4.MaxLength = 5;

            if (e.KeyChar == '.')
            {
                if ((addTextBox4.Text.IndexOf('.') != -1) || (addTextBox4.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }
            if ((l < '0' || l > '9') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void statusComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tableComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
