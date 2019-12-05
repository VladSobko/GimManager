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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 example = new Form7();
            example.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 example = new Form8();
            example.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 example = new Form9();
            example.Show();
        }
    }
}
