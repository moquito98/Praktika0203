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
    public partial class Animation : Form
    {
        System.Drawing.Bitmap assasin, background;

        Graphics g;

        int dx;

        Rectangle rct;

        

        public Animation()
        {
            InitializeComponent();

            try
            {
                
                background = new Bitmap(@"C:\Users\k120\Desktop\Praktika0203Petriev\Cartoon_Forest_BG_03.png");
                assasin = new Bitmap(@"C:\Users\k120\Desktop\Praktika0203Petriev\walk2.png");

                this.BackgroundImage = new Bitmap(@"C:\Users\k120\Desktop\Praktika0203Petriev\Cartoon_Forest_BG_03.png");


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "Анимация");
            }

            assasin.MakeTransparent();

            this.ClientSize = new System.Drawing.Size(background.Width, background.Height);

            

            rct.X = -20;
            rct.Y = 100;

            rct.Width = assasin.Width;
            rct.Height = assasin.Height;

            

            dx = 2;

            g = this.CreateGraphics();
            timer1.Interval = 30;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(background, new Point(0, 0));

            if(rct.X < this.ClientRectangle.Width)
            {
                rct.X += dx;
            }
            else
            {
                rct.X = -20;
                rct.Y = 100;

            }

            g.DrawImage(assasin, rct.X, rct.Y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void Animation_Load(object sender, EventArgs e)
        {

        }
    }
}
