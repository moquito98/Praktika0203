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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }

        private void массивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mas mas = new Mas();
            mas.Show();
        }

        private void переключателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Files files = new Files();
            files.Show();
        }
    }
}
