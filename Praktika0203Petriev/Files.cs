using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Praktika0203Petriev
{
    public partial class Files : Form
    {
        StreamReader streamReader = new StreamReader(@"C:\Users\k120\Desktop\Praktika0203Petriev\test\Questions.txt");
        int countClicks = 0;
        public Files()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(countClicks < 5)
            {
                for (int i = 0; i != 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            label1.Text = streamReader.ReadLine();
                            break;
                        case 1:
                            radioButton1.Text = streamReader.ReadLine();
                            break;
                        case 2:
                            radioButton2.Text = streamReader.ReadLine();
                            break;
                        case 3:
                            radioButton3.Text = streamReader.ReadLine();
                            break;
                    }

                }
            }
            

            switch (countClicks)
            {
                case 1:
                    button1.Text = "Ответить";
                    break;
                case 4:
                    button1.Text = "Завршить тест";
                    streamReader.DiscardBufferedData();
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    break;
                case 5:
                    button1.Text = "Начать";
                    label1.Text = "Вопрос";
                    radioButton1.Text = "а)";
                    radioButton2.Text = "б)";
                    radioButton3.Text = "в)";
                    break;
            }
            if (countClicks == 5)
            {
                countClicks = 0;
            }
            countClicks++;

        }
    }
}
