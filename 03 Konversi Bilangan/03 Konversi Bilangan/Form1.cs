using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Konversi_Bilangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int BIN, DEC, OKT, dec;
        public void D2B (int dec)
        {
            int X = 0, BIN = 0;
            while (DEC > 0)
            {
                BIN += (int)(DEC % 2 * Math.Pow(10, X++));
                DEC /= 2;
            }
            TB_BIN.Text = BIN.ToString();
        }

        public void B2D(int bin)
        {
            int X = 0, DEC = 0;
            while (BIN > 0)
            {
                DEC += (int)(BIN % 2 * Math.Pow(2, X++));
                BIN /= 10;
            }
            TB_DEC.Text = DEC.ToString();
        }

        public void D2O(int dec)
        {
            int X = 0, OKT = 0;
            while (DEC > 0)
            {
                OKT += (int)(DEC % 8 * Math.Pow(10, X++));
                DEC /= 8;
            }
            TB_OKT.Text = OKT.ToString();
        }

        public void O2D(int okt)
        {
            int X = 0, DEC = 0;
            while (OKT > 0)
            {
                DEC += (int)(OKT % 8 * Math.Pow(8, X++));
                OKT /= 10;
            }
            TB_DEC.Text = DEC.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB_DEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToSByte(e.KeyChar) == 13)
            {
                DEC = Convert.ToInt32(TB_DEC.Text);
                D2B(DEC);
                DEC = Convert.ToInt32(TB_DEC.Text);
                D2O(OKT);
            }

        }

        private void TB_BIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToSByte(e.KeyChar) == 13)
            {
                BIN = Convert.ToInt32(TB_BIN.Text);
                B2D(BIN);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
