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
    
    public partial class Mas : Form
    {
        
        public Mas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countOstDel = 0;
            double sum = 0;
            double proizv = 1;
            int min = Convert.ToInt32(textBox1.Lines[0]);
            int max = Convert.ToInt32(textBox1.Lines[0]);


            int count = textBox1.Lines.Length; // Количество чисел
            label10.Text = count.ToString();

            for(int i = 0; i != count; i++)
            {
                // min and max
                if(Convert.ToInt32(textBox1.Lines[i]) > max)
                {
                    max = Convert.ToInt32(textBox1.Lines[i]);
                }
                else if(Convert.ToInt32(textBox1.Lines[i]) < min)
                {
                    min = Convert.ToInt32(textBox1.Lines[i]);
                }
                // сумма
                sum += Convert.ToInt32(textBox1.Lines[i]);
                // Произведение
                proizv *= Convert.ToInt32(textBox1.Lines[i]);
                // Количество чисел, которые делятся на сумму своих чисел нацело
                int num = Convert.ToInt32(textBox1.Lines[i]);
                string numStr = textBox1.Lines[i];
                bool ostDel = false;
                

                for (int j=0; j != numStr.Length; j++)
                {
                    if (num % Convert.ToInt32(numStr[j].ToString()) == 0)
                    {
                        ostDel = true;
                    }
                    else
                    {
                        ostDel = false;
                    }

                }
                if (ostDel == true)
                {
                    countOstDel++;
                }
            }
            
            label11.Text = sum.ToString();
            label12.Text = proizv.ToString();
            label13.Text = (Math.Round(sum / count)).ToString();
            label14.Text = min.ToString();
            label15.Text = max.ToString();
            label16.Text = countOstDel.ToString();
        }
    }
}
