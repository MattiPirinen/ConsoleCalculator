using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class LoadCase
    {
        public string Name { get; set; }

        private double _F_Ed;
        private double _H_Ed;

        public double F_Ed { get { return _F_Ed; }
            set
            {
                _F_Ed = value;
                if (!Double.IsNaN(_H_Ed)) CalcUtil();
            }
        }
        public double H_Ed
        {
            get { return _H_Ed; }
            set
            {
                _H_Ed = value;
                if (!Double.IsNaN(_F_Ed)) CalcUtil();
            }
        }
        public double M_Eds { get; private set; }
        public double Fc0 { get; private set; }
        public double KA_c1 { get; private set; }
        public double fcd1 { get; private set; }
        public double x1 { get; private set; }
        public double c { get; private set; }
        public double d { get; private set; }
        public double h1 { get; private set; }
        public double a0 { get; private set; }
        public double z { get; private set; }
        public double a4 { get; private set; }
        public double sigmac0 { get; private set; }
        public double angle { get; private set; }
        public double fcd2 { get; private set; }
        public double sigmac5 { get; private set; }
        public double Fc { get; private set; }
        public double KA_c2 { get; private set; }
        public double u { get; private set; }
        public double a2 { get; private set; }
        public double sigmac4 { get; private set; }
        public double F_t { get; private set; }
        public double KA_c3 { get; private set; }
        public double KA_c { get; private set; }
        public double KA_s { get; private set; }
        public double KA_max { get; private set; }
        public double A_svaad { get; private set; }
        List<Tuple<double, double>> _resistance = new List<Tuple<double, double>>();
        private Corbel _cb;
        


        public LoadCase(double f_ed,double h_ed,Corbel cb,string name)
        {
            _cb = cb;
            F_Ed = f_ed;
            H_Ed = h_ed;
            Name = name;
            CalcUtil();
        }



        public void CalcUtil()
        {
            fcd1 = (1 - _cb.Fck / (250 * Math.Pow(10, 6))) * _cb.Fcd;
            x1 = _F_Ed / (_cb.B * fcd1);
            c = _cb.Ac + x1 / 2;
            d = _cb.Hc - _cb.Cc - _cb.Fii1 / 2;
            h1 = _cb.Hc + _cb.Hn - d;
            M_Eds = _F_Ed * c + _H_Ed * h1;
            a0 = defa0(M_Eds, fcd1, d);
            z = d - a0 / 2;
            a4 = Math.Pow(Math.Pow(x1, 2) + Math.Pow(a0, 2), 0.5);
            Fc0 = M_Eds / z;
            sigmac0 = Fc0 / (_cb.B * a0);
            KA_c1 = sigmac0 / fcd1;
            angle = Math.Atan(z / c);
            Fc = Math.Cos(angle) * _F_Ed + Math.Sin(angle) * Fc0;
            fcd2 = 0.85 * (1 - _cb.Fck / (250 * Math.Pow(10, 6))) * _cb.Fcd;
            sigmac5 = 10000000;
            if (_F_Ed != 0) { sigmac5 = _F_Ed / (_cb.B * _cb.A5) * (1 + Math.Pow(_H_Ed / _F_Ed, 2)); }
            KA_c2 = sigmac5 / fcd2;
            u = 2 * _cb.Cc;
            a2 = _cb.A5 * Math.Sin(angle) + u * Math.Cos(angle);
            sigmac4 = Fc / (a2 * _cb.B);
            F_t = Fc0 + _H_Ed;
            KA_c3 = sigmac4 / fcd2;
            KA_c = Math.Max(KA_c2, KA_c3);
            A_svaad = F_t / _cb.Fyd;
            KA_s = A_svaad / _cb.SteelArea;
            KA_max = Math.Max(KA_c, KA_s);
        }

        private double defa0(double M_Eds, double fcd1, double d)
        {
            double a0 = 0.001;
            while (M_Eds / (d - a0 / 2) / (_cb.B * a0) > fcd1)
            {
                a0 += 0.001;
            }
            return a0;
        }

    }
}
