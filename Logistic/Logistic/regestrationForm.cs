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
    public partial class regestrationForm : Form
    {
        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public regestrationForm(SqlConnection sql)
        {
            InitializeComponent();
            sqlCnn = sql;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singUpButton_Click(object sender, EventArgs e)
        {
            string Login = loginTextBox.Text;

            if (loginTextBox.Text.Length == 0 || passwordTextBox1.Text.Length ==0 || dubpasswordTextBox2.Text.Length == 0)
            {
                MessageBox.Show("Потрібно заповнити всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(passwordTextBox1.Text == dubpasswordTextBox2.Text)
                {
                   try
                   {
                        sqlCnn.Open();
                        string query = "SELECT COUNT(*) FROM Користувачі WHERE Логін = '" + loginTextBox.Text + "';";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlCnn);

                        object result = sqlCommand.ExecuteScalar();
                        int counter = Convert.ToInt32(result);

                        if (counter == 1)
                        {
                            MessageBox.Show("Даний користувач вже зареєстрований в системі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            query = "INSERT INTO Користувачі "
                                    + "([Логін], [Пароль], [Рівень_доступу])" +
                                    "VALUES" +
                                    "(N'" + loginTextBox.Text + "', N'"
                                    + passwordTextBox1.Text + "', N'"
                                    + "Користувач" + "')";

                            sqlCommand = new SqlCommand(query, sqlCnn);
                            sqlCommand.ExecuteNonQuery();

                            MessageBox.Show("Користувач - '" + loginTextBox.Text + "' успішно зареєстрований в системі!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                   }
                   catch
                   {
                        MessageBox.Show("Упс, база даних не підключена!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                   finally
                   {
                        sqlCnn.Close();
                   }
                }
                else
                {
                    MessageBox.Show("Паролі не співпадають!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (loginTextBox.Text.Length < 2)
            {
                if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b')
                {
                    e.Handled = true;
                }
            }
            else if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
                e.Handled = true;
        }

        private void passwordTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void dubpasswordTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
