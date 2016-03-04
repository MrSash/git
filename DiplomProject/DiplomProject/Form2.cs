using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace DiplomProject
{
    public partial class Form2 : Form
    {
        private SqlConnection con;
        private SqlDataAdapter da;
        private DataSet ds;

        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void getQuery(string str) // Метод запроса
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            SqlCommand cc = new SqlCommand(str, con);
            cc.ExecuteNonQuery();

            con.Close();
        }

        public string getRows(string str) // Метод подсчёта строк
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            int k = 0;
            string str2 = "";
            SqlCommand cc = new SqlCommand(str, con);
            SqlDataReader dr = cc.ExecuteReader();
            while (dr.Read())
            {
                k++;
                str2 = "" + (dr.GetInt32(0) + 1);
            }
            if (k == 0)
            {
                con.Close();
                return "1";
            }
            con.Close();
            return str2;
        }

        private void addBtn_Click(object sender, EventArgs e) // СНОС - ДОБАВЛЕНИЕ
        {
        }

        private void saveToExcelBtn_Click(object sender, EventArgs e) // СНОС - ЭКСЕЛЬ
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор таблицы
        {
            Form1 form1 = new Form1();
           /* MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);*/

            Form1.con.Open();

            da = new SqlDataAdapter("SELECT * FROM " + "[" + comboBox1.Text + "]", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            ds = new DataSet();
            ds.Tables.Add(new DataTable("[" + comboBox1.Text + "]"));
            da.Fill(ds, "[" + comboBox1.Text + "]");
            dataGridView1.DataSource = ds.Tables[0];

            Form1.con.Close();
        }

        private void label1_Click(object sender, EventArgs e) // СНОС - 1
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) // СНОС - 2
        {
        }

        private void tSMAddBuyer_Click(object sender, EventArgs e) // Добавить - Покупателя
        {
            try
            {
                Form2.ActiveForm.Hide();
                addBuyer addbuyer = new addBuyer();
                addbuyer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMAddSeller_Click(object sender, EventArgs e) // Добавить - Продавца
        {
            try
            {
                Form2.ActiveForm.Hide();
                addSeller addseller = new addSeller();
                addseller.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMAddGood_Click(object sender, EventArgs e) // Добавить - товар
        {
            try
            {
                Form2.ActiveForm.Hide();
                addGood addgood = new addGood();
                addgood.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMAddDeal_Click(object sender, EventArgs e) // Добавить - Сделку
        {
            try
            {
                Form2.ActiveForm.Hide();
                addDeal adddeal = new addDeal();
                comboBoxFiller(adddeal.comboBox1, "SELECT [Индекс продавца] FROM [Информация о продавцах]");
                comboBoxFiller(adddeal.comboBox2, "SELECT [Индекс покупателя] FROM [Информация о покупателях]");
                comboBoxFiller(adddeal.comboBox3, "SELECT [Индекс товара] FROM [Информация о товаре]");
                adddeal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        public void comboBoxFiller(ComboBox cbox, string str)
        {
            try
            {
                MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

                mysql.Server = Form1.server;
                mysql.Database = Form1.database;
                mysql.UserID = Form1.userid;
                mysql.Password = Form1.pass;

                con = new SqlConnection(mysql.ConnectionString);

                con.Open();

                SqlCommand cc = new SqlCommand(str, con);
                SqlDataReader dr = cc.ExecuteReader();

                cbox.Items.Clear();
                while (dr.Read())
                {
                    cbox.Items.Add(dr.GetInt32(0));
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMChangeServer_Click(object sender, EventArgs e) // Сменить сервер
        {
            try
            {
                Form2.ActiveForm.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private int numRows(string str)
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            int k = 0;
            SqlCommand cc = new SqlCommand(str, con);
            SqlDataReader dr = cc.ExecuteReader();

            while (dr.Read())
            {
                k++;
            }

            con.Close();
            return k;
        }

        private int numColumns(string str)
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            int k = 0;
            SqlCommand cc = new SqlCommand(str, con);
            SqlDataReader dr = cc.ExecuteReader();

            while(dr.Read())
            {
                k = dr.FieldCount;
            }

            con.Close();
            return k;
        }

        private string getCell(string str, int i, int j)
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            string str2 = "";
            int k = 0;
            SqlCommand cc = new SqlCommand(str, con);
            SqlDataReader dr = cc.ExecuteReader();
            while (dr.Read())
            {
                if(k == i) str2 = "" + dr.GetValue(j);
                k++;
            }

            con.Close();
            return str2;
        }

        private string getColumnName(string str, int i)
        {
            MySqlConnectionStringBuilder mysql = new MySqlConnectionStringBuilder();

            mysql.Server = Form1.server;
            mysql.Database = Form1.database;
            mysql.UserID = Form1.userid;
            mysql.Password = Form1.pass;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            string str2 = "";
            SqlCommand cc = new SqlCommand(str, con);
            SqlDataReader dr = cc.ExecuteReader();
            str2 = dr.GetName(i);

            con.Close();
            return str2;
        }

        private void tSMExportBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                string add = "SELECT * FROM [Информация о покупателях]";
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                if (numRows(add) == 0)
                {
                    MessageBox.Show("Таблица не содержит данных!");
                }
                else
                {
                    for (int i = 0; i < numColumns(add); i++)
                    {
                        ExcelApp.Cells[1, i + 1] = getColumnName(add, i);
                    }
                    for (int i = 0; i < numRows(add); i++)
                    {
                        for (int j = 0; j < numColumns(add); j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = getCell(add, i, j);
                        }
                    }
                    ExcelApp.Visible = true;
                    ExcelApp.UserControl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMExportSeller_Click(object sender, EventArgs e)
        {
            try
            {
                string add = "SELECT * FROM [Информация о продавцах]";
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                if (numRows(add) == 0)
                {
                    MessageBox.Show("Таблица не содержит данных!");
                }
                else
                {
                    for (int i = 0; i < numColumns(add); i++)
                    {
                        ExcelApp.Cells[1, i + 1] = getColumnName(add, i);
                    }
                    for (int i = 0; i < numRows(add); i++)
                    {
                        for (int j = 0; j < numColumns(add); j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = getCell(add, i, j);
                        }
                    }
                    ExcelApp.Visible = true;
                    ExcelApp.UserControl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMExportGood_Click(object sender, EventArgs e)
        {
            try
            {
                string add = "SELECT * FROM [Информация о товаре]";
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                if (numRows(add) == 0)
                {
                    MessageBox.Show("Таблица не содержит данных!");
                }
                else
                {
                    for (int i = 0; i < numColumns(add); i++)
                    {
                        ExcelApp.Cells[1, i + 1] = getColumnName(add, i);
                    }
                    for (int i = 0; i < numRows(add); i++)
                    {
                        for (int j = 0; j < numColumns(add); j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = getCell(add, i, j);
                        }
                    }
                    ExcelApp.Visible = true;
                    ExcelApp.UserControl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void tSMExportDeal_Click(object sender, EventArgs e)
        {
            try
            {
                string add = "SELECT * FROM [Сделки]";
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                if (numRows(add) == 0)
                {
                    MessageBox.Show("Таблица не содержит данных!");
                }
                else
                {
                    for (int i = 0; i < numColumns(add); i++)
                    {
                        ExcelApp.Cells[1, i + 1] = getColumnName(add, i);
                    }
                    for (int i = 0; i < numRows(add); i++)
                    {
                        for (int j = 0; j < numColumns(add); j++)
                        {
                            ExcelApp.Cells[i + 2, j + 1] = getCell(add, i, j);
                        }
                    }
                    ExcelApp.Visible = true;
                    ExcelApp.UserControl = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }
    }
}
