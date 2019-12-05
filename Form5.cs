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
    public partial class Form5 : Form
    {
        int curr_row = -1;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            toTable();
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
        }
        private void toTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form1.db3.trainings.Count; i++)
            {
                Train t = Form1.db3.trainings[i];
                dataGridView1.Rows.Add(t.Data.ToString("dd-MM-yyyy"), t.Time.ToString("HH:mm"), t.CoachName.SurName, t.VisitorName.SurName, t.payment);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditData.AddTrainingForm frm = new EditData.AddTrainingForm();
            frm.ShowDialog();
            toTable();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (curr_row == -1)
            {
                MessageBox.Show("Не вибрано елемент для видалення!");
                return;
            }
            Спортзал.Form1.db3.trainings.RemoveAt(curr_row);
            curr_row = -1;
            toTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index != -1)
                {
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, index + 1];
                }
            }
            catch (Exception) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index != -1)
                {
                    dataGridView1.Rows[index].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, index - 1];
                }
            }
            catch (Exception) { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.Rows.Count - 1) < 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            else
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.Rows.Count - 1) > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            else
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curr_row = e.RowIndex;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var arr = Form1.db3.trainings;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (arr[i].Data.ToString() != dataGridView1.Rows[i].Cells[0].Value.ToString())
                    arr[i].Data = Convert.ToDateTime(dataGridView1.Rows[i].Cells[0].Value);
                if (arr[i].Time.ToString() != dataGridView1.Rows[i].Cells[1].Value.ToString())
                    arr[i].Time = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
               
                if (arr[i].payment.ToString() != dataGridView1.Rows[i].Cells[4].Value.ToString())
                    arr[i].payment = Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value);
            }
        }
        //private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //}
    }
}
