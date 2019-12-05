using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Спортзал
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Visible = true;
            double st = 0;
            for (int i = 0; i < Form1.db3.trainings.Count; i++)
            {
                Train t = Form1.db3.trainings[i];
                {
                    if (dateTimePicker1.Value <= Form1.db3.trainings[i].Data && dateTimePicker2.Value >= Form1.db3.trainings[i].Data)
                        if (t.payment) st++;
                }
            }
            double sum = 0;
            for (int i = 0; i < Form1.db2.teachers.Count; i++)
            {
                listBox1.Items.Add(Form1.db2.teachers[i].Salary+"---"+Form1.db2.teachers[i].SurName);
                sum += Form1.db2.teachers[i].Salary;

            }
            int sa = 0;
            for (int i = 0; i < Form1.db1.sportsmens.Count; i++)
            {
                Visitor v = Form1.db1.sportsmens[i];
                if (v.abonement) sa++;
            }
            sa = sa * 220;
            double s = (st * 30) + sa - sum;
            if (s > 0) label3.ForeColor = Color.Green;
            if (s < 0) label3.ForeColor = Color.Red;
            label3.Text = Convert.ToString(s);
        }
    }
}
