using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Спортзал
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int st = 0;
            for (int i = 0; i < Form1.db3.trainings.Count; i++)
            {
                Train t = Form1.db3.trainings[i];
               // for (DateTime j = dateTimePicker1.Value; j < dateTimePicker2.Value; j.AddDays(1))
                {
                    if (dateTimePicker1.Value <= Form1.db3.trainings[i].Data && dateTimePicker2.Value >= Form1.db3.trainings[i].Data)
                    if (t.payment) st++;
                } 
            }
            st = st * 30;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label3.Text = Convert.ToString(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            DateTime db, de;
            db = dateTimePicker1.Value;
            de = dateTimePicker2.Value;
            db = db.AddDays(-1);
            de = de.AddDays(1);
            var arr = Form1.db3.trainings;
            var dates = (from x in arr
                      where (x.Data>db && x.Data<=de)  
                      select x.Data.ToString("dd-MM-yyyy")).
                      Distinct().ToArray();

            List<int> cash = new List<int>();
            foreach (var item in dates)
            {
                int count = (
                    from x in arr
                    where (x.Data.ToString("dd-MM-yyyy") == item && x.payment == true)
                    select x).Count();
                cash.Add(count*30);
            }
                     
            chart1.Series.Clear();
            Series Income = chart1.Series.Add("Розподіл доходу по датах");
            Income.Points.DataBindXY(dates, cash);
            Income.ChartType = SeriesChartType.Line;
            Income.Color = Color.Blue;
            Income.BorderWidth = 2;  
        }
    }
}
