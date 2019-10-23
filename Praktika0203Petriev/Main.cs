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

        private void анимацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void бегущаяСтрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithString workWithString = new WorkWithString();
            workWithString.Show();
        }

        private void анимацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Animation animation = new Animation();
            animation.Show();
        }

        private void fffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
            
        }

        private void bbbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mas mas = new Mas();
            mas.Show();
        }

        private void переключателиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Files files = new Files();
            files.Show();
        }

        private void бегущаяСтрокаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WorkWithString workWithString = new WorkWithString();
            workWithString.Show();
        }

        private void анимацияToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Animation animation = new Animation();
            animation.Show();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
