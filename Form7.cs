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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
       


        private void Form7_Load(object sender, EventArgs e)
        {

            //Form5 fr = (Form5)this.Owner;

            int st = 0;
            for (int i = 0; i < Form1.db3.trainings.Count; i++)
            {
                Train t = Form1.db3.trainings[i];
                if (t.payment) st++;
            }
            st = st * 30;
            int sa = 0;
            for (int i = 0; i < Form1.db1.sportsmens.Count; i++)
            {
                Visitor v = Form1.db1.sportsmens[i];
                if (v.abonement ) sa++;
            }
            sa = sa * 220;
            int s = st + sa;
            label3.Text = Convert.ToString(s);
           
            //int s = 0;
            //foreach (DataGridViewRow dgvR in fr.dataGridView1.Rows)
            //{
            //    DataGridViewCheckBoxCell CbxCell = (DataGridViewCheckBoxCell)dgvR.Cells[5];
            //    if (Convert.ToBoolean(CbxCell.Value) == true) s++;
            //}
            //label3.Text = Convert.ToString(s * 50);
        }
    }
}