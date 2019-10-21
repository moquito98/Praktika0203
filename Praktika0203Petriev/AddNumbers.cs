using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika0203Petriev
{
    class AddNumbers
    {
        public static void addNumbers(TextBox textBox, Button button){
            if(textBox.Text == "0")
            {
                textBox.Clear();

            }

            textBox.Text += button.Text;
        }
    }
}
