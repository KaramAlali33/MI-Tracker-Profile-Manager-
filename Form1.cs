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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            double height, weight;
            bool isValidHeight, isValidWeight;
            DateTime birthDate;

            // Check for missing values
            if (string.IsNullOrWhiteSpace(textBox2.Text) || comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Missing Value!");
                return;
            }

            // Assign values from the form controls
            person.Name = textBox2.Text;

            // Determine gender
            if (radioButton1.Checked)
            {
                person.Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                person.Gender = "Female"; // Corrected spelling
            }
            else
            {
                MessageBox.Show("Select Gender!");
                return;
            }

            // Assign birthdate
            birthDate = dateTimePicker1.Value;
            person.BDate = birthDate;

            // Validate and assign height
            isValidHeight = double.TryParse(textBox4.Text, out height);
            if (isValidHeight)
            {
                person.Height = height / 100; // Convert height from cm to meters
            }
            else
            {
                MessageBox.Show("Invalid Height!");
                return;
            }

            // Validate and assign weight
            isValidWeight = double.TryParse(textBox5.Text, out weight);
            if (isValidWeight)
            {
                person.Weight = weight;
            }
            else
            {
                MessageBox.Show("Invalid Weight!");
                return;
            }

            // Assign activity level
            person.ActivityLevel = comboBox1.SelectedItem.ToString();

            // Add person to the list
            Program.person.Add(person);
            MessageBox.Show("Insertion done successfully!");
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAsImage_Click(object sender, EventArgs e)
        {
           
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|PNG|*.png";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sd.FileName);
                }
            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void colseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}
