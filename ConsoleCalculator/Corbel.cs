using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleCalculator
{
    public class Corbel
    {
        string _CstrengthClass = "";
        string _SStrengthClass = "";
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
        double _acc = 0.85;
        double _n;
        List<Tuple<double, double>> _resistance = new List<Tuple<double, double>> ();
        List<LoadCase> _loadCases = new List<LoadCase>();
        public double Fck
        {
            get
            {
                return _fck;
            }

            set
            {
                _fck = value;
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                calc_fcd();
                UpgradeResults();
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
                calc_fyd();
                UpgradeResults();
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
                UpgradeResults();
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
                UpgradeResults();
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
                if (_n != 0) calcSteelArea();
                UpgradeResults();
                
            }
        }
        public double N
        {
            get
            {
                return _n;
            }

            set
            {
                _n = value;
                if (!Double.IsNaN(_fii1)) calcSteelArea();
                UpgradeResults();
            }
        }
        public double acc { get; private set; }
        public string Name { get; set; }
        public string CStrengthClass
        {
            get
            {
                return _CstrengthClass;
            }

            set
            {
                _CstrengthClass = value;
                switch (value)
                {
                    case "C20/25":
                        _fck = 20*Math.Pow(10,6);
                        break;
                    case "C25/30":
                        _fck = 25*Math.Pow(10, 6);
                        break;
                    case "C30/37":
                        _fck = 30 * Math.Pow(10, 6);
                        break;
                    case "C35/45":
                        _fck = 35 * Math.Pow(10, 6);
                        break;
                    case "C40/50":
                        _fck = 40 * Math.Pow(10, 6);
                        break;
                    case "C50/60":
                        _fck = 50 * Math.Pow(10, 6);
                        break;
                    default:
                        _fck = 0;
                        MessageBox.Show("No such concrete strengthClass", "Error", MessageBoxButtons.OK);
                        break;
                    
                }
                UpgradeResults();
            }
        }
        public string SStrengthClass
        {
            get
            {
                return _SStrengthClass;
            }

            set
            {
                _SStrengthClass = value;
                switch (value)
                {
                    case "B500B":
                        _fyk = 500 * Math.Pow(10, 6);
                        break;
                    default:
                        _fyk = 0 * Math.Pow(10, 6);
                        MessageBox.Show("No such steel strengthClass", "Error", MessageBoxButtons.OK);
                        break;
                }

                UpgradeResults();
            }
        }
        public double Acc
        {
            get
            {
                return _acc;
            }
        }

        public List<Tuple<double, double>> Resistance
        {
            get
            {
                return _resistance;
            }

            set
            {
                _resistance = value;
            }
        }
        public List<LoadCase> loadCases { get { return _loadCases; } }


        public Corbel(string name)
        {
            Name = name;
            _gammac = 1.5;
            _gammas = 1.15;
        }


        private void calc_fcd()
        {
            _fcd = _fck * _acc / _gammac;
        }

        private void calc_fyd()
        {
            _fyd = _fyk / _gammas;
        }



        private bool AllValuesDefined()
        {
            return _fck != 0 &&
                _fyk != 0 &&
                _steelArea != 0 &&
                _hc != 0 &&
                _b != 0 &&
                _cc != 0 &&
                _ac != 0 &&
                _a5 != 0 &&
                _hn != 0 &&
                _gammac != 0 &&
                _gammas != 0 &&
                _fcd != 0 &&
                _fyd != 0 &&
                _fii1 != 0 &&
                _acc != 0;
        }

        private void UpgradeResults()
        {
            if (AllValuesDefined())
            {
                createGraph();
                foreach (LoadCase lc in _loadCases)
                {
                    lc.CalcUtil();
                }
            }
        }


        public void calcSteelArea()
        {
            _steelArea = Math.Pow(_fii1, 2) * Math.PI / 4 * _n;
        }



        
        public void createGraph()
        {
            Resistance = new List<Tuple<double, double>>();
            double hedAdd = 1000;
            double fedAdd = 1000;
            double hedSub = 4000;

            double H_Ed = 0;
            double F_Ed = 10000;
            double KA = 0;
            do
            {
                do
                {
                    LoadCase lc = new LoadCase(F_Ed, H_Ed, this,"temp");
                    KA = lc.KA_max;
                    H_Ed += hedAdd;
                } while (KA < 1);
                Resistance.Add(new Tuple<Double, Double>(H_Ed-hedAdd, F_Ed));


                F_Ed += fedAdd;
                H_Ed -= hedSub;
            } while (H_Ed > 0);

        }


        public void AddLoadCase(double F_Ed,double H_Ed,string name)
        {
            _loadCases.Add(new LoadCase(F_Ed, H_Ed, this,name));
        }


        public void printToForm()
        {
        }

    }
}
