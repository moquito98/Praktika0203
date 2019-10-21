using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika0203Petriev
{
    public partial class Calculator : Form
    {
        double result = 0;
        int lastClick = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result += Convert.ToInt32(textBox1.Text);
            textBox2.Text = result.ToString();
            textBox1.Text = "0";
            lastClick = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (lastClick)
            {
                case 1:
                    result += Convert.ToInt32(textBox1.Text);
                    textBox2.Text = result.ToString();
                    break;
                case 2:
                    result -= Convert.ToInt32(textBox1.Text);
                    textBox2.Text = result.ToString();
                    break;
                case 3:
                    result *= Convert.ToInt32(textBox1.Text);
                    textBox2.Text = result.ToString();
                    break;
                case 4:
                    result /= Convert.ToInt32(textBox1.Text);
                    textBox2.Text = result.ToString();
                    break;
            }
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddNumbers.addNumbers(textBox1, button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * -1);
            }
            catch
            {
                
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            result -= Convert.ToInt32(textBox1.Text);
            textBox2.Text = result.ToString();
            textBox1.Text = "0";
            lastClick = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result *= Convert.ToInt32(textBox1.Text);
            textBox2.Text = result.ToString();
            textBox1.Text = "0";
            lastClick = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            result /= Convert.ToInt32(textBox1.Text);
            textBox2.Text = result.ToString();
            textBox1.Text = "0";
            lastClick = 4;
            
        }
    }
}
