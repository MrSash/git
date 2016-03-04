using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DiplomProject
{
    public partial class Form1 : Form
    {
        public static string server, database, userid, pass;
        public static SqlConnection con;
        private Boolean check = true;
        private MySqlConnectionStringBuilder mysql;
        private SqlCommand cc;
        private SqlDataReader dr;

        public Form1() // Инициализация формы
        {
            InitializeComponent();
            tBPass.UseSystemPasswordChar = true;
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e) // Закрытие формы
        {
            Application.Exit();
        }
        
        private void joinBtn_Click(object sender, EventArgs e) // Кнопка входа
        {
            try
            {
                Form2 form2 = new Form2();

                mysql = new MySqlConnectionStringBuilder();

                server = mysql.Server = tBServer.Text;
                database = mysql.Database = tBBaseData.Text;
                userid = mysql.UserID = tBLogin.Text;
                pass = mysql.Password = tBPass.Text;

                con = new SqlConnection(mysql.ConnectionString);

                con.Open();
                con.Close();

                getItems(form2.comboBox1);
                Form1.ActiveForm.Hide();
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
                con.Close();
            }
        }

        public void getItems(ComboBox cbox) // Заполнение ComboBox
        {
            Form2 form2 = new Form2();

            mysql = new MySqlConnectionStringBuilder();

            server = mysql.Server = tBServer.Text;
            database = mysql.Database = tBBaseData.Text;
            userid = mysql.UserID = tBLogin.Text;
            pass = mysql.Password = tBPass.Text;

            con = new SqlConnection(mysql.ConnectionString);

            con.Open();

            cc = new SqlCommand("SELECT name FROM sys.objects WHERE type in (N'U')", con);
            dr = cc.ExecuteReader();

            cbox.Items.Clear();
            while (dr.Read())
            {
                cbox.Items.Add(dr["name"]);
            }

            con.Close();
        }

        private void clearTBBtn_Click(object sender, EventArgs e) // Очистка полей
        {
            tBServer.Text = "";
            tBBaseData.Text = "";
            tBLogin.Text = "";
            tBPass.Text = "";
        }

        private void checkPassBtn_Click(object sender, EventArgs e) // Показать или скрыть пароль
        {
            if (check)
            {
                tBPass.UseSystemPasswordChar = false;
                check = false;
            }
            else
            {
                tBPass.UseSystemPasswordChar = true;
                check = true;
            }
        }
    }
}
