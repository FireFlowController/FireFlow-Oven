namespace FireFlow_Oven {
    partial class Oven {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oven));
            this.OutputChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Numeric_UpDown_Temperature = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.num_Hour = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_Minute = new System.Windows.Forms.NumericUpDown();
            this.num_Sec = new System.Windows.Forms.NumericUpDown();
            this.Timer_Temperature = new System.Windows.Forms.Timer(this.components);
            this.numeric_Refresh = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.num_Max_Time = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTimeBase = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonUpdateScale = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.num_Max_Temp = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.num_PID_P = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_PID_I = new System.Windows.Forms.NumericUpDown();
            this.num_PID_D = new System.Windows.Forms.NumericUpDown();
            this.button_Update_Gains = new System.Windows.Forms.Button();
            this.checkBox_Clear_History = new System.Windows.Forms.CheckBox();
            this.label_Sync_P = new System.Windows.Forms.Label();
            this.label_Sync_I = new System.Windows.Forms.Label();
            this.label_Sync_D = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inProgramHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIDControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ovenFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureControlsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeControlsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_UpDown_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Refresh)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max_Temp)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_D)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputChart
            // 
            this.OutputChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputChart.BackColor = System.Drawing.Color.Black;
            this.OutputChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.OutputChart.BackSecondaryColor = System.Drawing.Color.Maroon;
            this.OutputChart.BorderlineColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.Title = "Time (Seconds)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 500D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.Title = "Temperature (Celcius)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.Maximum = 1000D;
            chartArea1.AxisY2.Title = "PID Output";
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.OutputChart.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.White;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.Title = "Legend";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.OutputChart.Legends.Add(legend1);
            this.OutputChart.Location = new System.Drawing.Point(3, 3);
            this.OutputChart.Name = "OutputChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "IsXAxisQuantitative=False, EmptyPointValue=Zero, LineTension=0.1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.Points.Add(dataPoint1);
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.CustomProperties = "EmptyPointValue=Zero, LineTension=0.1";
            series2.Legend = "Legend1";
            series2.Name = "PID Output";
            series2.Points.Add(dataPoint2);
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.OutputChart.Series.Add(series1);
            this.OutputChart.Series.Add(series2);
            this.OutputChart.Size = new System.Drawing.Size(947, 632);
            this.OutputChart.TabIndex = 0;
            // 
            // Numeric_UpDown_Temperature
            // 
            this.Numeric_UpDown_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numeric_UpDown_Temperature.Location = new System.Drawing.Point(3, 22);
            this.Numeric_UpDown_Temperature.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.Numeric_UpDown_Temperature.Name = "Numeric_UpDown_Temperature";
            this.Numeric_UpDown_Temperature.Size = new System.Drawing.Size(75, 20);
            this.Numeric_UpDown_Temperature.TabIndex = 2;
            this.Numeric_UpDown_Temperature.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Numeric_UpDown_Temperature.ValueChanged += new System.EventHandler(this.Numeric_UpDown_Temperature_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature";
            // 
            // button_Start
            // 
            this.button_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Start.AutoSize = true;
            this.button_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Start.FlatAppearance.BorderSize = 0;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_Start.ForeColor = System.Drawing.Color.White;
            this.button_Start.Location = new System.Drawing.Point(4, 4);
            this.button_Start.Margin = new System.Windows.Forms.Padding(4);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(153, 23);
            this.button_Start.TabIndex = 20;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Stop.AutoSize = true;
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Stop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Stop.FlatAppearance.BorderSize = 0;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Location = new System.Drawing.Point(4, 35);
            this.button_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(153, 23);
            this.button_Stop.TabIndex = 21;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // num_Hour
            // 
            this.num_Hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Hour.Location = new System.Drawing.Point(3, 19);
            this.num_Hour.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.num_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_Hour.Name = "num_Hour";
            this.num_Hour.Size = new System.Drawing.Size(35, 20);
            this.num_Hour.TabIndex = 22;
            this.num_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Hour.ValueChanged += new System.EventHandler(this.num_Hour_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time [ h : m : s ]";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_Minute
            // 
            this.num_Minute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Minute.Location = new System.Drawing.Point(42, 19);
            this.num_Minute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_Minute.Name = "num_Minute";
            this.num_Minute.Size = new System.Drawing.Size(35, 20);
            this.num_Minute.TabIndex = 26;
            this.num_Minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Minute.ValueChanged += new System.EventHandler(this.num_Minute_ValueChanged);
            // 
            // num_Sec
            // 
            this.num_Sec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Sec.Location = new System.Drawing.Point(81, 19);
            this.num_Sec.Margin = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.num_Sec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_Sec.Name = "num_Sec";
            this.num_Sec.Size = new System.Drawing.Size(35, 20);
            this.num_Sec.TabIndex = 27;
            this.num_Sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_Sec.ValueChanged += new System.EventHandler(this.num_Sec_ValueChanged);
            // 
            // Timer_Temperature
            // 
            this.Timer_Temperature.Interval = 1000;
            this.Timer_Temperature.Tick += new System.EventHandler(this.Timer_Temperature_Tick);
            // 
            // numeric_Refresh
            // 
            this.numeric_Refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.numeric_Refresh, 3);
            this.numeric_Refresh.Location = new System.Drawing.Point(28, 42);
            this.numeric_Refresh.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numeric_Refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Refresh.Name = "numeric_Refresh";
            this.numeric_Refresh.Size = new System.Drawing.Size(60, 20);
            this.numeric_Refresh.TabIndex = 28;
            this.numeric_Refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Refresh.ValueChanged += new System.EventHandler(this.numeric_Refresh_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(120, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Refresh Rate (s)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OutputChart, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 638F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 638);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(953, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(231, 638);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(32, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 47);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Numeric_UpDown_Temperature, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(165, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Temperature Controls:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Location = new System.Drawing.Point(3, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 67);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.num_Hour, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.numeric_Refresh, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.num_Minute, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.num_Sec, 2, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(223, 65);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label6, 3);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Time Controls:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel7);
            this.panel5.Location = new System.Drawing.Point(34, 521);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 64);
            this.panel5.TabIndex = 31;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.button_Start, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.button_Stop, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(161, 62);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tableLayoutPanel9);
            this.panel6.Location = new System.Drawing.Point(13, 372);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 136);
            this.panel6.TabIndex = 31;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.num_Max_Time, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.comboBoxTimeBase, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.buttonUpdateScale, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.buttonClearData, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.num_Max_Temp, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(202, 134);
            this.tableLayoutPanel9.TabIndex = 8;
            // 
            // num_Max_Time
            // 
            this.num_Max_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Max_Time.Location = new System.Drawing.Point(78, 48);
            this.num_Max_Time.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.num_Max_Time.Name = "num_Max_Time";
            this.num_Max_Time.Size = new System.Drawing.Size(50, 20);
            this.num_Max_Time.TabIndex = 32;
            this.num_Max_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Max_Time.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // comboBoxTimeBase
            // 
            this.comboBoxTimeBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTimeBase.DisplayMember = "0";
            this.comboBoxTimeBase.FormattingEnabled = true;
            this.comboBoxTimeBase.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
            this.comboBoxTimeBase.Location = new System.Drawing.Point(134, 48);
            this.comboBoxTimeBase.Name = "comboBoxTimeBase";
            this.comboBoxTimeBase.Size = new System.Drawing.Size(65, 21);
            this.comboBoxTimeBase.TabIndex = 9;
            this.comboBoxTimeBase.Text = "Seconds";
            this.comboBoxTimeBase.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeBase_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.tableLayoutPanel9.SetColumnSpan(this.label11, 2);
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Graph Controls:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Max Temp:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(5, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Max Time:";
            // 
            // buttonUpdateScale
            // 
            this.buttonUpdateScale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdateScale.AutoSize = true;
            this.buttonUpdateScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel9.SetColumnSpan(this.buttonUpdateScale, 3);
            this.buttonUpdateScale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonUpdateScale.FlatAppearance.BorderSize = 0;
            this.buttonUpdateScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateScale.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateScale.Location = new System.Drawing.Point(24, 76);
            this.buttonUpdateScale.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateScale.Name = "buttonUpdateScale";
            this.buttonUpdateScale.Size = new System.Drawing.Size(153, 23);
            this.buttonUpdateScale.TabIndex = 18;
            this.buttonUpdateScale.Text = "Update Scale";
            this.buttonUpdateScale.UseVisualStyleBackColor = false;
            this.buttonUpdateScale.Click += new System.EventHandler(this.buttonUpdateScale_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(134, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 40;
            this.label17.Text = "°C";
            // 
            // buttonClearData
            // 
            this.buttonClearData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearData.AutoSize = true;
            this.buttonClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel9.SetColumnSpan(this.buttonClearData, 3);
            this.buttonClearData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.buttonClearData.FlatAppearance.BorderSize = 0;
            this.buttonClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonClearData.ForeColor = System.Drawing.Color.White;
            this.buttonClearData.Location = new System.Drawing.Point(24, 107);
            this.buttonClearData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(153, 23);
            this.buttonClearData.TabIndex = 36;
            this.buttonClearData.Text = "Clear Received Data";
            this.buttonClearData.UseVisualStyleBackColor = false;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // num_Max_Temp
            // 
            this.num_Max_Temp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_Max_Temp.Location = new System.Drawing.Point(78, 22);
            this.num_Max_Temp.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.num_Max_Temp.Name = "num_Max_Temp";
            this.num_Max_Temp.Size = new System.Drawing.Size(50, 20);
            this.num_Max_Temp.TabIndex = 41;
            this.num_Max_Temp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_Max_Temp.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Location = new System.Drawing.Point(33, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 153);
            this.panel3.TabIndex = 31;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.num_PID_P, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.num_PID_I, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.num_PID_D, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.button_Update_Gains, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.checkBox_Clear_History, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.label_Sync_P, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_Sync_I, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_Sync_D, 2, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(162, 151);
            this.tableLayoutPanel6.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(3, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "D:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "PID Controls:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "P:";
            // 
            // num_PID_P
            // 
            this.num_PID_P.DecimalPlaces = 5;
            this.num_PID_P.Location = new System.Drawing.Point(30, 22);
            this.num_PID_P.Name = "num_PID_P";
            this.num_PID_P.Size = new System.Drawing.Size(80, 20);
            this.num_PID_P.TabIndex = 22;
            this.num_PID_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_PID_P.ValueChanged += new System.EventHandler(this.num_PID_P_ValueChanged);
            this.num_PID_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_PID_P_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "I:";
            // 
            // num_PID_I
            // 
            this.num_PID_I.DecimalPlaces = 5;
            this.num_PID_I.Location = new System.Drawing.Point(30, 48);
            this.num_PID_I.Name = "num_PID_I";
            this.num_PID_I.Size = new System.Drawing.Size(80, 20);
            this.num_PID_I.TabIndex = 26;
            this.num_PID_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_PID_I.ValueChanged += new System.EventHandler(this.num_PID_I_ValueChanged);
            this.num_PID_I.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_PID_I_KeyPress);
            // 
            // num_PID_D
            // 
            this.num_PID_D.DecimalPlaces = 5;
            this.num_PID_D.Location = new System.Drawing.Point(30, 74);
            this.num_PID_D.Name = "num_PID_D";
            this.num_PID_D.Size = new System.Drawing.Size(80, 20);
            this.num_PID_D.TabIndex = 27;
            this.num_PID_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_PID_D.ValueChanged += new System.EventHandler(this.num_PID_D_ValueChanged);
            this.num_PID_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_PID_D_KeyPress);
            // 
            // button_Update_Gains
            // 
            this.button_Update_Gains.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Update_Gains.AutoSize = true;
            this.button_Update_Gains.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Update_Gains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel6.SetColumnSpan(this.button_Update_Gains, 3);
            this.button_Update_Gains.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Update_Gains.FlatAppearance.BorderSize = 0;
            this.button_Update_Gains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update_Gains.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_Update_Gains.ForeColor = System.Drawing.Color.White;
            this.button_Update_Gains.Location = new System.Drawing.Point(11, 124);
            this.button_Update_Gains.Margin = new System.Windows.Forms.Padding(4);
            this.button_Update_Gains.Name = "button_Update_Gains";
            this.button_Update_Gains.Size = new System.Drawing.Size(140, 23);
            this.button_Update_Gains.TabIndex = 41;
            this.button_Update_Gains.Text = "Update Gains && Temp";
            this.button_Update_Gains.UseVisualStyleBackColor = false;
            this.button_Update_Gains.Click += new System.EventHandler(this.button_Update_Gains_Click);
            // 
            // checkBox_Clear_History
            // 
            this.checkBox_Clear_History.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Clear_History.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.checkBox_Clear_History, 2);
            this.checkBox_Clear_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.checkBox_Clear_History.ForeColor = System.Drawing.Color.White;
            this.checkBox_Clear_History.Location = new System.Drawing.Point(30, 100);
            this.checkBox_Clear_History.Name = "checkBox_Clear_History";
            this.checkBox_Clear_History.Size = new System.Drawing.Size(79, 17);
            this.checkBox_Clear_History.TabIndex = 42;
            this.checkBox_Clear_History.Text = "Bumpless";
            this.checkBox_Clear_History.UseVisualStyleBackColor = true;
            this.checkBox_Clear_History.CheckedChanged += new System.EventHandler(this.checkBox_Clear_History_CheckedChanged);
            // 
            // label_Sync_P
            // 
            this.label_Sync_P.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sync_P.AutoSize = true;
            this.label_Sync_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Sync_P.ForeColor = System.Drawing.Color.White;
            this.label_Sync_P.Location = new System.Drawing.Point(113, 25);
            this.label_Sync_P.Margin = new System.Windows.Forms.Padding(0);
            this.label_Sync_P.Name = "label_Sync_P";
            this.label_Sync_P.Size = new System.Drawing.Size(49, 13);
            this.label_Sync_P.TabIndex = 49;
            this.label_Sync_P.Text = "unSync";
            // 
            // label_Sync_I
            // 
            this.label_Sync_I.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sync_I.AutoSize = true;
            this.label_Sync_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Sync_I.ForeColor = System.Drawing.Color.White;
            this.label_Sync_I.Location = new System.Drawing.Point(113, 51);
            this.label_Sync_I.Margin = new System.Windows.Forms.Padding(0);
            this.label_Sync_I.Name = "label_Sync_I";
            this.label_Sync_I.Size = new System.Drawing.Size(49, 13);
            this.label_Sync_I.TabIndex = 50;
            this.label_Sync_I.Text = "unSync";
            // 
            // label_Sync_D
            // 
            this.label_Sync_D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sync_D.AutoSize = true;
            this.label_Sync_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Sync_D.ForeColor = System.Drawing.Color.White;
            this.label_Sync_D.Location = new System.Drawing.Point(113, 77);
            this.label_Sync_D.Margin = new System.Windows.Forms.Padding(0);
            this.label_Sync_D.Name = "label_Sync_D";
            this.label_Sync_D.Size = new System.Drawing.Size(49, 13);
            this.label_Sync_D.TabIndex = 51;
            this.label_Sync_D.Text = "unSync";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tableLayoutPanel5);
            this.panel4.Location = new System.Drawing.Point(38, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 78);
            this.panel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label_Temperature, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label_Time, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label_Status, 1, 3);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(152, 76);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(20, 60);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Status:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Temperature:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label10, 2);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Oven Feedback:";
            // 
            // label_Temperature
            // 
            this.label_Temperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Temperature.ForeColor = System.Drawing.Color.Orange;
            this.label_Temperature.Location = new System.Drawing.Point(104, 22);
            this.label_Temperature.Margin = new System.Windows.Forms.Padding(3);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(31, 13);
            this.label_Temperature.TabIndex = 40;
            this.label_Temperature.Text = "0 °C";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Time:";
            // 
            // label_Time
            // 
            this.label_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Time.ForeColor = System.Drawing.Color.Orange;
            this.label_Time.Location = new System.Drawing.Point(91, 41);
            this.label_Time.Margin = new System.Windows.Forms.Padding(3);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(57, 13);
            this.label_Time.TabIndex = 43;
            this.label_Time.Text = "00:00:00";
            // 
            // label_Status
            // 
            this.label_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_Status.ForeColor = System.Drawing.Color.Orange;
            this.label_Status.Location = new System.Drawing.Point(91, 60);
            this.label_Status.Margin = new System.Windows.Forms.Padding(3);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(58, 13);
            this.label_Status.TabIndex = 46;
            this.label_Status.Text = "Oven Off";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSVToolStripMenuItem,
            this.ImageToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.ExportData_16x;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // CSVToolStripMenuItem
            // 
            this.CSVToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.CSVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CSVToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.GenerateFile_16x;
            this.CSVToolStripMenuItem.Name = "CSVToolStripMenuItem";
            this.CSVToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.CSVToolStripMenuItem.Text = "Text";
            this.CSVToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // ImageToolStripMenuItem
            // 
            this.ImageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ImageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ImageToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.GenerateResource_16x;
            this.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem";
            this.ImageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ImageToolStripMenuItem.Text = "Image";
            this.ImageToolStripMenuItem.Click += new System.EventHandler(this.ImageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.Exit_16x;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconectToolStripMenuItem});
            this.connectionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.Connect_16x;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconectToolStripMenuItem
            // 
            this.disconectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.disconectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.disconectToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.Disconnect_16x;
            this.disconectToolStripMenuItem.Name = "disconectToolStripMenuItem";
            this.disconectToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.disconectToolStripMenuItem.Text = "Disconect";
            this.disconectToolStripMenuItem.Click += new System.EventHandler(this.disconectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.inProgramHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.manualToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manualToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.MSHelpIndexFile_16x;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manualToolStripMenuItem.Text = "Online Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // inProgramHelpToolStripMenuItem
            // 
            this.inProgramHelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.inProgramHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIDControlsToolStripMenuItem,
            this.ovenFeedbackToolStripMenuItem,
            this.graphControlsToolStripMenuItem,
            this.temperatureControlsToolStripMenuItem1,
            this.timeControlsToolStripMenuItem1});
            this.inProgramHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inProgramHelpToolStripMenuItem.Name = "inProgramHelpToolStripMenuItem";
            this.inProgramHelpToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.inProgramHelpToolStripMenuItem.Text = "In program help";
            // 
            // pIDControlsToolStripMenuItem
            // 
            this.pIDControlsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pIDControlsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pIDControlsToolStripMenuItem.Name = "pIDControlsToolStripMenuItem";
            this.pIDControlsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pIDControlsToolStripMenuItem.Text = "PID Controls";
            this.pIDControlsToolStripMenuItem.Click += new System.EventHandler(this.PIDControlsToolStripMenuItem_Click);
            // 
            // ovenFeedbackToolStripMenuItem
            // 
            this.ovenFeedbackToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ovenFeedbackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ovenFeedbackToolStripMenuItem.Name = "ovenFeedbackToolStripMenuItem";
            this.ovenFeedbackToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ovenFeedbackToolStripMenuItem.Text = "Oven Feedback";
            this.ovenFeedbackToolStripMenuItem.Click += new System.EventHandler(this.ovenFeedbackToolStripMenuItem_Click);
            // 
            // graphControlsToolStripMenuItem
            // 
            this.graphControlsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.graphControlsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.graphControlsToolStripMenuItem.Name = "graphControlsToolStripMenuItem";
            this.graphControlsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.graphControlsToolStripMenuItem.Text = "Graph Controls";
            this.graphControlsToolStripMenuItem.Click += new System.EventHandler(this.graphControlsToolStripMenuItem_Click);
            // 
            // temperatureControlsToolStripMenuItem1
            // 
            this.temperatureControlsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.temperatureControlsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.temperatureControlsToolStripMenuItem1.Name = "temperatureControlsToolStripMenuItem1";
            this.temperatureControlsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.temperatureControlsToolStripMenuItem1.Text = "Temperature Controls";
            this.temperatureControlsToolStripMenuItem1.Click += new System.EventHandler(this.temperatureControlsToolStripMenuItem_Click);
            // 
            // timeControlsToolStripMenuItem1
            // 
            this.timeControlsToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.timeControlsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.timeControlsToolStripMenuItem1.Name = "timeControlsToolStripMenuItem1";
            this.timeControlsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.timeControlsToolStripMenuItem1.Text = "Time Controls";
            this.timeControlsToolStripMenuItem1.Click += new System.EventHandler(this.timeControlsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Image = global::FireFlow_Oven.Properties.Resources.UIAboutBox_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1004, 6);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Connection:";
            // 
            // labelConnect
            // 
            this.labelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnect.AutoSize = true;
            this.labelConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelConnect.ForeColor = System.Drawing.Color.Red;
            this.labelConnect.Location = new System.Drawing.Point(1081, 6);
            this.labelConnect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(92, 13);
            this.labelConnect.TabIndex = 32;
            this.labelConnect.Text = "Not Connected";
            this.labelConnect.Click += new System.EventHandler(this.labelConnect_Click);
            // 
            // Oven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Oven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oven";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oven_FormClosing);
            this.Load += new System.EventHandler(this.Oven_Load);
            this.Shown += new System.EventHandler(this.Oven_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OutputChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_UpDown_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Refresh)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max_Temp)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PID_D)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart OutputChart;
        private System.Windows.Forms.NumericUpDown Numeric_UpDown_Temperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.NumericUpDown num_Hour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_Minute;
        private System.Windows.Forms.NumericUpDown num_Sec;
        private System.Windows.Forms.Timer Timer_Temperature;
        private System.Windows.Forms.NumericUpDown numeric_Refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_PID_P;
        private System.Windows.Forms.NumericUpDown num_PID_I;
        private System.Windows.Forms.NumericUpDown num_PID_D;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_Update_Gains;
        private System.Windows.Forms.CheckBox checkBox_Clear_History;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox comboBoxTimeBase;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonUpdateScale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label_Sync_P;
        private System.Windows.Forms.Label label_Sync_I;
        private System.Windows.Forms.Label label_Sync_D;
        private System.Windows.Forms.NumericUpDown num_Max_Time;
        private System.Windows.Forms.NumericUpDown num_Max_Temp;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inProgramHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIDControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ovenFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureControlsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timeControlsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}