using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLR_Test
{
    public partial class Form1 : Form
    {
        byte b = 100;

        public Form1()
        {
            InitializeComponent();
            b = checked((byte)(b + 155));
            unchecked
            {
                byte c = 200;
                b += c;
            }
            //checked
            {
                test();
            }
            
            Console.WriteLine(b);
        }
        private void test()
        {
            //checked
            {
                byte tt = 200;
                tt += 66;
                Console.WriteLine(tt);
            }
        }
    }
}
