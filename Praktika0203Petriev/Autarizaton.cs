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
    public partial class Autarizaton : Form
    {
        int countEntering = 0;

        public Autarizaton()
        {
            InitializeComponent();
            
        }

        private void Autarizaton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;

            if(textBox1.Text == "1337")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else if(countEntering == 2)
            {
                Application.Exit();
            }
            else
            {
                countEntering++;
                label2.Visible = true;
            }
        }
    }
}
