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
    public partial class WorkWithString : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        public WorkWithString()
        {
            InitializeComponent();

            try
            {
                baner = new Bitmap(@"C:\Users\k120\Desktop\Praktika0203Petriev\RunningString.png");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n" + exception.ToString(), "Баннер");
                this.Close();
                return;
            }

            g = this.CreateGraphics();

            rct.X = 0;
            rct.Y = 0;
            rct.Width = baner.Width;
            rct.Height = baner.Height;

            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void WorkWithString_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;

            if(Math.Abs(rct.X) > rct.Width)
            {
                rct.X += rct.Width;
            }

            for(int i = 0; i <= Convert.ToInt16(this.ClientSize.Width / rct.Width) + 1; i++)
            {
                g.DrawImage(baner, rct.X + i * rct.Width, rct.Y);
            }
        }
    }
}
