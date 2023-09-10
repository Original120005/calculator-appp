using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator_appp
{
    public partial class Form1 : Form
    {
        float a = 0, b = 0, sum = 0;
        int count = 0;

        public void BaseA()
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
        }

        public void Function()
        {
            switch (count)
            {
                case 1:
                    b = float.Parse(textBox1.Text);
                    sum = a + b;
                    break;

                case 2:
                    b = float.Parse(textBox1.Text);
                    sum = a - b;
                    break;

                case 3:
                    b = float.Parse(textBox1.Text);
                    sum = a * b;
                    break;

                case 4:
                    b = float.Parse(textBox1.Text);
                    sum = a / b;
                    break;

                case 5:
                    b = float.Parse(textBox1.Text);
                    sum = a % b;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text += text[i];
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength;
            if (textBox1.Text.Contains(','))
            {
                MessageBox.Show("Incorrect");
            }
            else
            {
                textBox1.Text += ",";
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            BaseA();
            count = 1;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            BaseA();
            count = 2;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            BaseA();
            count = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseA();
            a *= -1;
            textBox1.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BaseA();
            textBox1.Text = Math.Sqrt(a).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BaseA();
            count = 5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BaseA();
            a = 1 / a;
            textBox1.Text = a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaseA();
            count = 4;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Function();
            textBox1.Text = sum.ToString();
        }

    }
}
