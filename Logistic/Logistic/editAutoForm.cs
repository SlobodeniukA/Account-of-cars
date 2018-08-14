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
    public partial class editAutoForm : Form
    {
        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string id;

        public editAutoForm(SqlConnection sql, string licensePlate, string carBrand, double loadCapacity, double fuelConsumption, string status)
        {
            InitializeComponent();
            sqlCnn = sql;
            id = licensePlate;

            editTextBox1.Text = licensePlate;
            editTextBox2.Text = carBrand;
            editTextBox3.Text = loadCapacity.ToString();
            editTextBox4.Text = fuelConsumption.ToString();

            statusComboBox.Text = status;

            editTextBox1.Enabled = false;

            if (statusComboBox.Text == "Зайнятий")
            {
                statusComboBox.Enabled = false;
            }
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

        private void editButton_Click(object sender, EventArgs e)
        {

            if (editTextBox2.Text.Length == 0 || editTextBox3.Text.Length == 0 || editTextBox4.Text.Length == 0)
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    SqlCommand cmd = sqlCnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Автомобіль SET  Марка = N'" + editTextBox2.Text + "', Вантажопідйомність = N'" + editTextBox3.Text + "', Витрата_палива_на_100км = N'" + editTextBox4.Text + "', Статус = N'" + statusComboBox.Text + "' Where Номерний_знак = N'" + id + "'" ;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Зміни виконано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            editTextBox1.MaxLength = 8;

            char l = e.KeyChar;

            if (editTextBox1.Text.Length < 2 || editTextBox1.Text.Length > 5)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);

                if ((l < 'A' || l > 'z') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if (editTextBox1.Text.Length > 1 && editTextBox1.Text.Length < 8)
            {
                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void editTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            editTextBox2.MaxLength = 70;

            if ((l < 'A' || l > 'z') && (l < 'А' || l > 'я') && (l < '0' || l > '9') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void editTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            editTextBox3.MaxLength = 10;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void editTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            editTextBox4.MaxLength = 5;

            if (e.KeyChar == '.')
            {
                if ((editTextBox4.Text.IndexOf('.') != -1) || (editTextBox4.Text.Length == 0))
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
    }
}
