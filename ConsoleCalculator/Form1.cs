using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Corbel Corbel1 = new Corbel();
            Corbel1.Fck = 30 * Math.Pow(10, 6);
            Corbel1.Fyk = 500 * Math.Pow(10, 6);
            Corbel1.calcSteelArea(0.012, 8);
            Corbel1.Hc = 0.59;
            Corbel1.B = 0.28;
            Corbel1.Cc = 0.0035;
            Corbel1.Ac = 0.25;
            Corbel1.A5 = 0.25;
            Corbel1.Hn = 0.01;
            Corbel1.Gammac = 1.5;
            Corbel1.Gammas = 1.15;
            Corbel1.Fcd = Corbel1.Fck * Corbel1.Gammac;
            Corbel1.Fyd = Corbel1.Fyk * Corbel1.Gammas;
            Corbel1.Fii1 = 0.012;
            textBox1.Text = Corbel1.CalcUtil(300000, 60000).ToString();


        }
    }
}
