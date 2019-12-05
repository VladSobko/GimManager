using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Спортзал
{
    public partial class Form1 : Form
    {
        public static Classes.DB db1 = new Classes.DB();
        public static Classes.DB db2 = new Classes.DB();
        public static Classes.DB db3 = new Classes.DB();

        public void Save(String fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fso = File.OpenWrite(fileName);
            formatter.Serialize(fso, db1);
            formatter.Serialize(fso, db2);
            formatter.Serialize(fso, db3);
            fso.Close();
        }
        public void LoadData(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsi = File.OpenRead(fileName);
            db1 = (Classes.DB)formatter.Deserialize(fsi);
            db2 = (Classes.DB)formatter.Deserialize(fsi);
            db3 = (Classes.DB)formatter.Deserialize(fsi);
            fsi.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 example = new Form3();
            example.Show();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 example = new Form2();
            example.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 example = new Form4();
            example.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 example = new Form5();
            example.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData("test.data");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Save("test.data");
        }

        private void редагуватиТренерівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 example = new Form3();
            example.Show();
        }

        private void редагуватиВідвідувачівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 example = new Form4();
            example.Show();
        }

        private void оформитиВідвідуванняТренуваняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 example = new Form5();
            example.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Точно вийти?", "Увага", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 example = new Form6();
            example.Show();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 example = new Form6();
            example.Show();
        }
    }
}
