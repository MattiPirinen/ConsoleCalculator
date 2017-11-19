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
    public partial class FormDetailedResults : Form
    {
        enum units
        {
            MPa,mm,mm2,kN,kNm,none
        };


        public FormDetailedResults()
        {
            InitializeComponent();
            
        }

        private void FormDetailedResults_Load(object sender, EventArgs e)
        {
            rTBFormulas.SelectedRtf = Properties.Resources.Document;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelftu_Click(object sender, EventArgs e)
        {

        }

        private void labelsigmac5v_Click(object sender, EventArgs e)
        {

        }

        private void labelkac2v_Click(object sender, EventArgs e)
        {

        }

        private void labelsigmac5u_Click(object sender, EventArgs e)
        {

        }

        private void labeluv_Click(object sender, EventArgs e)
        {

        }

        private void labeluu_Click(object sender, EventArgs e)
        {

        }

        private void labela2v_Click(object sender, EventArgs e)
        {

        }

        private void labela2u_Click(object sender, EventArgs e)
        {

        }

        private void labelsigmac4v_Click(object sender, EventArgs e)
        {

        }

        private void labelsigmac4u_Click(object sender, EventArgs e)
        {

        }

        private void labelkac3v_Click(object sender, EventArgs e)
        {

        }

        private void labelftv_Click(object sender, EventArgs e)
        {

        }

        private void labelkacv_Click(object sender, EventArgs e)
        {

        }

        private void labelasvaadu_Click(object sender, EventArgs e)
        {

        }

        private void labelasvaadv_Click(object sender, EventArgs e)
        {

        }

        private void labelkasv_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void fillForm(Corbel corbel,LoadCase lc)
        {
            labelfckv.Text = numToString(corbel.Fck,units.MPa,1);
            labelgammacv.Text = numToString(corbel.Gammac, units.none, 2);
            labelaccv.Text = numToString(corbel.acc, units.none, 2);
            labelfcdv.Text = numToString(corbel.Fcd, units.MPa, 1);
            labelgammasv.Text = numToString(corbel.Gammas, units.none, 2);
            labelfykv.Text = numToString(corbel.Fyk, units.MPa, 1);
            labelfydv.Text = numToString(corbel.Fyd, units.MPa, 1);
            labelasv.Text = numToString(corbel.SteelArea, units.mm2, 0);
            labelfcd1v.Text = numToString(lc.fcd1, units.MPa, 1);
            labelx1v.Text = numToString(lc.x1, units.mm, 0);
            labelcv.Text = numToString(lc.c, units.mm, 0);
            labeldv.Text = numToString(lc.d, units.mm, 0);
            labelh1v.Text = numToString(lc.h1, units.mm, 0);
            labelmedsv.Text = numToString(lc.M_Eds, units.kNm, 1);
            labela0v.Text = numToString(lc.a0, units.mm, 0);
            labelzv.Text = numToString(lc.z, units.mm, 0);
            labela4v.Text = numToString(lc.a4, units.mm, 0);
            labelfc0v.Text = numToString(lc.Fc0, units.kN, 1);
            labelsigmac0v.Text = numToString(lc.sigmac0, units.MPa, 1);
            labelkac1v.Text = numToString(lc.KA_c1, units.none, 2);
            labelanglev.Text = numToString(lc.angle, units.none, 1);
            labelfcv.Text = numToString(lc.Fc, units.kN, 1);
            labelfcd2v.Text = numToString(lc.fcd2, units.MPa, 1);
            labelsigmac5v.Text = numToString(lc.sigmac5, units.MPa, 1);
            labelkac2v.Text = numToString(lc.KA_c2, units.none, 2);
            labeluv.Text = numToString(lc.u, units.mm, 1);
            labela2v.Text = numToString(lc.a2, units.mm, 0);
            labelsigmac4v.Text = numToString(lc.sigmac4, units.MPa, 1);
            labelkac3v.Text = numToString(lc.KA_c3, units.none, 2);
            labelftv.Text = numToString(lc.F_t, units.kN, 1);
            labelkacv.Text = numToString(lc.KA_c, units.none, 2);
            labelasvaadv.Text = numToString(lc.A_svaad, units.mm2, 0);
            labelkasv.Text = numToString(lc.KA_s, units.none, 2);
        }

        private string numToString(double num,units unit,int decimals)
        {
            string[] value = {""};

            if (unit == units.kN)
            {
                value = (num * Math.Pow(10, -3)).ToString().Split(',');

            }
            else if (unit == units.kNm)
            {
                value = (num * Math.Pow(10, -3)).ToString().Split(',');

            }
            else if (unit == units.mm)
            {
                value = (num * Math.Pow(10, 3)).ToString().Split(',');

            }
            else if (unit == units.mm2)
            {
                value = (num * Math.Pow(10, 6)).ToString().Split(',');

            }
            else if (unit == units.MPa)
            {
                value = (num * Math.Pow(10, -6)).ToString().Split(',');

            }
            else if (unit == units.none)
            {
                value = (num * Math.Pow(10, 0)).ToString().Split(',');

            }

            if (decimals == 0) return value[0];
            else
            {
                if (value.Length != 1 && value[1] != "")
                    if (value[1].Length >= decimals)
                        return (value[0] + "," + value[1].Substring(0,decimals));
                    else
                        return ((value[0] + "," + value[1]).PadRight(value[0].Length + decimals + 1, '0'));
                else
                    return ((value[0] + ",").PadRight(value[0].Length + decimals + 1, '0'));
            }

        }


    }
}
