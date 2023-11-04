﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double first, second;
        public char process;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text =textBox1.Text + "0";
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            process = '+';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            process = '-';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            process = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            process = '/';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first =Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString((first*first));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(first));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(textBox1.Text);
            if (process == '+') textBox1.Text = Convert.ToString((first + second));
            if (process == '-') textBox1.Text = Convert.ToString((first - second));
            if (process == '*') textBox1.Text = Convert.ToString((first * second));
            if (process == '/') textBox1.Text = Convert.ToString((first / second));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")){
                if (textBox1.Text == "")
                {
                    textBox1.Text = ",";
                }
                else
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }



        }
    }
}
