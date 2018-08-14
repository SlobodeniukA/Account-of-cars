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
    public partial class editDriverForm : Form
    {

        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int id;

        public editDriverForm(SqlConnection sql, int driverId, string name, int experience, string status)
        {
            InitializeComponent();
            sqlCnn = sql;

            if (statusComboBox.Text == "Зайнятий")
            {
                statusComboBox.Enabled = false;
            }

            id = driverId;

            editTextBox1.Text = driverId.ToString();
            editTextBox2.Text = name;

            editTextBox3.Text = experience.ToString();
            statusComboBox.Text = status;

            editTextBox1.Enabled = false;
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
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Водій SET  ПІБ = N'" + editTextBox2.Text + "', [Стаж(рік)] = N'" + editTextBox3.Text + "', Статус = N'" + statusComboBox.Text + "' Where ID_водія = N'" + id + "'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Зміни виконано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void statusComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void editTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            editTextBox2.MaxLength = 70;

            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І')
            {
                e.Handled = true;
            }
        }

        private void editTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            editTextBox3.MaxLength = 2;

            char l = e.KeyChar;

            if ((l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
