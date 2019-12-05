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
    public partial class AddTrainingForm : Form
    {
        public AddTrainingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Train t = new Train();
            t.Data = dateTimePicker1.Value;
            t.Time = dateTimePicker2.Value;
            try { t.CoachName.SurName = comboBox1.Items[comboBox1.SelectedIndex].ToString(); }
            catch (Exception)
            {
                MessageBox.Show("text", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try { t.VisitorName.SurName = comboBox2.Items[comboBox2.SelectedIndex].ToString(); }
            catch (Exception)
            {
                MessageBox.Show("text", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            t.payment = checkBox1.Checked;
            Form1.db3.trainings.Add(t);

            Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = "HH:mm";
        }

        private void AddTrainingForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Form1.db2.teachers.Count; i++)
            {
                comboBox1.Items.Add(Form1.db2.teachers[i].SurName);
            }

            comboBox2.Items.Clear();
            for (int i = 0; i < Form1.db1.sportsmens.Count; i++)
            {
                comboBox2.Items.Add(Form1.db1.sportsmens[i].SurName);
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
