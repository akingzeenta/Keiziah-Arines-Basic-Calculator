using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keiziah_Arines_Calculator
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox1.Text);
            int c;

            if (radioButton1.Checked)
            {
                c = a + b;
                label3.Text = "Total: " + c.ToString();

            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label3.Text = "Difference: " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label3.Text = "Product: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label3.Text = "Quotient: " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label3.Text = "Remainder: " + c.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
