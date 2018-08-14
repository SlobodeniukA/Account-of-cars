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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace Logistic
{
    public partial class MainForm : Form
    {
        SqlConnection sqlCnn;
        SqlDataAdapter SqlDA;
        DataTable DT;


        int countRefreshTabPage1 = 1;
        int countRefreshTabPage2 = 0;
        int countRefreshTabPage3 = 0;

        int btnOpenCount = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        int windowStateCount = 0;
        string activeTabPage = "tabPage1";

        public MainForm(SqlConnection sql)
        {
            InitializeComponent();

            sqlCnn = sql;
            refreshAutoTab();
            refreshDriverTab();
            refreshRouteTab();

            deleteButton.Enabled = false;
            textBoxFilter.Enabled = false;
            dellabel.Text = "Введіть номерний знак автомобіля";
            editButton.Enabled = true;

            radioButton1.Text = "Вільні автомобілі";
            radioButton2.Text = "Зайняті автомобілі";
            radioButton3.Text = "Автомобілі на ремонті";
            radioButton4.Text = "Всі автомобілі";
            radioButton4.Enabled = true;
            radioButton4.Checked = true;

            changeStatusButton.Enabled = false;

        }
        public void accessLevel(string level)
        {
            if (level == "Користувач")
            {
                addButton.Enabled = false;
                truncateButton.Enabled = false;
                editButton.Enabled = false;
                groupBox1.Enabled = false;
                routeButton.Enabled = false;
                usersControlButton.Enabled = false;
                exportButton.Enabled = false;
                btnOpenCount = 1;
                changeStatusButton.Enabled = false;
            }
            else if (level == "Менеджер")
            {
                addButton.Enabled = true;
                truncateButton.Enabled = false;
                editButton.Enabled = true;
                groupBox1.Enabled = true;
                routeButton.Enabled = true;
                usersControlButton.Enabled = false;
                exportButton.Enabled = true;
                changeStatusButton.Visible = true;
            }

            else if (level == "Адміністратор")
            {
                addButton.Enabled = true;
                truncateButton.Enabled = true;
                editButton.Enabled = true;
                groupBox1.Enabled = true;
                routeButton.Enabled = true;
                usersControlButton.Enabled = true;
                exportButton.Enabled = true;
                changeStatusButton.Visible = true;
            }
        }

        private void refreshAutoTab()
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Автомобіль";
            cmd.ExecuteNonQuery();

            DataTable DT = new DataTable();
            SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
            SqlDA.Fill(DT);

            dataGridView1.DataSource = DT;
        }

        private void refreshDriverTab()
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Водій";
            cmd.ExecuteNonQuery();

            DataTable DT = new DataTable();
            SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
            SqlDA.Fill(DT);

            dataGridView2.DataSource = DT;
        }

        private void refreshRouteTab()
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Рейс";
            cmd.ExecuteNonQuery();

            DataTable DT = new DataTable();
            SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
            SqlDA.Fill(DT);

            dataGridView3.DataSource = DT;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (windowStateCount % 2 == 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            windowStateCount++;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm x = new AddForm(sqlCnn);
            x.ShowDialog();

            refreshAutoTab();
            refreshDriverTab();
        }

        private void truncateButton_Click(object sender, EventArgs e)
        {
            truncateForm x = new truncateForm(sqlCnn);
            x.ShowDialog();

            refreshAutoTab();
            refreshDriverTab();
            refreshRouteTab();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            countRefreshTabPage2 = 0;
            countRefreshTabPage3 = 0;

            activeTabPage = "tabPage1";
            if(btnOpenCount == 1)
            { 
                editButton.Enabled = false;
              
            }
            else
            {
                editButton.Enabled = true;
               
            }

            dellabel.Text = "Введіть номерний знак автомобіля";

            radioButton1.Text = "Вільні автомобілі";
            radioButton2.Text = "Зайняті автомобілі";
            radioButton3.Text = "Автомобілі на ремонті";
            radioButton4.Text = "Всі автомобілі";

            changeStatusButton.Enabled = false;
            radioButton4.Enabled = true;

            deleteTextBox.Clear();
            
            if (countRefreshTabPage1 == 0 )
            {
                radioButton4.Checked = true;
            }
            countRefreshTabPage1++;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            countRefreshTabPage1 = 0;
            countRefreshTabPage3 = 0;

            activeTabPage = "tabPage2";
            if (btnOpenCount == 1)
            {
                editButton.Enabled = false;
            }
            else
            {
                editButton.Enabled = true;
            }
            dellabel.Text = "Введіть ID водія";
            radioButton1.Text = "Вільні водії";
            radioButton2.Text = "Зайняті водії";
            radioButton3.Text = "Водії у відпустці";
            radioButton4.Text = "Всі водії";

            radioButton4.Enabled = true;

            deleteTextBox.Clear();
            
            changeStatusButton.Enabled = false;

            if (countRefreshTabPage2 == 0)
            {
                radioButton4.Checked = true;
            }
            countRefreshTabPage2++;
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            countRefreshTabPage1 = 0;
            countRefreshTabPage2 = 0;

            activeTabPage = "tabPage3";
            if (btnOpenCount == 1)
            {
                editButton.Enabled = false;
                changeStatusButton.Enabled = false;
            }
            else
            {
                editButton.Enabled = true;
                changeStatusButton.Enabled = true;
            }

            dellabel.Text = "Введіть ID рейсу";
            radioButton1.Text = "Виконані рейси";
            radioButton2.Text = "Не виконані рейси";
            radioButton3.Text = "Всі рейси";
            radioButton4.Text = "";

            deleteTextBox.Clear();

            radioButton4.Enabled = false;
            if (countRefreshTabPage3 == 0)
            {
                radioButton3.Checked = true;
            }
            countRefreshTabPage3++;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (activeTabPage == "tabPage1")
            {
                cmd.CommandText = "SELECT Статус FROM Автомобіль WHERE Номерний_знак = N'" + deleteTextBox.Text + "'";

                string status = cmd.ExecuteScalar().ToString();

                if (status != "Зайнятий")
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM [Автомобіль]  WHERE [Номерний_знак] = N'" + deleteTextBox.Text + "'; ";
                    cmd.ExecuteNonQuery();

                    object res = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(res);

                    if (count == 1)
                    {
                        cmd.CommandText = "DELETE  FROM Автомобіль WHERE [Номерний_знак]= N'" + deleteTextBox.Text + "'";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Автомобіль успішно видалений ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вірний номер автомобіля ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не можливо видалити автомобіль, що виконує завдання в цей момент", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (activeTabPage == "tabPage2")
            {
                cmd.CommandText = "SELECT Статус FROM Водій WHERE ID_водія = N'" + deleteTextBox.Text + "'";

                string status = cmd.ExecuteScalar().ToString();

                if (status != "Зайнятий")
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM [Водій]  WHERE [ID_водія] = N'" + deleteTextBox.Text + "'; ";
                    cmd.ExecuteNonQuery();

                    object res = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(res);

                    if (count == 1)
                    {
                        cmd.CommandText = "DELETE  FROM Водій WHERE [ID_водія]= N'" + deleteTextBox.Text + "'";
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Водій успішно видалений ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вірний ID водія ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не можливо видалити водія, який виконує завдання в цей момент", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (activeTabPage == "tabPage3")
            {
                cmd.CommandText = "SELECT COUNT(*) FROM [Рейс]  WHERE [ID_рейсу] = N'" + deleteTextBox.Text + "'; ";

                cmd.ExecuteNonQuery();

                object res = cmd.ExecuteScalar();
                int count = Convert.ToInt32(res);

                if (count == 1)
                {
                    cmd.CommandText = "SELECT ID_водія FROM Рейс WHERE ID_рейсу = N'" + deleteTextBox.Text + "'";
                    int driverId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "UPDATE Водій SET Статус = N'Готовий' Where ID_водія = N'" + driverId + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT Номерний_знак_автомобіля FROM Рейс WHERE ID_рейсу = N'" + deleteTextBox.Text + "'";
                    string autoNumber = cmd.ExecuteScalar().ToString();

                    cmd.CommandText = "UPDATE Автомобіль SET Статус = N'Готовий' Where Номерний_знак = N'" + autoNumber + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE  FROM Рейс WHERE [ID_рейсу]= N'" + deleteTextBox.Text + "'";
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Рейс успішно видалений ", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не вірний ID рейсу ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshRouteTab();
            refreshDriverTab();
            refreshAutoTab();

            deleteTextBox.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.рейсTableAdapter.Fill(this.logisticDBDataSet.Рейс);
            this.водійTableAdapter.Fill(this.logisticDBDataSet.Водій);
            this.автомобільTableAdapter.Fill(this.logisticDBDataSet.Автомобіль);
        }

        private void usersControlButton_Click(object sender, EventArgs e)
        {
            usersControlForm x = new usersControlForm(sqlCnn);
            x.ShowDialog();
        }

        private void comboBoxFilter_Enter(object sender, EventArgs e)
        {
            comboBoxFilter.Items.Clear();

            if (activeTabPage == "tabPage1")
            {
                comboBoxFilter.Items.AddRange(new string[] { "Номерний знак", "Марка" });
            }
            else if (activeTabPage == "tabPage2")
            {
                comboBoxFilter.Items.AddRange(new string[] { "ID Водія", "ПІБ", "Стаж" });
            }
            else if (activeTabPage == "tabPage3")
            {
                comboBoxFilter.Items.AddRange(new string[] { "ID Рейсу", "Дата в'їзду", "Дата виїзду", "Пункт призначення", "Пункт відправлення", "Номерний знак авто", "ПІБ водія", });
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            textBoxFilter.Enabled = true;

            if (activeTabPage == "tabPage1")
            {
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Автомобіль WHERE [Номерний_знак] LIKE '" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 1:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Автомобіль WHERE [Марка] LIKE N'" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                }
            }
            else if (activeTabPage == "tabPage2")
            {
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Водій  WHERE [ID_водія] LIKE '" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 1:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Водій  WHERE [ПІБ] LIKE N'%" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 2:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Водій  WHERE [Стаж(рік)] LIKE '" + textBoxFilter.Text + "'", sqlCnn);
                            break;
                        }
                }
            }
            else if (activeTabPage == "tabPage3")
            {
                switch (comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс  WHERE [ID_рейсу] LIKE '" + textBoxFilter.Text + "'", sqlCnn);
                            break;
                        }
                    case 1:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE Дата_відправлення LIKE '%" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 2:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE Дата_прибуття LIKE '%" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 3:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE Пункт_призначення LIKE N'" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 4:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE Пункт_відправлення LIKE N'" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 5:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE Номерний_знак_автомобіля LIKE  '" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                    case 6:
                        {
                            SqlDA = new SqlDataAdapter("SELECT * FROM Рейс WHERE ПІБ_Водія LIKE N'" + textBoxFilter.Text + "%'", sqlCnn);
                            break;
                        }
                }
                if(comboBoxFilter.Text.Length == 0)
                {
                    textBoxFilter.Clear();
                }
            }

            DT = new DataTable();
            SqlDA.Fill(DT);

            if (activeTabPage == "tabPage1")
            {
                dataGridView1.DataSource = DT;
            }
            else if (activeTabPage == "tabPage2")
            {
                dataGridView2.DataSource = DT;
            }
            else if (activeTabPage == "tabPage3")
            {
                dataGridView3.DataSource = DT;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (activeTabPage == "tabPage1")
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                string outputData = dataGridView1[0, row].Value.ToString();
                string licensePlate, carBrand, status;
                double loadCapacity, fuelConsumption;

                cmd.CommandText = "SELECT Номерний_знак FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";
                licensePlate = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT Марка FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";
                carBrand = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT Вантажопідйомність FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";
                loadCapacity = Convert.ToDouble(cmd.ExecuteScalar());

                cmd.CommandText = "SELECT Витрата_палива_на_100км FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";
                fuelConsumption = Convert.ToDouble(cmd.ExecuteScalar());

                cmd.CommandText = "SELECT Статус FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";
                status = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT Статус FROM Автомобіль WHERE Номерний_знак = N'" + outputData + "'";

                string statusForClose = cmd.ExecuteScalar().ToString();

                if (statusForClose != "Зайнятий")
                {
                    editAutoForm ef = new editAutoForm(sqlCnn, licensePlate, carBrand, loadCapacity, fuelConsumption, status);
                    ef.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не можливо редагувати дані автомобіля, що виконує завдання в цей момент", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (activeTabPage == "tabPage2")
            {
                int row = dataGridView2.CurrentCell.RowIndex;
                string outputData = dataGridView2[0, row].Value.ToString();
                string name, status;
                int driverId, experience;

                cmd.CommandText = "SELECT ID_водія FROM Водій WHERE ID_водія = N'" + outputData + "'";
                driverId = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "SELECT ПІБ FROM Водій WHERE ID_водія = N'" + outputData + "'";
                name = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT [Стаж(рік)] FROM Водій WHERE ID_водія = N'" + outputData + "'";
                experience = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "SELECT Статус FROM Водій WHERE ID_водія = N'" + outputData + "'";
                status = cmd.ExecuteScalar().ToString();

                if (status != "Зайнятий")
                {
                    editDriverForm ef = new editDriverForm(sqlCnn, driverId, name, experience, status);
                    ef.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не можливо редагувати дані водія, що виконує завдання в цей момент", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            refreshAutoTab();
            refreshDriverTab();
            refreshRouteTab();
        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            routeForm x = new routeForm(sqlCnn);
            x.ShowDialog();
            refreshRouteTab();
        }

        private void deleteTextBox_TextChanged(object sender, EventArgs e)
        {

            if (deleteTextBox.Text.Length == 0)
            {
                deleteButton.Enabled = false;
            }
            else
            {
                deleteButton.Enabled = true;
            }

        }
        private void deleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (activeTabPage == "tabPage1")
            {
                deleteTextBox.MaxLength = 8;

                char l = e.KeyChar;

                if (deleteTextBox.Text.Length < 2 || deleteTextBox.Text.Length > 5)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);

                    if ((l < 'А' || l > 'я') && l != '\b')
                    {
                        e.Handled = true;
                    }
                }
                else if (deleteTextBox.Text.Length > 1 && deleteTextBox.Text.Length < 8)
                {
                    if ((l < '0' || l > '9') && l != '\b')
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                char l = e.KeyChar;

                if ((l < '0' || l > '9') && l != '\b')
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && (l < '0' || l > '9') && l != '\b' && l != ' ' && l != '.' && l != ',')
            {
                e.Handled = true;
            }
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxFilter.Text.Length == 0)
            {
                textBoxFilter.Enabled = false;
            }
            else
            {
                textBoxFilter.Enabled = true;
            }

            textBoxFilter.Clear();
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sqlCnn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (activeTabPage == "tabPage3")
            {
                int row = dataGridView3.CurrentCell.RowIndex;
                string id = dataGridView3[0, row].Value.ToString();
                string status;

                cmd.CommandText = "SELECT Статус FROM Рейс WHERE ID_рейсу = N'" + id + "'";
                status = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT ID_водія FROM Рейс WHERE ID_рейсу = N'" + id + "'";
                int driverId = Convert.ToInt16(cmd.ExecuteScalar());

                cmd.CommandText = "SELECT Номерний_знак_автомобіля FROM Рейс WHERE ID_рейсу = N'" + id + "'";
                string carNumber = cmd.ExecuteScalar().ToString();

                if (status != "Виконаний")
                {
                    cmd.CommandText = "UPDATE Рейс SET [Статус] = N'Виконаний' WHERE ID_рейсу = N'" + id + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Водій SET Статус = N'Вільний' Where ID_водія = N'" + driverId + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "UPDATE Автомобіль SET  Статус = N'Вільний' Where Номерний_знак = N'" + carNumber + "'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Рейс, який має id - " + id + " вже виконаний!" , "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                refreshRouteTab();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            comboBoxFilter.Text = "";

            if (activeTabPage == "tabPage1")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Автомобіль where Статус = N'Вільний'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView1.DataSource = DT;
            }
            else if (activeTabPage == "tabPage2")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Водій where Статус = N'Вільний'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView2.DataSource = DT;
            }
            else if (activeTabPage == "tabPage3")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Рейс where Статус = N'Виконаний'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView3.DataSource = DT;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            comboBoxFilter.Text = "";

            if (activeTabPage == "tabPage1")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Автомобіль where Статус = N'Зайнятий'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView1.DataSource = DT;
            }
            else if (activeTabPage == "tabPage2")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Водій where Статус = N'Зайнятий'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView2.DataSource = DT;
            }
            else if (activeTabPage == "tabPage3")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Рейс where Статус = N'Не виконаний'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView3.DataSource = DT;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            comboBoxFilter.Text = "";

            if (activeTabPage == "tabPage1")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Автомобіль where Статус = N'Ремонт'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView1.DataSource = DT;
            }
            else if (activeTabPage == "tabPage2")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Водій where Статус = N'Відпустка'";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView2.DataSource = DT;
            }
            else if (activeTabPage == "tabPage3")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Рейс";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView3.DataSource = DT;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            comboBoxFilter.Text = "";
            if (activeTabPage == "tabPage1")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Автомобіль";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView1.DataSource = DT;
            }
            else if (activeTabPage == "tabPage2")
            {
                SqlCommand cmd = sqlCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Водій";
                cmd.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter SqlDA = new SqlDataAdapter(cmd);
                SqlDA.Fill(DT);

                dataGridView2.DataSource = DT;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application export = new Excel.Application();
                string name;
                if (activeTabPage == "tabPage1")
                {
                    export.Workbooks.Open(Environment.CurrentDirectory + @"\templateAuto.xls");
                    Excel.Worksheet activeSheet = (Excel.Worksheet)export.ActiveSheet;

                    activeSheet.Cells[1, 1] = "Дані з таблиці автомобілів";

                    if (radioButton1.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton4.Text;
                    }

                    activeSheet.Cells[4, 1] = "Номерний знак";
                    activeSheet.Cells[4, 2] = "Марка";
                    activeSheet.Cells[4, 3] = "Вантажопідйомність";
                    activeSheet.Cells[4, 4] = "Витрата палива на 100км";
                    activeSheet.Cells[4, 5] = "Статус";

                    int rowExcel = 5;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        activeSheet.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells["Номерний_знак"].Value;
                        activeSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells["Марка"].Value;
                        activeSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells["Вантажопідйомність"].Value;
                        activeSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells["Витрата_палива_на_100км"].Value;
                        activeSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells["Статус"].Value;

                        ++rowExcel;
                    }
                    if (radioButton1.Checked == true)
                    {
                        name = radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        name = radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        name = radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        name = radioButton4.Text;
                    }
                    else
                    {
                        name = "Вибірка з таблиці Водій";
                    }

                    activeSheet.SaveAs(name + ".xls");
                    export.Quit();

                    MessageBox.Show("Файл збережено в папці 'Мої документи'  під назвою '" + name + ".xls'", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (activeTabPage == "tabPage2")
                {
                    export.Workbooks.Open(Environment.CurrentDirectory + @"\templateDriver.xls");
                    Excel.Worksheet activeSheet = (Excel.Worksheet)export.ActiveSheet;

                    activeSheet.Cells[1, 1] = "Дані з таблиці водіїв";

                    if (radioButton1.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton4.Text;
                    }

                    activeSheet.Cells[4, 1] = "ID_водія";
                    activeSheet.Cells[4, 2] = "ПІБ";
                    activeSheet.Cells[4, 3] = "Стаж(рік)";
                    activeSheet.Cells[4, 4] = "Статус";

                    int rowExcel = 5;

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        activeSheet.Cells[rowExcel, "A"] = dataGridView2.Rows[i].Cells["ID_водія"].Value;
                        activeSheet.Cells[rowExcel, "B"] = dataGridView2.Rows[i].Cells["ПІБ"].Value;
                        activeSheet.Cells[rowExcel, "C"] = dataGridView2.Rows[i].Cells["Стаж(рік)"].Value;
                        activeSheet.Cells[rowExcel, "D"] = dataGridView2.Rows[i].Cells["Статус"].Value;
                        ++rowExcel;
                    }
                    if (radioButton1.Checked == true)
                    {
                        name = radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        name = radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        name = radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        name = radioButton4.Text;
                    }
                    else
                    {
                        name = "Вибірка з таблиці Водій";
                    }

                    activeSheet.SaveAs(name + ".xls");
                    export.Quit();

                    MessageBox.Show("Файл збережено в папці 'Мої документи'  під назвою '" + name + ".xls'", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (activeTabPage == "tabPage3")
                {
                    export.Workbooks.Open(Environment.CurrentDirectory + @"\templateRoute.xls");
                    Excel.Worksheet activeSheet = (Excel.Worksheet)export.ActiveSheet;

                    activeSheet.Cells[1, 1] = "Дані з таблиці автомобілів";

                    if (radioButton1.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true && textBoxFilter.Text.Length == 0)
                    {
                        activeSheet.Cells[2, 1] = "Виведено : " + radioButton4.Text;
                    }

                    activeSheet.Cells[4, 1] = "ID_рейсу";
                    activeSheet.Cells[4, 2] = "ID_водія";
                    activeSheet.Cells[4, 3] = "[ПІБ_Водія]";
                    activeSheet.Cells[4, 4] = "[Дата_відправлення]";
                    activeSheet.Cells[4, 5] = "[Дата_прибуття]";
                    activeSheet.Cells[4, 6] = "[Пункт_відправлення]";
                    activeSheet.Cells[4, 7] = "[Пункт_призначення]";
                    activeSheet.Cells[4, 8] = "[Вартість]";
                    activeSheet.Cells[4, 9] = "[Товар]";
                    activeSheet.Cells[4, 10] = "[Статус]";

                    int rowExcel = 5;

                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        activeSheet.Cells[rowExcel, "A"] = dataGridView3.Rows[i].Cells["ID_рейсу"].Value;
                        activeSheet.Cells[rowExcel, "B"] = dataGridView3.Rows[i].Cells["ID_водія"].Value;
                        activeSheet.Cells[rowExcel, "C"] = dataGridView3.Rows[i].Cells["ПІБ_Водія"].Value;
                        activeSheet.Cells[rowExcel, "D"] = dataGridView3.Rows[i].Cells["Дата_відправлення"].Value;
                        activeSheet.Cells[rowExcel, "E"] = dataGridView3.Rows[i].Cells["Дата_прибуття"].Value;
                        activeSheet.Cells[rowExcel, "F"] = dataGridView3.Rows[i].Cells["Пункт_відправлення"].Value;
                        activeSheet.Cells[rowExcel, "G"] = dataGridView3.Rows[i].Cells["Пункт_призначення"].Value;
                        activeSheet.Cells[rowExcel, "H"] = dataGridView3.Rows[i].Cells["Вартість"].Value;
                        activeSheet.Cells[rowExcel, "I"] = dataGridView3.Rows[i].Cells["Товар"].Value;
                        activeSheet.Cells[rowExcel, "J"] = dataGridView3.Rows[i].Cells["Статус"].Value;

                        ++rowExcel;
                    }
                    if (radioButton1.Checked == true)
                    {
                        name = radioButton1.Text;
                    }
                    else if (radioButton2.Checked == true)
                    {
                        name = radioButton2.Text;
                    }
                    else if (radioButton3.Checked == true)
                    {
                        name = radioButton3.Text;
                    }
                    else if (radioButton4.Checked == true)
                    {
                        name = radioButton4.Text;
                    }
                    else
                    {
                        name = "Вибірка з таблиці Рейс";
                    }

                    activeSheet.SaveAs(name + ".xls");
                    export.Quit();

                    MessageBox.Show("Файл збережено в папці 'Мої документи'  під назвою '" + name + ".xls'", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Упс, помилка роботи програми!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
