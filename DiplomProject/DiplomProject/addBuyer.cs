using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class addBuyer : Form
    {

        public string addQuery = "INSERT INTO ";
        public int columnCounter;
        public string comboBoxData;

        public addBuyer()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("М");
            comboBox1.Items.Add("Ж");
            comboBox1.Items.Add("-");
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Text = "-";
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                addBuyer.ActiveForm.Hide();
                Form2 form2 = new Form2();
                Form1 form1 = new Form1();
                form2.Show();
                form1.getItems(form2.comboBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                Form1 form1 = new Form1();
                string tempstr = "";
                if (textBox1.Text == "") textBox1.Text = "NULL";
                if (textBox2.Text == "") textBox2.Text = "NULL";
                if (textBox3.Text == "") textBox3.Text = "NULL";
                if (textBox6.Text == "") textBox6.Text = "NULL";
                if (textBox7.Text == "") textBox7.Text = "NULL";
                if (textBox4.Text == "" || textBox5.Text == "" || textBox9.Text == "") 
                {
                    textBox4.Text = "NULL"; textBox5.Text = "NULL"; textBox9.Text = "NULL";
                }
                if (comboBox1.Text == "-")
                {
                    tempstr = "NULL";
                }
                else
                {
                    tempstr = "'" + comboBox1.Text + "'";
                }
                form2.getQuery("INSERT INTO [Информация о покупателях] VALUES (" + form2.getRows("SELECT [Индекс покупателя] FROM [Информация о покупателях]") + 
                    "," + textBox1.Text + "," + textBox2.Text +
                    "," + textBox3.Text + "," + textBox4.Text + "-" + textBox5.Text + "-" + textBox9.Text + "," + tempstr +
                    "," + textBox6.Text + "," + textBox7.Text + ")");
                addBuyer.ActiveForm.Hide();
                form2.Show();
                form1.getItems(form2.comboBox1);
                form2.comboBox1.Text = "Информация о покупателях";
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }
    }
}
