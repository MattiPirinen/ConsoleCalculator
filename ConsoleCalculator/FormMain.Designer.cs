namespace ConsoleCalculator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.chartStrength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenDetailedResults = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_bw = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_hc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_hn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_a5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSteelStrength = new System.Windows.Forms.ComboBox();
            this.comboBoxConcreteStrength = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.comboBoxDiam = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.listBoxCorbels = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_Ed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLoadcases = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadcases)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Corbel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartStrength
            // 
            this.chartStrength.BorderlineColor = System.Drawing.Color.Black;
            this.chartStrength.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Title = "H_Ed [kN]";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.Title = "F_Ed [kN]";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Verdana", 10F);
            chartArea2.Name = "ChartArea1";
            this.chartStrength.ChartAreas.Add(chartArea2);
            this.chartStrength.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            this.chartStrength.Legends.Add(legend2);
            this.chartStrength.Location = new System.Drawing.Point(766, 0);
            this.chartStrength.Name = "chartStrength";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.MidnightBlue;
            series2.Legend = "Legend1";
            series2.Name = "Strength";
            this.chartStrength.Series.Add(series2);
            this.chartStrength.Size = new System.Drawing.Size(528, 495);
            this.chartStrength.TabIndex = 2;
            this.chartStrength.Text = "chart1";
            // 
            // buttonOpenDetailedResults
            // 
            this.buttonOpenDetailedResults.Location = new System.Drawing.Point(822, 500);
            this.buttonOpenDetailedResults.Name = "buttonOpenDetailedResults";
            this.buttonOpenDetailedResults.Size = new System.Drawing.Size(175, 31);
            this.buttonOpenDetailedResults.TabIndex = 3;
            this.buttonOpenDetailedResults.Text = "Open Detailed Results";
            this.buttonOpenDetailedResults.UseVisualStyleBackColor = true;
            this.buttonOpenDetailedResults.Click += new System.EventHandler(this.buttonOpenDetailedResults_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ConsoleCalculator.Properties.Resources.Starting_values;
            this.pictureBox1.InitialImage = global::ConsoleCalculator.Properties.Resources.Starting_values;
            this.pictureBox1.Location = new System.Drawing.Point(505, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 352);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Corbel Design";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.textBox_bw);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.textBox_b);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox_hc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_hn);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_ac);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_a5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 276);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geometric properties";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(150, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 17);
            this.label27.TabIndex = 54;
            this.label27.Text = "bw=";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(333, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(34, 17);
            this.label28.TabIndex = 53;
            this.label28.Text = "mm";
            // 
            // textBox_bw
            // 
            this.textBox_bw.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_bw.Location = new System.Drawing.Point(229, 69);
            this.textBox_bw.Name = "textBox_bw";
            this.textBox_bw.Size = new System.Drawing.Size(100, 24);
            this.textBox_bw.TabIndex = 52;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(141, 17);
            this.label29.TabIndex = 51;
            this.label29.Text = "Loading area width";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "b=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(333, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 17);
            this.label18.TabIndex = 49;
            this.label18.Text = "mm";
            // 
            // textBox_b
            // 
            this.textBox_b.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_b.Location = new System.Drawing.Point(229, 193);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 24);
            this.textBox_b.TabIndex = 48;
            this.textBox_b.Leave += new System.EventHandler(this.textBox_b_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 17);
            this.label19.TabIndex = 47;
            this.label19.Text = "Corbel width";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(150, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "hc=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(333, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 45;
            this.label16.Text = "mm";
            // 
            // textBox_hc
            // 
            this.textBox_hc.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_hc.Location = new System.Drawing.Point(229, 162);
            this.textBox_hc.Name = "textBox_hc";
            this.textBox_hc.Size = new System.Drawing.Size(100, 24);
            this.textBox_hc.TabIndex = 44;
            this.textBox_hc.Leave += new System.EventHandler(this.textBox_hc_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "Corbel heigth";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(148, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "hn=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(332, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "mm";
            // 
            // textBox_hn
            // 
            this.textBox_hn.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_hn.Location = new System.Drawing.Point(229, 131);
            this.textBox_hn.Name = "textBox_hn";
            this.textBox_hn.Size = new System.Drawing.Size(100, 24);
            this.textBox_hn.TabIndex = 40;
            this.textBox_hn.Leave += new System.EventHandler(this.textBox_hn_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Bearing pad heigth";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "ac=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "mm";
            // 
            // textBox_ac
            // 
            this.textBox_ac.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_ac.Location = new System.Drawing.Point(229, 100);
            this.textBox_ac.Name = "textBox_ac";
            this.textBox_ac.Size = new System.Drawing.Size(100, 24);
            this.textBox_ac.TabIndex = 32;
            this.textBox_ac.Leave += new System.EventHandler(this.textBox_ac_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Load distance";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(150, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "a5=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "mm";
            // 
            // textBox_a5
            // 
            this.textBox_a5.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_a5.Location = new System.Drawing.Point(229, 38);
            this.textBox_a5.Name = "textBox_a5";
            this.textBox_a5.Size = new System.Drawing.Size(100, 24);
            this.textBox_a5.TabIndex = 28;
            this.textBox_a5.Leave += new System.EventHandler(this.textBox_a5_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loading area length";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSteelStrength);
            this.groupBox2.Controls.Add(this.comboBoxConcreteStrength);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 109);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material properties";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxSteelStrength
            // 
            this.comboBoxSteelStrength.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboBoxSteelStrength.FormattingEnabled = true;
            this.comboBoxSteelStrength.Location = new System.Drawing.Point(268, 69);
            this.comboBoxSteelStrength.Name = "comboBoxSteelStrength";
            this.comboBoxSteelStrength.Size = new System.Drawing.Size(100, 24);
            this.comboBoxSteelStrength.TabIndex = 53;
            this.comboBoxSteelStrength.SelectedIndexChanged += new System.EventHandler(this.comboBoxSteelStrength_SelectedIndexChanged);
            // 
            // comboBoxConcreteStrength
            // 
            this.comboBoxConcreteStrength.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboBoxConcreteStrength.FormattingEnabled = true;
            this.comboBoxConcreteStrength.Location = new System.Drawing.Point(268, 41);
            this.comboBoxConcreteStrength.Name = "comboBoxConcreteStrength";
            this.comboBoxConcreteStrength.Size = new System.Drawing.Size(100, 24);
            this.comboBoxConcreteStrength.TabIndex = 52;
            this.comboBoxConcreteStrength.SelectedValueChanged += new System.EventHandler(this.comboBoxConcreteStrength_SelectedValueChanged);
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(204, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 17);
            this.label32.TabIndex = 34;
            this.label32.Text = "fy=";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 69);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(148, 17);
            this.label34.TabIndex = 31;
            this.label34.Text = "Steel strength class";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(204, 41);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 17);
            this.label35.TabIndex = 30;
            this.label35.Text = "fck=";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(372, 39);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 17);
            this.label36.TabIndex = 29;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 41);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(176, 17);
            this.label37.TabIndex = 27;
            this.label37.Text = "Concrete strength class";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.textBox_n);
            this.groupBox3.Controls.Add(this.comboBoxDiam);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 109);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reinforcement";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(374, 71);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 17);
            this.label26.TabIndex = 53;
            this.label26.Text = "kpl";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(374, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 17);
            this.label25.TabIndex = 51;
            this.label25.Text = "mm";
            // 
            // textBox_n
            // 
            this.textBox_n.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox_n.Location = new System.Drawing.Point(268, 66);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(100, 24);
            this.textBox_n.TabIndex = 51;
            this.textBox_n.Leave += new System.EventHandler(this.textBox_n_Leave);
            // 
            // comboBoxDiam
            // 
            this.comboBoxDiam.Font = new System.Drawing.Font("Verdana", 8F);
            this.comboBoxDiam.FormattingEnabled = true;
            this.comboBoxDiam.Location = new System.Drawing.Point(268, 41);
            this.comboBoxDiam.Name = "comboBoxDiam";
            this.comboBoxDiam.Size = new System.Drawing.Size(100, 24);
            this.comboBoxDiam.TabIndex = 52;
            this.comboBoxDiam.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiam_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(204, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "n=";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 69);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 17);
            this.label21.TabIndex = 31;
            this.label21.Text = "Amount";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(204, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 17);
            this.label22.TabIndex = 30;
            this.label22.Text = "d=";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(372, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 17);
            this.label23.TabIndex = 29;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 17);
            this.label24.TabIndex = 27;
            this.label24.Text = "Diameter";
            // 
            // listBoxCorbels
            // 
            this.listBoxCorbels.FormattingEnabled = true;
            this.listBoxCorbels.ItemHeight = 16;
            this.listBoxCorbels.Location = new System.Drawing.Point(19, 616);
            this.listBoxCorbels.Name = "listBoxCorbels";
            this.listBoxCorbels.Size = new System.Drawing.Size(121, 148);
            this.listBoxCorbels.TabIndex = 55;
            this.listBoxCorbels.SelectedIndexChanged += new System.EventHandler(this.listBoxCorbels_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(501, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Load Cases";
            // 
            // Util
            // 
            this.Util.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Util.HeaderText = "Util";
            this.Util.Name = "Util";
            this.Util.ReadOnly = true;
            this.Util.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Util.Width = 60;
            // 
            // H_Ed
            // 
            this.H_Ed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.H_Ed.HeaderText = "H_Ed";
            this.H_Ed.Name = "H_Ed";
            this.H_Ed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.H_Ed.Width = 60;
            // 
            // F_Ed
            // 
            this.F_Ed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.F_Ed.HeaderText = "F_Ed";
            this.F_Ed.Name = "F_Ed";
            this.F_Ed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.F_Ed.Width = 60;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // dataGridViewLoadcases
            // 
            this.dataGridViewLoadcases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoadcases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLoadcases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoadcases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.F_Ed,
            this.H_Ed,
            this.Util});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoadcases.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLoadcases.Location = new System.Drawing.Point(501, 387);
            this.dataGridViewLoadcases.Name = "dataGridViewLoadcases";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoadcases.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLoadcases.RowHeadersVisible = false;
            this.dataGridViewLoadcases.RowHeadersWidth = 4;
            this.dataGridViewLoadcases.RowTemplate.Height = 24;
            this.dataGridViewLoadcases.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewLoadcases.Size = new System.Drawing.Size(211, 150);
            this.dataGridViewLoadcases.TabIndex = 56;
            this.dataGridViewLoadcases.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoadcases_CellEndEdit);
            this.dataGridViewLoadcases.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewLoadcases_RowsAdded);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(666, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "label10";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1294, 875);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewLoadcases);
            this.Controls.Add(this.listBoxCorbels);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chartStrength);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenDetailedResults);
            this.Name = "FormMain";
            this.Text = "Main Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoadcases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStrength;
        private System.Windows.Forms.Button buttonOpenDetailedResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_hc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_hn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_a5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxConcreteStrength;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox comboBoxSteelStrength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxDiam;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.ListBox listBoxCorbels;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox_bw;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Util;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Ed;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Ed;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridView dataGridViewLoadcases;
        private System.Windows.Forms.Label label10;
    }
}

