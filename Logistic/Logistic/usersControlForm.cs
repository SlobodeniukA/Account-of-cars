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
    public partial class usersControlForm : Form
    {
        SqlConnection sqlCnn;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public usersControlForm(SqlConnection sql)
        {
            InitializeComponent();
            sqlCnn = sql;

            refreshUsersTab();

            comboBox1.SelectedIndex = 0;

            deleteButton.Enabled = false;
            changeButton.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void refreshUsersTab()
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Логін, [Рівень_доступу] FROM Користувачі";
            cmd.ExecuteNonQuery();

            DataTable DT = new DataTable();
            SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
            SqlDA.Fill(DT);

            dataGridView1.DataSource = DT;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            string outputData = dataGridView1[0, row].Value.ToString();

            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Логін FROM Користувачі WHERE Логін = '" + outputData + "'";

            userNameLabel.Text = cmd.ExecuteScalar().ToString();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (userNameLabel.Text != "admin")
            {
                try
                {
                    SqlCommand cmd = sqlCnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Update Користувачі Set Рівень_доступу = N'" + comboBox1.Text + "' Where Логін = '" + userNameLabel.Text + "';";
                    cmd.ExecuteNonQuery(); 

                    refreshUsersTab();
                }
                catch
                {
                    MessageBox.Show("Оберіть користувача!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Рівень доступу користувача 'admin' не можна змінити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            userNameLabel.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userNameLabel.Text != "admin")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE  FROM Користувачі WHERE Логін ='" + userNameLabel.Text + "'";
                cmd.ExecuteNonQuery();

                refreshUsersTab();
            }
            else
            {
                MessageBox.Show("Користувача 'admin' не можна видалити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            deleteCheckBox.Checked = false;

            userNameLabel.Text = "";
        }

        private void deleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteCheckBox.Checked)
            {
                deleteButton.Enabled = true;
            }
            else
            {
                deleteButton.Enabled = false;
            }
        }

        private void userNameLabel_TextChanged(object sender, EventArgs e)
        {
            if (userNameLabel.Text.Length > 0)
            {
                changeButton.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                deleteCheckBox.Checked = false;
                deleteButton.Enabled = false;
                changeButton.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
