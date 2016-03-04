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
    public partial class addDeal : Form
    {
        public addDeal()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void FormAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                Form1 form1 = new Form1();
                
                if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("Обязательные поля не заполнены!");
                }
                else
                {
                    if (textBox4.Text == "") textBox4.Text = "NULL";
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    {
                        textBox1.Text = "NULL"; textBox2.Text = "NULL"; textBox3.Text = "NULL";
                    }
                    form2.getQuery("INSERT INTO [Сделки] VALUES (" + form2.getRows("SELECT [Номер сделки] FROM [Сделки]") +
                    "," + textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "," + "'" + comboBox1.Text + "'" + "," + "'" + comboBox1.Text + 
                    "'" + "," + "'" + comboBox1.Text + "'" + "," + textBox4.Text + ")");
                    addDeal.ActiveForm.Hide();
                    form2.Show();
                    form1.getItems(form2.comboBox1);
                    form2.comboBox1.Text = "Сделки";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПричина возникновения ошибки: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addDeal.ActiveForm.Hide();
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
    }
}
