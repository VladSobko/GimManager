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
    public partial class AddVisitorsForm : Form
    {
        public AddVisitorsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visitor v = new Visitor();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заповніть усі комірки, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            v.SurName = textBox1.Text;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Заповніть усі комірки, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            v.Name = textBox2.Text;
            if (textBox3.Text == "")
            {
                MessageBox.Show("Заповніть усі комірки, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            v.SecondName = textBox3.Text;
            if (textBox5.Text == "")
            {
                MessageBox.Show("Заповніть усі комірки, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            v.Adres = textBox5.Text;
            if (textBox6.Text == "")
            {
                MessageBox.Show("Заповніть усі комірки, будь ласка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int pn;
            try
            {
                pn = Int32.Parse(textBox6.Text);
                
            }
            catch
            {
                pn = 0000000000;
            }
            v.PhoneNumber = pn;

            
            v.Data = dateTimePicker1.Value;

            v.abonement = checkBox1.Checked;

            Form1.db1.sportsmens.Add(v);

            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || (!string.IsNullOrEmpty(textBox6.Text) ))
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
    }
}
