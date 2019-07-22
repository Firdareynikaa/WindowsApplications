using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_DEC2BIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DEC, X = 0, BIN = 0;
            DEC = Convert.ToInt32(textBox1.Text);
            while (DEC > 0)
            {
                BIN += (int)(DEC % 2 * Math.Pow(10, X++));
                DEC /= 2;
            }
            textBox2.Text = BIN.ToString();
        }
    }
}
