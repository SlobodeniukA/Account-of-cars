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
    public partial class routeForm : Form
    {
        SqlConnection sqlCnn;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public routeForm(SqlConnection sql)
        {
            InitializeComponent();
            sqlCnn = sql;
            fillAutoComboBox();
            fillDriverComboBox();
        }

        private void fillAutoComboBox()
        {
            try
            {
                string query = "Select Марка From Автомобіль where Статус = N'Вільний'";

                SqlCommand cmd = new SqlCommand(query, sqlCnn);
                SqlDataReader myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string name = myReader.GetString(myReader.GetOrdinal("Марка"));
                    comboBoxAuto.Items.Add(name);
                }
                myReader.Close();
            }
            catch
            {
                MessageBox.Show("Для стоврення поїздки не вистачає ресурсів!\n Зачекайте на закінчення рейсу", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void fillDriverComboBox()
        {
            try
            {
                string query = "Select ПІБ From Водій where Статус = N'Вільний'";

                SqlCommand cmd = new SqlCommand(query, sqlCnn);
                SqlDataReader myDriverReader = cmd.ExecuteReader();

                while (myDriverReader.Read())
                {
                    string dName = myDriverReader.GetString(myDriverReader.GetOrdinal("ПІБ"));
                    comboBoxDriver.Items.Add(dName);
                }
                myDriverReader.Close();
            }
            catch
            {
                MessageBox.Show("Для стоврення поїздки не вистачає ресурсів!\n Зачекайте на закінчення рейсу", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime dtPicker1 = dateTimePicker1.Value;
            DateTime dtPicker2 = dateTimePicker2.Value;
            DateTime dtNow = DateTime.Now;

            if (comboBoxDriver.Text.Length != 0 && comboBoxAuto.Text.Length != 0 && dateTimePicker1.Text.Length != 0 && dateTimePicker2.Text.Length != 0 && textBoxDestination.Text.Length != 0 && textBoxDeparturePoint.Text.Length != 0 && textBoxArticle.Text.Length != 0 && textBoxCost.Text.Length != 0)
            {
                if (dtPicker1 > dtNow && dtPicker2 > dtNow || dtPicker1 == dtNow && dtPicker2 == dtNow)
                {

                    if (dtPicker1 < dtPicker2 || dtPicker1 == dtPicker2)
                    {
                        double cost = Convert.ToDouble(textBoxCost.Text);
                        string costText = textBoxCost.Text.Replace(",", ".");

                        SqlCommand cmd = sqlCnn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT ID_водія FROM Водій WHERE ПІБ = N'" + comboBoxDriver.Text + "'";

                        int id = Convert.ToInt16(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT Номерний_знак FROM Автомобіль WHERE Марка = N'" + comboBoxAuto.Text + "'";

                        string carNumber = cmd.ExecuteScalar().ToString();
                        cmd.CommandText = "INSERT INTO Рейс VALUES " + "(N'" + id + "', N'" + comboBoxDriver.Text + "', N'" + carNumber + "', N'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', N'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', N'" + textBoxDestination.Text + "', N'" + textBoxDeparturePoint.Text + "', N'" + costText + "', N'" + textBoxArticle.Text + "', N'Не виконаний')";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "UPDATE Водій SET Статус = N'Зайнятий' Where ID_водія = N'" + id + "'";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "UPDATE Автомобіль SET  Статус = N'Зайнятий' Where Номерний_знак = N'" + carNumber + "'";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Дані успішно додані!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBoxDestination.Clear();
                        textBoxDeparturePoint.Clear();
                        textBoxArticle.Clear();
                        comboBoxDriver.Text = "";
                        comboBoxAuto.Text = "";
                        textBoxCost.Clear();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Дата відправлення не може бути меньшою дати прибуття!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не можливо виставити рейс заднім числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Заповніть всі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Номерний_знак FROM Автомобіль WHERE Марка = N'" + comboBoxAuto.Text + "'";

            labelShowNumber.Text = "Номер автомобіля : " + cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT Вантажопідйомність FROM Автомобіль WHERE Марка = N'" + comboBoxAuto.Text + "'";

            weightLabel.Text = "Вантажопідйомність(тонни) : " + cmd.ExecuteScalar().ToString();

            cmd.CommandText = "SELECT Витрата_палива_на_100км FROM Автомобіль WHERE Марка = N'" + comboBoxAuto.Text + "'";

            petrolLabel.Text = "Витрата палива на 100км(літри) : " + cmd.ExecuteScalar().ToString();
        }

        private void comboBoxDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [Стаж(рік)] FROM Водій WHERE ПІБ = N'" + comboBoxDriver.Text + "'";

            labelShowExperience.Text = "Досвід роботи (роки) : " + cmd.ExecuteScalar();
        }

        private void comboBoxDriver_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxAuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxDeparturePoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxArticle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && (l < '0' || l > '9') && (l < 'A' || l > 'z') && l != '\b' && l != 'ї' && l != 'і' && l != 'Ї' && l != 'І' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (e.KeyChar == ',')
            {
                if ((textBoxCost.Text.IndexOf(',') != -1) || (textBoxCost.Text.Length == 0))
                {
                    e.Handled = true;
                }
                return;
            }

            if ((l < '0' || l > '9') && l != '\b' && l != ',')
            {
                e.Handled = true;
            }
        }
    }
}
