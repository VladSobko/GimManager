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
    public partial class Form3 : Form
    {
        int curr_row = -1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            toTable();
        }

        private void toTable()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form1.db2.teachers.Count; i++)
            {
                Coach c = Form1.db2.teachers[i];
                dataGridView1.Rows.Add(c.SurName, c.Name, c.SecondName,c.Data.ToString("dd-MM-yyyy"), c.Adres, c.PhoneNumber.ToString(), c.Salary.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditData.AddCoachesForm frm = new EditData.AddCoachesForm();
            frm.ShowDialog();
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.db2.teachers.Count; i++)
            {
                Coach c = Form1.db2.teachers[i];
               // dataGridView1.Rows.Add(c.SurName, c.Name, c.SecondName, c.Data.ToString("dd-MM-yyyy"), c.Adres, c.PhoneNumber.ToString(), c.Salary.ToString());
                if (c.SurName.Contains(textBox1.Text))
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(c.SurName, c.Name, c.SecondName, c.Data.ToString("dd-MM-yyyy"), c.Adres, c.PhoneNumber.ToString(), c.Salary.ToString());
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (curr_row == -1)
            {
                var result = MessageBox.Show("Оберіть елемент для видалення", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            Спортзал.Form1.db2.teachers.RemoveAt(curr_row);
            curr_row = -1;
            toTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            curr_row = e.RowIndex;
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
            catch(Exception){ }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Form3 frm = new Form3();
            //comboBox1.DisplayMember.ToString();
            //foreach (DataGridViewRow row in frm.dataGridView1.Rows)
            //{
            //    comboBox1.Items.Add(row.Cells[1].Value.ToString());
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if(comboBox1.SelectedIndex == 0)
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                else
                    if (comboBox1.SelectedIndex == 1)
                        dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
                    else
                        if (comboBox1.SelectedIndex == 2)
                            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                        else
                            if (comboBox1.SelectedIndex == 3)
                                dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Ascending);
                            else MessageBox.Show("Оберіть варіант для сортування з можливих");  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            toTable();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var arr = Form1.db2.teachers;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (arr[i].SurName != dataGridView1.Rows[i].Cells[0].Value)
                    arr[i].SurName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                if (arr[i].Name != dataGridView1.Rows[i].Cells[1].Value)
                    arr[i].Name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                if (arr[i].SecondName != dataGridView1.Rows[i].Cells[2].Value)
                    arr[i].SecondName = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (arr[i].Data.ToString() != dataGridView1.Rows[i].Cells[3].Value.ToString())
                    arr[i].Data = Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value);
                if (arr[i].Adres != dataGridView1.Rows[i].Cells[4].Value)
                    arr[i].Adres = dataGridView1.Rows[i].Cells[4].Value.ToString();
                if (arr[i].PhoneNumber.ToString() != dataGridView1.Rows[i].Cells[5].Value.ToString())
                    arr[i].PhoneNumber = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                if (arr[i].Salary.ToString() !=  dataGridView1.Rows[i].Cells[6].Value.ToString())
                    arr[i].Salary = Convert.ToDouble(  dataGridView1.Rows[i].Cells[6].Value );
            }

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int res;
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                if (e.FormattedValue.ToString() == string.Empty)
                    return;
                else
                    if (!int.TryParse(e.FormattedValue.ToString(), out res) || e.FormattedValue.ToString().Length > 10)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                        MessageBox.Show("Потрібно ввести числове значення");
                        e.Cancel = true;
                        return;
                    }
            }
        }
    }
}
