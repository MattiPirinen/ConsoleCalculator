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
    public partial class FormMain : Form
    {
        List<Corbel> corbelList = new List<Corbel>();
        Corbel currentCorbel;

        public FormMain()
        {
            InitializeComponent();
            initializeComponentValues();
            getFields();
            


        }

        private void initializeComponentValues()
        {

            dataGridViewLoadcases.Rows[0].Cells[0].Value = 1;

            comboBoxConcreteStrength.Items.AddRange(new string[]{
                "C20/25",
                "C25/30",
                "C30/37",
                "C35/45",
                "C40/50",
                "C50/60"
            });
            comboBoxConcreteStrength.SelectedItem = comboBoxConcreteStrength.Items[2];
            comboBoxSteelStrength.Items.AddRange(new string[]{
                "B500B"
            });
            comboBoxSteelStrength.SelectedItem = comboBoxSteelStrength.Items[0];

            comboBoxDiam.Items.AddRange(new string[] { "6", "8", "10", "12", "16", "20" });
            comboBoxDiam.SelectedItem = comboBoxDiam.Items[3];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getFields()
        {
            sampleCorbel();
            if (!Double.IsNaN(currentCorbel.A5)) textBox_a5.Text = (currentCorbel.A5*1000).ToString(); else textBox_a5.Text = "";
            if (!Double.IsNaN(currentCorbel.Ac)) textBox_ac.Text = (currentCorbel.Ac*1000).ToString(); else textBox_ac.Text = "";
            if (!Double.IsNaN(currentCorbel.Hn)) textBox_hn.Text = (currentCorbel.Hn*1000).ToString(); else textBox_hn.Text = "";
            if (!Double.IsNaN(currentCorbel.Hc)) textBox_hc.Text = (currentCorbel.Hc*1000).ToString(); else textBox_hc.Text = "";
            if (!Double.IsNaN(currentCorbel.B)) textBox_b.Text = (currentCorbel.B*1000).ToString(); else textBox_b.Text = "";
            if (!Double.IsNaN(currentCorbel.N)) textBox_n.Text = (currentCorbel.N).ToString(); else textBox_n.Text = "";
            if (!String.IsNullOrEmpty(currentCorbel.CStrengthClass)) comboBoxConcreteStrength.SelectedItem = currentCorbel.CStrengthClass;
            if (!Double.IsNaN(currentCorbel.Fii1)) comboBoxDiam.Text = (currentCorbel.Fii1*1000).ToString();
            if (!String.IsNullOrEmpty(currentCorbel.SStrengthClass)) comboBoxSteelStrength.SelectedItem = currentCorbel.SStrengthClass;
        }

        private void setCorbelValues()
        {
            if (!(currentCorbel == null))
            {
                if (!Double.IsNaN(currentCorbel.A5) && textBox_a5.Text != (currentCorbel.A5 * 1000).ToString())
                    currentCorbel.A5 = convertToDouble(textBox_a5.Text) * 0.001;
                if (!Double.IsNaN(currentCorbel.Ac) && textBox_ac.Text != (currentCorbel.Ac * 1000).ToString())
                    currentCorbel.Ac = convertToDouble(textBox_ac.Text) * 0.001;
                if (!Double.IsNaN(currentCorbel.Hn) && textBox_hn.Text != (currentCorbel.Hn * 1000).ToString())
                    currentCorbel.Hn = convertToDouble(textBox_hn.Text) * 0.001;
                if (!Double.IsNaN(currentCorbel.Hc) && textBox_hc.Text != (currentCorbel.Hc * 1000).ToString())
                    currentCorbel.Hc = convertToDouble(textBox_hc.Text) * 0.001;
                if (!Double.IsNaN(currentCorbel.B) && textBox_b.Text != (currentCorbel.B * 1000).ToString())
                    currentCorbel.B = convertToDouble(textBox_b.Text) * 0.001;
                if (!Double.IsNaN(currentCorbel.N) && textBox_n.Text != (currentCorbel.N).ToString())
                    currentCorbel.N = convertToDouble(textBox_n.Text);
                if (currentCorbel.CStrengthClass != (string)comboBoxConcreteStrength.SelectedItem)
                    currentCorbel.CStrengthClass = (string)comboBoxConcreteStrength.SelectedItem;
                if (currentCorbel.SStrengthClass != (string)comboBoxSteelStrength.SelectedItem)
                    currentCorbel.SStrengthClass = (string)comboBoxSteelStrength.SelectedItem;
                if ((currentCorbel.Fii1*1000).ToString() != (string)comboBoxDiam.SelectedItem)
                    currentCorbel.Fii1 = Double.Parse((string)comboBoxDiam.SelectedItem)*0.001;
                upgradeChart();
            }

        }

        private void sampleCorbel()
        {
            Corbel Corbel1 = new Corbel("testi");

            Corbel1.Fck = 30 * Math.Pow(10, 6);
            Corbel1.Fyk = 500 * Math.Pow(10, 6);

            Corbel1.Hc = 0.59;
            Corbel1.B = 0.28;
            Corbel1.Cc = 0.035;
            Corbel1.Ac = 0.25;
            Corbel1.A5 = 0.25;
            Corbel1.Hn = 0.01;
            Corbel1.Gammac = 1.5;
            Corbel1.Gammas = 1.15;
            Corbel1.Fcd = Corbel1.Fck / Corbel1.Gammac*Corbel1.Acc;
            Corbel1.Fyd = Corbel1.Fyk / Corbel1.Gammas;
            Corbel1.Fii1 = 0.012;
            Corbel1.N = 6;


            Corbel1.createGraph();

            
            

            corbelList.Add(Corbel1);
            listBoxCorbels.Items.Add(Corbel1.Name);
            currentCorbel = Corbel1;
            currentCorbel.loadCases.Add(new LoadCase(10000, 100000, currentCorbel));
            upgradeChart();
        }

        private void upgradeChart()
        {
            chartStrength.Series["Strength"].Points.Clear();
            foreach (Tuple<double, double> value in currentCorbel.Resistance)
            {
                chartStrength.Series["Strength"].Points.AddXY(value.Item1 * 0.001, value.Item2 * 0.001);
            }

            double maxValue = currentCorbel.Resistance.Max(x => x.Item1);

            Tuple<double,double> intAndMax = createInterval(maxValue * 0.001);
            chartStrength.ChartAreas["ChartArea1"].AxisX.Interval = intAndMax.Item1;
            chartStrength.ChartAreas["ChartArea1"].AxisX.MinorGrid.Interval = intAndMax.Item1/5;
            chartStrength.ChartAreas["ChartArea1"].AxisX.Maximum = intAndMax.Item2;

            intAndMax = createInterval(currentCorbel.Resistance[currentCorbel.Resistance.Count - 1].Item2 * 0.001);
            chartStrength.ChartAreas["ChartArea1"].AxisY.Interval = intAndMax.Item1;
            chartStrength.ChartAreas["ChartArea1"].AxisY.MinorGrid.Interval = intAndMax.Item1 / 5;
            chartStrength.ChartAreas["ChartArea1"].AxisY.Maximum = intAndMax.Item2;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Give the name of the corbel", "New Corbel");
            Corbel newCorbel = new Corbel(name);
            corbelList.Add(newCorbel);

            listBoxCorbels.Items.Add(newCorbel.Name);
        }

        private void setDefValues()
        {
            textBox_a5.Text = "";
            textBox_bw.Text = "";
            textBox_ac.Text = "";
            textBox_hn.Text = "";
            textBox_hc.Text = "";
            textBox_b.Text = "";
            textBox_n.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenDetailedResults_Click(object sender, EventArgs e)
        {
            FormDetailedResults dResults = new FormDetailedResults();
            dResults.fillForm(corbelList[0],corbelList[0].loadCases[0]);
            dResults.ShowDialog();
            


        }

        private void comboBoxSteelStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxCorbels_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCorbel = corbelList.Find(x => x.Name == (string)listBoxCorbels.SelectedItem);
        }

        private double convertToDouble(string str)
        {
            try
            {
                return Convert.ToDouble(str);
            }
            catch (FormatException)
            {
                MessageBox.Show($"'{str}' is not a number", "Error", MessageBoxButtons.OK);
            }
            catch (OverflowException)
            {
                MessageBox.Show($"'{str}' too big or small number", "Error", MessageBoxButtons.OK);
            }
            return -10000000;
        }
        //TODO not implemented

        private void textBox_a5_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void textBox_ac_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void textBox_hn_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void textBox_hc_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void textBox_b_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void textBox_n_Leave(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void comboBoxConcreteStrength_SelectedValueChanged(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void comboBoxDiam_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCorbelValues();
        }

        private void checkAllLoadCases()
        {
            for (int i = 0;i<dataGridViewLoadcases.Rows.Count;i++)
            {
                if (currentCorbel != null)
                {

                    if (i < currentCorbel.loadCases.Count)
                    {
                        
                        if (((string)dataGridViewLoadcases.Rows[i].Cells[1].Value != null &&
                            (string)dataGridViewLoadcases.Rows[i].Cells[2].Value != null) &&
                            ((currentCorbel.loadCases[i].F_Ed*0.001).ToString() != (string)dataGridViewLoadcases.Rows[i].Cells[1].Value ||
                            (currentCorbel.loadCases[i].H_Ed*0.001).ToString() != (string)dataGridViewLoadcases.Rows[i].Cells[2].Value))
                        {
                            currentCorbel.loadCases[i].F_Ed = convertToDouble((string)dataGridViewLoadcases.Rows[i].Cells[1].Value)*1000;
                            currentCorbel.loadCases[i].H_Ed = convertToDouble((string)dataGridViewLoadcases.Rows[i].Cells[2].Value)*1000;
                            dataGridViewLoadcases.Rows[i].Cells[3].Value = currentCorbel.loadCases[i].KA_max;


                            if (chartStrength.Series.FindByName((i + 1).ToString()) == null)
                            {
                                chartStrength.Series.Add((i + 1).ToString());
                            }
                            chartStrength.Series[(i + 1).ToString()].Points.Clear();
                            chartStrength.Series[(i + 1).ToString()].Points.AddXY(currentCorbel.loadCases[i].H_Ed * 0.001,
                                currentCorbel.loadCases[i].F_Ed * 0.001);
                            label10.Text = currentCorbel.loadCases[0].sigmac5.ToString();


                        }

                    }
                    else
                    {
                        if ((string)dataGridViewLoadcases.Rows[i].Cells[1].Value != null &&
                            (string)dataGridViewLoadcases.Rows[i].Cells[2].Value != null)
                        {
                            currentCorbel.loadCases.Add(new LoadCase(
                                convertToDouble((string)dataGridViewLoadcases.Rows[i].Cells[1].Value)*1000,
                                convertToDouble((string)dataGridViewLoadcases.Rows[i].Cells[1].Value)*1000,
                                currentCorbel));

                            createNewPointChart((i + 1).ToString());

                            chartStrength.Series[(i + 1).ToString()].Points.AddXY(currentCorbel.loadCases[i].H_Ed * 0.001,
                                currentCorbel.loadCases[i].F_Ed * 0.001);
                            dataGridViewLoadcases.Rows[i].Cells[3].Value = currentCorbel.loadCases[i].KA_max;
                        }

                    }
                }

            }


            
        }

        private void createNewPointChart(string name)
        {
            chartStrength.Series.Add(name);
            chartStrength.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chartStrength.Series[name].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            chartStrength.Series[name].MarkerSize = 10;
        }


        private void dataGridViewLoadcases_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridViewLoadcases.Rows[dataGridViewLoadcases.Rows.Count - 1].Cells[0].Value =
                dataGridViewLoadcases.Rows.Count;
        }


        private void dataGridViewLoadcases_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            checkAllLoadCases();
        }

        private Tuple<double,double> createInterval(double maxValue)
        {
            double numb = Math.Floor(Math.Log10(maxValue));
            char firstNum = maxValue.ToString()[0];
            char secondNum = maxValue.ToString()[1];
            if (firstNum == '9' || firstNum == '8' || firstNum == '7')
                return new Tuple<double,double>(2 * Math.Pow(10, numb),(Char.GetNumericValue(firstNum) + 1)* Math.Pow(10, numb));
            else if (firstNum == '6' || firstNum == '5' || firstNum == '4')
                return new Tuple<double, double>(Math.Pow(10, numb), (Char.GetNumericValue(firstNum) + 1) * Math.Pow(10, numb));
            else
            {
                double firstTwo = Math.Floor(Double.Parse(Char.ToString(firstNum) + Char.ToString(secondNum)) / 5)*5;
                return new Tuple<double, double>(0.5 * Math.Pow(10, numb), (firstTwo + 5) * Math.Pow(10, numb-1));
            }
                

        }


    }
}
