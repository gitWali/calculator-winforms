using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) //Header "Calculator"
        {
            
        }

        private void button16_Click(object sender, EventArgs e) //Taste C
        {
            window.Text = string.Empty;                         // Clear any temporary results
        }

        private void button10_Click(object sender, EventArgs e) //Taste 0
        {
            window.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e) //Taste 1
        {
            window.Text += 1;
        }

        private void button3_Click(object sender, EventArgs e) //Taste 2
        {
            window.Text += 2;
        }

        private void button2_Click(object sender, EventArgs e) //Taste 3
        {
            window.Text += 3;
        }

        private void button6_Click(object sender, EventArgs e) //Taste 4
        {
            window.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e) //Taste 5
        {
            window.Text += 5;
        }

        private void button4_Click(object sender, EventArgs e) //Taste 6
        {
            window.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e) //Taste 7
        {
            window.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e) //Taste 8
        {
            window.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e) //Taste 9
        {
            window.Text += 9;
        }

        private void button15_Click(object sender, EventArgs e) //Taste .
        {
            window.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e) //Taste -
        {
            window.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e) //Taste *
        {
            window.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e) //Taste /
        {
            window.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            window.Text += "+";
        }

        private void button11_Click(object sender, EventArgs e) //Taste =
        {
            try
            {
                string expression = window.Text;
                DataTable dt = new DataTable();
                object result = dt.Compute(expression, string.Empty);
                window.Text = result.ToString();
            }
            catch (Exception ex)
            {
                window.Text = "Error: " + ex.Message;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Ausgabefeld
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
