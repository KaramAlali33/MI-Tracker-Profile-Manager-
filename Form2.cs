using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayAllInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Program.person;
        }

        private void colseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (f1 != null)
            {
                f1.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var v = from item in Program.person
                    orderby item.Name.ToLower() ascending
                    select item;
            dataGridView1.DataSource = v.ToList();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var v = from item in Program.person
                    orderby item.Name.ToLower() descending
                    select item;
            dataGridView1.DataSource = v.ToList();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var sortedByBMIAsc = from item in Program.person
                                 orderby item.BMI ascending
                                 select item;
            dataGridView1.DataSource = sortedByBMIAsc.ToList();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var sortedByBMIDesc = from item in Program.person
                                  orderby item.BMI descending
                                  select item;
            dataGridView1.DataSource = sortedByBMIDesc.ToList();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            var underweightPersons = from item in Program.person
                                     where item.BMI < 18.5
                                     select item;
            dataGridView1.DataSource = underweightPersons.ToList();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            var overweightPersons = from item in Program.person
                                    where item.BMI >= 25
                                    select item;
            dataGridView1.DataSource = overweightPersons.ToList();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            var malePersons = from item in Program.person
                              where item.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase)
                              select item;
            dataGridView1.DataSource = malePersons.ToList();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            var femalePersons = from item in Program.person
                                where item.Gender.Equals("Female", StringComparison.OrdinalIgnoreCase)
                                select item;
            dataGridView1.DataSource = femalePersons.ToList();
        }
    }
}
