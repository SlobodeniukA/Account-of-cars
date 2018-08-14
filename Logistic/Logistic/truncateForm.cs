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
    public partial class truncateForm : Form
    {
        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public truncateForm(SqlConnection sql)
        {
            InitializeComponent();
            sqlCnn = sql;
            truncButton1.Enabled = false;
            truncButton2.Enabled = false;
            truncButton3.Enabled = false;
            delRouteButton.Enabled = false;
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

        private void truncButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "TRUNCATE TABLE Автомобіль";
            cmd.ExecuteNonQuery();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "TRUNCATE TABLE Рейс";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Усі дані з таблиці 'Автомобіль' та 'Рейс' успішно видалені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void truncButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "TRUNCATE TABLE Водій";
            cmd.ExecuteNonQuery();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "TRUNCATE TABLE Рейс";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Усі дані з таблиці 'Водій' та 'Рейс' успішно видалені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                truncButton1.Enabled = true;
                truncButton2.Enabled = true;
                truncButton3.Enabled = true;

                delRouteButton.Enabled = true;
            }
            else
            {
                truncButton1.Enabled = false;
                truncButton2.Enabled = false;
                truncButton3.Enabled = false;

                delRouteButton.Enabled = false;
            }
        }

        private void truncButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "TRUNCATE TABLE Рейс";
            cmd.ExecuteNonQuery();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Водій set Статус = N'Вільний'";
            cmd.ExecuteNonQuery();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update Автомобіль set Статус = N'Вільний'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Усі дані з таблиці 'Рейс' успішно видалені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delRouteButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE  FROM Рейс WHERE [Статус]= N'Виконаний'";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Усі виконані рейси успішно видалені!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
