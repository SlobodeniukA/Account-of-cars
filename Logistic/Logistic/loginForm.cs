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
using System.Threading;
using System.Data.SqlClient;

namespace Logistic
{
    public partial class loginForm : Form
    {
        SqlConnection sqlCnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory + @"\logisticDB.mdf;Integrated Security=True");

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public loginForm()
        {
            Thread splash_thread = new Thread(new ThreadStart(SplashStart));
            splash_thread.Start();
            Thread.Sleep(5000);
            splash_thread.Abort();

            InitializeComponent();
        }

        public void SplashStart()
        {
            Application.Run(new SplashScreen());
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

        private void button2_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            regestrationForm x = new regestrationForm(sqlCnn);
            x.ShowDialog();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length == 0 || passwordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Потрібно заповнити всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlCnn.Open();

                    string query = "SELECT COUNT(*) FROM Користувачі WHERE Логін = '" + loginTextBox.Text + "'and Пароль =  '" + passwordTextBox.Text + "';";
                    string level;

                    SqlCommand sqlCommand = new SqlCommand(query, sqlCnn);

                    object result = sqlCommand.ExecuteScalar();
                    int counter = Convert.ToInt32(result);

                    if (counter == 1)
                    {
                        sqlCommand.CommandText = "SELECT Рівень_доступу FROM Користувачі WHERE Логін = '" + loginTextBox.Text + "'and Пароль =  '" + passwordTextBox.Text + "';";
                        level = sqlCommand.ExecuteScalar().ToString();

                        loginTextBox.Text = "";
                        passwordTextBox.Text = "";

                        MainForm x = new MainForm(sqlCnn);
                        x.accessLevel(level);
                        x.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Не вірний логін чи пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Упс, помилка доступу до бази даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlCnn.Close();
                }
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
