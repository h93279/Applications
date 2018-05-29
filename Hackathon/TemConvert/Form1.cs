using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text + ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
            
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button12_Click(object sender, EventArgs e)
        {
            double F;
            double C;
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                F = double.Parse(textBox1.Text);
                C = (F - 32) / 9 * 5;
                textBox2.Text = C.ToString();
            }
            else
            {
                radioButton1.Checked = false;
                C = double.Parse(textBox1.Text);
                F = C * 9 / 5 + 32;
                textBox2.Text = F.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
