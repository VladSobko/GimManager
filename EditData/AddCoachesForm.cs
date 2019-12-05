using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Спортзал.EditData
{
    public partial class AddCoachesForm : Form
    {
        public AddCoachesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coach c = new Coach();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            c.SurName = textBox1.Text;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            c.Name = textBox2.Text;
            if (textBox3.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            c.SecondName = textBox3.Text;
            if (textBox4.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            c.Adres = textBox4.Text;
            if (textBox5.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int pn;
            try
            {
                pn = Int32.Parse(textBox5.Text);
            }
            catch
            {
                pn = 0;
            }
            c.PhoneNumber = pn;

            if (textBox6.Text == "")
            {
                MessageBox.Show("Заповність усі поля, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double s;
            try
            {
                s = Double.Parse(textBox6.Text);
            }
            catch{
                s = 0;
            }
            c.Salary = s;

            c.Data = dateTimePicker1.Value;

            Form1.db2.teachers.Add(c);

            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(textBox5.Text) && e.KeyChar == '+'))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(textBox6.Text) && e.KeyChar == '.'))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'Я') && (l < 'A' || l > 'Z') &&
                (l < 'а' || l > 'я') && (l < 'a' || l > 'z') && l != 'і' && l != 'є'
                && l != 'ё' && l != '\b' && l != 'І' && l != 'Є' && l != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'Я') && (l < 'A' || l > 'Z') &&
                (l < 'а' || l > 'я') && (l < 'a' || l > 'z') && l != 'і' && l != 'є'
                && l != 'ё' && l != '\b' && l != 'І' && l != 'Є' && l != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'Я') && (l < 'A' || l > 'Z') &&
                (l < 'а' || l > 'я') && (l < 'a' || l > 'z') && l != 'і' && l != 'є'
                && l != 'ё' && l != '\b' && l != 'І' && l != 'Є' && l != 8)
            {
                e.Handled = true;
            }
        }
    }
}
