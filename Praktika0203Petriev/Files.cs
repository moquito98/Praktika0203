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
        RadioButton[] radioButtons = new RadioButton[3];
        int[] trueAns = new int[] { 3, 1, 0, 2, 0, 1};
        int countTrueAnsw = 0;

        public Files()
        {
            InitializeComponent();
            radioButtons[0] = radioButton1;
            radioButtons[1] = radioButton2;
            radioButtons[2] = radioButton3;
            label2.Visible = false;
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

            try
            {
                if (radioButtons[trueAns[countClicks]].Checked == true)
                {
                    countTrueAnsw++;
                }
            }
            catch
            {

            }
            

            switch (countClicks)
            {
                case 0:
                    label2.Visible = false;
                    button1.Text = "Ответить";
                    break;
                case 4:
                    button1.Text = "Завршить тест";
                    streamReader.DiscardBufferedData();
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    break;
                case 5:
                    label2.Visible = true;
                    label2.Text = "Тест завершён! Количество правильных ответов: " + countTrueAnsw.ToString();
                    button1.Text = "Начать заново";
                    label1.Text = "Вопрос";
                    radioButton1.Text = "а)";
                    radioButton2.Text = "б)";
                    radioButton3.Text = "в)";

                    break;
            }
            
            countClicks++;
            if (countClicks == 6)
            {
                countClicks = 0;
                countTrueAnsw = 0;
            }

        }
    }
}
