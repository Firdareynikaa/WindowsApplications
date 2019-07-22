using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_BIN2DEC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int BIN, X = 0, DEC = 0;
            BIN = Convert.ToInt32(textBox1.Text);
            while (BIN > 0)
            {
                DEC += (int)(BIN % 2 * Math.Pow(2, X++));
                BIN /= 10;
            }
            textBox2.Text = DEC.ToString();
        }
    }
}
