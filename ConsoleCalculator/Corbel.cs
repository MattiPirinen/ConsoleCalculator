using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Corbel
    {
        double _fck; //concrete strength
        double _fyk; //steel strength
        double _steelArea;
        double _hc;
        double _b;
        double _cc;
        double _ac;
        double _a5;
        double _hn;
        double _gammac;
        double _gammas;
        double _fcd;
        double _fyd;
        double _fii1;
        public double Fck
        {
            get
            {
                return _fck;
            }

            set
            {
                _fck = value;
            }
        }
        public double Fyk
        {
            get
            {
                return _fyk;
            }

            set
            {
                _fyk = value;
            }
        }
        public double SteelArea
        {
            get
            {
                return _steelArea;
            }

            set
            {
                _steelArea = value;
            }
        }
        public double Hc
        {
            get
            {
                return _hc;
            }

            set
            {
                _hc = value;
            }
        }
        public double B
        {
            get
            {
                return _b;
            }

            set
            {
                _b = value;
            }
        }
        public double Cc
        {
            get
            {
                return _cc;
            }

            set
            {
                _cc = value;
            }
        }
        public double Ac
        {
            get
            {
                return _ac;
            }

            set
            {
                _ac = value;
            }
        }
        public double A5
        {
            get
            {
                return _a5;
            }

            set
            {
                _a5 = value;
            }
        }
        public double Hn
        {
            get
            {
                return _hn;
            }

            set
            {
                _hn = value;
            }
        }
        public double Gammac
        {
            get
            {
                return _gammac;
            }

            set
            {
                _gammac = value;
            }
        }
        public double Gammas
        {
            get
            {
                return _gammas;
            }

            set
            {
                _gammas = value;
            }
        }
        public double Fcd
        {
            get
            {
                return _fcd;
            }

            set
            {
                _fcd = value;
            }
        }
        public double Fyd
        {
            get
            {
                return _fyd;
            }

            set
            {
                _fyd = value;
            }
        }
        public double Fii1
        {
            get
            {
                return _fii1;
            }

            set
            {
                _fii1 = value;
            }
        }

        List<Tuple<double, double>> resistance_;

        public void calcSteelArea(double diam, int amount)
        {
            _steelArea = Math.Pow(diam, 2) * Math.PI / 4 * amount;
        }


        public double CalcUtil(double F_ed, double H_ed)
        {
            double fcd1 = (1 - _fck / (250 * Math.Pow(10, 6))) * _fcd;
            double x1 = F_ed / (_b * fcd1);
            double c = _ac + x1 / 2;
            double d = _hc - _cc - _fii1 / 2;
            double h1 = _hc + _hn - d;
            double M_Eds = F_ed * c + H_ed * h1;
            double a0 = defa0(M_Eds, fcd1, d);
            double z = d - a0 / 2;
            double a4 = Math.Pow(Math.Pow(x1, 2) + Math.Pow(a0, 2), 0.5);
            double Fc0 = M_Eds / z;
            double sigmac0 = Fc0 / (_b * a0);
            double KA_c1 = sigmac0 / fcd1;
            double angle = Math.Atan(z / c);
            double Fc = Math.Cos(angle) * F_ed + Math.Sin(angle) * Fc0;
            double fcd2 = 0.85*(1 - _fck / (250 * Math.Pow(10, 6))) * _fcd;
            double sigmac5 = F_ed / (_b * _a5) * (1 + Math.Pow(H_ed / F_ed, 2));
            double KA_c2 = sigmac5 / fcd2;
            double u = 2 * _cc;
            double a2 = _a5 * Math.Sin(angle) + u * Math.Cos(angle);
            double sigmac4 = Fc / (a2 * _b);
            double F_t = Fc0 + H_ed;
            double KA_c3 = sigmac4 / fcd2;
            double KA_c = Math.Max(KA_c2, KA_c3);
            double KA_s = F_t / _fyd / _steelArea;
            double KA_max = Math.Max(KA_c, KA_s);
            return KA_max;



        }
        
        private double defa0(double M_Eds,double fcd1,double d)
        {
            double a0 = 0.001;
            while (M_Eds/(d-a0/2)/(_b*a0) > fcd1)
            {
                a0 += 0.001;
            }
            return a0;
        }

        public void printToForm()
        {
        }

    }
}
