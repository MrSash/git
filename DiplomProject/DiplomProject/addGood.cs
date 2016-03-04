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
    public partial class addGood : Form
    {
        public addGood()
        {
            InitializeComponent();
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
                if (textBox1.Text == "") textBox1.Text = "NULL";
                if (textBox2.Text == "") textBox2.Text = "NULL";
                form2.getQuery("INSERT INTO [Информация о товаре] VALUES (" + form2.getRows("SELECT [Индекс товара] FROM [Информация о товаре]") + "," + textBox1.Text + "," + textBox2.Text + ")");
                addGood.ActiveForm.Hide();
                form2.Show();
                form1.getItems(form2.comboBox1);
                form2.comboBox1.Text = "Информация о товаре";
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
                addGood.ActiveForm.Hide();
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
