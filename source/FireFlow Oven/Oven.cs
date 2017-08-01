using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FireFlow_Oven {
    public partial class Oven : Form {

        public comLib currentPort = new comLib();
        public bool Com_Port_Connected;

        private int ChartUpdate_Counter = 0;

        private int[] Temperature_Array = new int[100];
        private int[] PID_Array = new int[100];

        private bool Oven_On = false;
        private byte Hour_On = 0;
        private byte Minute_On = 0;
        private byte Second_On = 0;
        UInt32 RemainingTime = 0;
        TempFile HistoryFile = new TempFile();
        int TimeBase = 1;

        //================== Basic =======================
        public Oven() {
            InitializeComponent();
        }
        private void Oven_Load(object sender, EventArgs e) {
            Timer_Temperature.Enabled = true;
            HelpRequested += new HelpEventHandler(this.Form_HelpRequested);
            menuStrip1.Renderer = new MyRenderer(new TestColorTable());
        }
        private void Form_HelpRequested(object sender, HelpEventArgs hlpevent) {
            helpToolStripMenuItem.ShowDropDown();
        }
        private void Oven_Shown(object sender, EventArgs e) {
            SerialPortService.PortsChanged += (sender1, changedArgs) => SerialPort_Listener(changedArgs.SerialPorts);

            //Load Settings
            Numeric_UpDown_Temperature.Value = Properties.Settings.Default.Temperature;

            num_Hour.Value = Properties.Settings.Default.Time_H;
            num_Minute.Value = Properties.Settings.Default.Time_M;
            num_Sec.Value = Properties.Settings.Default.Time_S;

            numeric_Refresh.Value = Properties.Settings.Default.Refresh_Rate;
            checkBox_Clear_History.Checked = Properties.Settings.Default.Clear_PID;

            int maxTime = Properties.Settings.Default.Max_Time;
            int maxTemp = Properties.Settings.Default.Max_Temp;

            TimeBase = Properties.Settings.Default.TimeBase;
            if (TimeBase == 1)
                comboBoxTimeBase.SelectedIndex = 0;
            else if (TimeBase == 60)
                comboBoxTimeBase.SelectedIndex = 1;
            else
                comboBoxTimeBase.SelectedIndex = 2;

            Temperature_Array = new int[maxTime + 1];
            PID_Array = new int[maxTime + 1];
            OutputChart.ChartAreas[0].AxisX.Maximum = maxTime;
            OutputChart.ChartAreas[0].AxisY.Maximum = maxTemp;
            OutputChart.ChartAreas[0].AxisX.Interval = Math.Round(OutputChart.ChartAreas[0].AxisX.Maximum / 5, 1);
            num_Max_Temp.Value = maxTemp;
            num_Max_Time.Value = maxTime;

        }
        private void Oven_FormClosing(object sender, FormClosingEventArgs e) {
            button_Stop_Click(null, null);
            HistoryFile.DeleteTmpFile();
            SerialPortService.CleanUp();
            Properties.Settings.Default.Save();
        }

        //================== Connection =======================
        public void Attempt_Connect_To_Port(string Port_Name) {
            if (Com_Port_Connected)
                Connection_Close();
            currentPort.setPortName(Port_Name);
            Port_Name = comLib.getPortCOM(Port_Name);
            //    Thread.Sleep(20);
            currentPort.setPortCom(Port_Name);
            currentPort.setDataBits(8);
            currentPort.setBaudRate(115200); //115200 bps
            if (currentPort.open()) {
                currentPort.clear();
                currentPort.write("AT+CONNECT\r");
                Thread.Sleep(20);
                if (currentPort.readLine().Contains("AT OK"))
                    Connection_Open();
                else {
                    Connection_Close();
                    MessageBox.Show("Failed to get proper AT response!", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else {
                Connection_Close();
                MessageBox.Show("Found port but failed to open it. Ensure no other program is using port and/or device was not recently disconnected.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Connection_Open() {
            Com_Port_Connected = true;
            labelConnect.ForeColor = Color.Lime;
            labelConnect.Text = "Connected";
            Set_PIDSetpoint(150);
            GetPIDGains();
            HistoryFile.CreateTmpFile();
        }
        public void Connection_Close() {
            currentPort.close();
            Com_Port_Connected = false;
            if (this.labelConnect.InvokeRequired) {
                this.labelConnect.BeginInvoke((MethodInvoker)delegate () {
                    this.labelConnect.Text = "Not Connected";
                    this.labelConnect.ForeColor = Color.Red;
                });
            } else {
                labelConnect.Text = "Not Connected";
                labelConnect.ForeColor = Color.Red;
            }
        }
        public string SendData(string Data) {
            Timer_Temperature.Enabled = false;
            if (Com_Port_Connected) {
                string FeedBack = string.Empty;
                currentPort.write(Data);
                try {
                    FeedBack = currentPort.readLine();
                    Timer_Temperature.Enabled = true;
                    return FeedBack;
                } catch (Exception) {
                    MessageBox.Show("Time Out Error\n Com port Closed");
                    Connection_Close();
                    Timer_Temperature.Enabled = true;
                    return string.Empty;
                }
            } else {
                Timer_Temperature.Enabled = true;
                return string.Empty;
            }
        }

        private void SerialPort_Listener(string[] SerialPorts) {
            if (!SerialPorts.Contains(currentPort.comPort.PortName) && Com_Port_Connected) {
                MessageBox.Show("Device Disconnected!");
                Connection_Close();
            }
        }

        //================== Graph =======================
        private void AddTemperaturePoint(int Temperature) {
            Array.Copy(Temperature_Array, 1, Temperature_Array, 0, Temperature_Array.Length - 1);
            Temperature_Array[Temperature_Array.Length - 1] = Temperature;
            UpdateOutputChart();
        }
        private void AddPIDOutput(int PID) {
            PID_Array[PID_Array.Length - 1] = PID;
            Array.Copy(PID_Array, 1, PID_Array, 0, PID_Array.Length - 1);
            UpdateOutputChart();
        }
        private void UpdateOutputChart() {
            OutputChart.Series["Temperature"].Points.Clear();
            OutputChart.Series["PID Output"].Points.Clear();

            for (int i = 0; i < Temperature_Array.Length; i++) {
                OutputChart.Series["Temperature"].Points.AddXY(i, Temperature_Array[i]);
                OutputChart.Series["PID Output"].Points.AddXY(i, PID_Array[i]);
            }
        }

        private void Timer_Temperature_Tick(object sender, EventArgs e) {
            if (Com_Port_Connected) {

                int Temperature = 0; //  Variables to store MCU data
                int PID_Output = 0;  //and writethem on TEMP file

                //Get Temperature Data from MCU
                string FeedBack = SendData("AT+TEMP\r");
                if (FeedBack != string.Empty) {
                    string Temp = FeedBack.Substring(0, FeedBack.Length - 1);
                    Temperature = int.Parse(Temp);
                }

                //Get PID Output Data from MCU
                FeedBack = SendData("AT+PID_OUT\r");
                if (FeedBack != string.Empty) {
                    string Temp = FeedBack.Substring(0, FeedBack.Length - 1);
                    PID_Output = int.Parse(Temp);
                }

                ChartUpdate_Counter++;
                if (ChartUpdate_Counter == TimeBase) {
                    ChartUpdate_Counter = 0;
                    label_Temperature.Text = Temperature + "°C";

                    AddTemperaturePoint(Temperature);
                    AddPIDOutput(PID_Output);
                }

                //Write Values to TEMP file in CSV format
                string FileData = Temperature + "," + PID_Output;

                HistoryFile.UpdateTmpFile(FileData);

                //Increase On time
                if (Oven_On) {
                    Increase_Working_Time();
                    TimeSpan time = TimeSpan.FromSeconds(Hour_On * 3600 + Minute_On * 60 + Second_On);

                    string str = time.ToString(@"hh\:mm\:ss");
                    label_Time.Text = str;
                    if (Hour_On == num_Hour.Value && Minute_On == num_Minute.Value && Second_On == num_Sec.Value)
                        button_Stop_Click(null, null);
                    if (RemainingTime > 0)
                        RemainingTime--;
                    if (RemainingTime == 0)
                        button_Stop_Click(null, null);
                }
            }
        }
        //================== Normal Functions =======================
        private void Increase_Working_Time() {
            if (Second_On < 59)
                Second_On++;
            else if (Minute_On < 59) {
                Second_On = 0;
                Minute_On++;
            } else {
                Second_On = 0;
                Minute_On = 0;
                Hour_On++;
            }
        }
        private void LoadHistoryValues() {
            int lines = HistoryFile.GetNUmberOfLines();
            if (lines > 0) {

                Temperature_Array = new int[(int)num_Max_Time.Value + 1];
                PID_Array = new int[(int)num_Max_Time.Value + 1];

                int Table_size = (lines >= PID_Array.Length * TimeBase) ? PID_Array.Length : lines / TimeBase;
                Table_size = (Table_size == 0) ? 1 : Table_size;

                int FirstValue = (lines - PID_Array.Length * TimeBase) > 0 ? lines - PID_Array.Length * TimeBase : 0;

                for (int i = 0; i < Table_size; i++) {
                    int pos = FirstValue + i * TimeBase;
                    string[] Line_Data = HistoryFile.GetDataAt(pos).Split(',');
                    Temperature_Array[PID_Array.Length - Table_size + i] = Convert.ToInt32(Line_Data[0]);
                    PID_Array[PID_Array.Length - Table_size + i] = Convert.ToInt32(Line_Data[1]);
                }
                UpdateOutputChart();
            }
        }

        //================== Listeners =======================
        //Buttons
        private void button_Start_Click(object sender, EventArgs e) {
            label_Time.Text = "00:00:00";
            string FeedBack = SendData("AT+OVEN_START\r");
            if (FeedBack.Contains("AT OK")) {
                button_Start.Enabled = false;
                button_Stop.Enabled = true;
                label_Status.Text = "Working";
                label_Status.ForeColor = Color.Lime;
                Oven_On = true;
                Hour_On = 0;
                Minute_On = 0;
                Second_On = 0;
                RemainingTime = (UInt32)(num_Hour.Value * 3600 + num_Minute.Value * 60 + num_Sec.Value);
                num_Hour.Enabled = false;
                num_Minute.Enabled = false;
                num_Sec.Enabled = false;
            }
        }
        private void button_Stop_Click(object sender, EventArgs e) {
            string FeedBack = SendData("AT+OVEN_STOP\r");
            if (FeedBack.Contains("AT OK")) {
                button_Stop.Enabled = false;
                button_Start.Enabled = true;
                Oven_On = false;
                label_Status.Text = "Oven Off";
                label_Status.ForeColor = Color.Orange;
                num_Hour.Enabled = true;
                num_Minute.Enabled = true;
                num_Sec.Enabled = true;
            }
        }
        private void button_Update_Gains_Click(object sender, EventArgs e) {
            string P = num_PID_P.Value.ToString(CultureInfo.InvariantCulture);
            string I = num_PID_I.Value.ToString(CultureInfo.InvariantCulture);
            string D = num_PID_D.Value.ToString(CultureInfo.InvariantCulture);

            string Data = "AT+SET_GAINS," + P + "," + I + "," + D + "\r";
            string FeedBack = SendData(Data);
            if (FeedBack.Contains("AT OK")) {
                //GetPIDGains();
                label_Sync_P.ForeColor = Color.Lime;
                label_Sync_P.Text = "Sync";
                label_Sync_I.ForeColor = Color.Lime;
                label_Sync_I.Text = "Sync";
                label_Sync_D.ForeColor = Color.Lime;
                label_Sync_D.Text = "Sync";
            }
            Set_PIDSetpoint((int)Numeric_UpDown_Temperature.Value);
        }
        private void buttonUpdateScale_Click(object sender, EventArgs e) {
            int maxTime = (int)num_Max_Time.Value;
            int maxTemp = (int)num_Max_Temp.Value;

            Properties.Settings.Default.Max_Time = maxTime;
            Properties.Settings.Default.Max_Temp = maxTemp;

            OutputChart.ChartAreas[0].AxisX.Maximum = maxTime;
            OutputChart.ChartAreas[0].AxisY.Maximum = maxTemp;

            OutputChart.ChartAreas[0].AxisX.Interval = Math.Round(OutputChart.ChartAreas[0].AxisX.Maximum / 5, 1);
            OutputChart.ChartAreas[0].AxisY.Interval = Math.Round(OutputChart.ChartAreas[0].AxisY.Maximum / 5, 1);

            LoadHistoryValues(); //Replace below commend
        }
        private void buttonClearData_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you Sure?\nThis will delete and every historical value!!!", "Clear all values?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                HistoryFile.ClearFile();
                int maxTime = (int)num_Max_Time.Value;
                Temperature_Array = new int[maxTime + 1];
                PID_Array = new int[maxTime + 1];
                UpdateOutputChart();
            }
        }

        //Comunication
        private void Set_PIDSetpoint(int SetPoint) {
            if (Com_Port_Connected) {
                string Data = "AT+PID_SET," + SetPoint + "\r";
                string FeedBack = SendData(Data);
                if (FeedBack.Contains("AT OK")) {
                    //Nothing
                }
            }
        }
        private void GetPIDGains() {
            string FeedBack = SendData("AT+GET_P\r");
            if (FeedBack != string.Empty) {
                string Temp = FeedBack.Substring(0, FeedBack.Length - 2);
                float PID_P = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
                num_PID_P.Value = Convert.ToDecimal(PID_P);
                label_Sync_P.ForeColor = Color.Lime;
                label_Sync_P.Text = "Sync";
            }
            FeedBack = SendData("AT+GET_I\r");
            if (FeedBack != string.Empty) {
                string Temp = FeedBack.Substring(0, FeedBack.Length - 2);
                float PID_I = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
                num_PID_I.Value = Convert.ToDecimal(PID_I);
                label_Sync_I.ForeColor = Color.Lime;
                label_Sync_I.Text = "Sync";
            }
            FeedBack = SendData("AT+GET_D\r");
            if (FeedBack != string.Empty) {
                string Temp = FeedBack.Substring(0, FeedBack.Length - 2);
                float PID_D = float.Parse(Temp, CultureInfo.InvariantCulture.NumberFormat);
                num_PID_D.Value = Convert.ToDecimal(PID_D);
                label_Sync_D.ForeColor = Color.Lime;
                label_Sync_D.Text = "Sync";
            }
        }

        private void numeric_Refresh_ValueChanged(object sender, EventArgs e) {
            Timer_Temperature.Interval = (int)numeric_Refresh.Value * 1000;
            Properties.Settings.Default.Refresh_Rate = (int)numeric_Refresh.Value;
        }
        private void Numeric_UpDown_Temperature_ValueChanged(object sender, EventArgs e) => Properties.Settings.Default.Temperature = (int)Numeric_UpDown_Temperature.Value;
        private void num_Hour_ValueChanged(object sender, EventArgs e) => Properties.Settings.Default.Time_H = (int)num_Hour.Value;
        private void num_Minute_ValueChanged(object sender, EventArgs e) => Properties.Settings.Default.Time_M = (int)num_Minute.Value;
        private void num_Sec_ValueChanged(object sender, EventArgs e) => Properties.Settings.Default.Time_S = (int)num_Sec.Value;

        private void num_PID_P_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
                e.KeyChar = (CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        }
        private void num_PID_I_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
                e.KeyChar = (CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];

        }
        private void num_PID_D_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
                e.KeyChar = (CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        }
        private void num_PID_P_ValueChanged(object sender, EventArgs e) {
            label_Sync_P.ForeColor = Color.White;
            label_Sync_P.Text = "unSync";
        }
        private void num_PID_I_ValueChanged(object sender, EventArgs e) {
            label_Sync_I.ForeColor = Color.White;
            label_Sync_I.Text = "unSync";
        }
        private void num_PID_D_ValueChanged(object sender, EventArgs e) {
            label_Sync_D.ForeColor = Color.White;
            label_Sync_D.Text = "unSync";
        }

        private void checkBox_Clear_History_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.Clear_PID = checkBox_Clear_History.Checked;
            string Data = (checkBox_Clear_History.Checked) ? "AT+PID_NOCLEAR\r" : "AT+PID_CLEAR\r";
            string FeedBack = SendData(Data);
            if (FeedBack.Contains("AT OK")) {
            }
        }

        private void comboBoxTimeBase_SelectedIndexChanged(object sender, EventArgs e) {
            OutputChart.ChartAreas[0].AxisX.Title = "Time (" + comboBoxTimeBase.SelectedItem + ")";
            if (comboBoxTimeBase.SelectedIndex == 0)
                TimeBase = 1;
            else if (comboBoxTimeBase.SelectedIndex == 1)
                TimeBase = 60;
            else
                TimeBase = 3600;
            ChartUpdate_Counter = 0;
            Properties.Settings.Default.TimeBase = TimeBase;

            buttonUpdateScale_Click(null, null); //Handle X-Y and load history
        }


        //================== Menu Strip =======================

        //Export
        private void TextToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            dialog.FilterIndex = 1;// Prefer png files
            dialog.Title = "Save Chart as Text";
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.SupportMultiDottedExtensions = true;
            dialog.AddExtension = true;
            if ((dialog.ShowDialog() == DialogResult.OK))
                HistoryFile.ExportTmpFile(dialog.FileName);
        }
        private void ImageToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
            dialog.FilterIndex = 4;// Prefer png files
            dialog.Title = "Save Chart as Image";
            dialog.RestoreDirectory = true;
            dialog.OverwritePrompt = true;
            dialog.SupportMultiDottedExtensions = true;
            dialog.AddExtension = true;

            if ((dialog.ShowDialog() == DialogResult.OK))
                if (Path.GetExtension(dialog.FileName).ToLower() == ".bmp")
                    OutputChart.SaveImage(dialog.FileName, ImageFormat.Bmp);
                else if (Path.GetExtension(dialog.FileName).ToLower() == ".jpg")
                    OutputChart.SaveImage(dialog.FileName, ImageFormat.Jpeg);
                else if (Path.GetExtension(dialog.FileName).ToLower() == ".gif")
                    OutputChart.SaveImage(dialog.FileName, ImageFormat.Gif);
                else if (Path.GetExtension(dialog.FileName).ToLower() == ".png")
                    OutputChart.SaveImage(dialog.FileName, ImageFormat.Png);
                else if (Path.GetExtension(dialog.FileName).ToLower() == ".tif")
                    OutputChart.SaveImage(dialog.FileName, ImageFormat.Tiff);
        }
        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //Connection
        private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
            new Connection { MainForm = this }.Show();
        }
        private void disconectToolStripMenuItem_Click(object sender, EventArgs e) {
            if (Com_Port_Connected) {
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to disconnect from " + currentPort.getPortName() + "??",
                                     "Confirm Disconnect!!",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                    Connection_Close();
            }
        }
        private void labelConnect_Click(object sender, EventArgs e) {
            if (Com_Port_Connected)
                disconectToolStripMenuItem_Click(null, null);
            else
                new Connection { MainForm = this }.Show();
        }
        //Help Menu Strip
        private void manualToolStripMenuItem_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/FireFlowController/FireFlow-Oven/blob/master/docs/Fire%20Flow%20Oven%20Manual.pdf");
        }
        private void temperatureControlsToolStripMenuItem_Click(object sender, EventArgs e) {
            License form = new License();
            form.SetTitle("Help");
            form.Show();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b Temperature: \b0 ");
            sb.Append(@"The desired temperature inside the oven");
            sb.Append(@"}");

            form.SetText(sb.ToString());
        }
        private void PIDControlsToolStripMenuItem_Click(object sender, EventArgs e) {
            License form = new License();
            form.SetTitle("Help");
            form.Show();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b P: \b0 ");
            sb.Append(@"Proportional Gain value");
            sb.Append(@" \line ");
            sb.Append(@"\b I: \b0 ");
            sb.Append(@"Integral Gain value");
            sb.Append(@" \line ");
            sb.Append(@"\b D: \b0 ");
            sb.Append(@"Derivative Gain value");
            sb.Append(@" \line ");
            sb.Append(@"\b Bumpless: \b0 ");
            sb.Append(@"After every Gain Update the controller keeps the historical values accosiated with Integral & Derivative gains to ovoid output peaks");
            sb.Append(@" \line ");
            sb.Append(@"\b Update Gains & Temp: \b0 ");
            sb.Append(@"The values from P,I,D & Temperature SetPoint are transmitted to controller.");
            sb.Append(@" \line ");
            sb.Append(@"\b Sync/unSync: \b0 ");
            sb.Append(@" On success transmission of PID values labels turn green, if the values are not transmitted to controller they are white.");
            sb.Append(@"}");

            form.SetText(sb.ToString());
        }
        private void ovenFeedbackToolStripMenuItem_Click(object sender, EventArgs e) {
            License form = new License();
            form.SetTitle("Help");
            form.Show();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b Temperature: \b0 ");
            sb.Append(@"The current temperature inside the oven");
            sb.Append(@" \line ");
            sb.Append(@"\b Time: \b0 ");
            sb.Append(@"The time since the begin");
            sb.Append(@" \line ");
            sb.Append(@"\b Status: \b0 ");
            sb.Append(@"The state of controller, if it is On or Off");
            sb.Append(@"}");

            form.SetText(sb.ToString());
        }
        private void graphControlsToolStripMenuItem_Click(object sender, EventArgs e) {
            License form = new License();
            form.SetTitle("Help");
            form.Show();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b Max Temp: \b0 ");
            sb.Append(@"Maximum left Y Axis value, which defines maximum temperature display");
            sb.Append(@" \line ");
            sb.Append(@"\b Max Time: \b0 ");
            sb.Append(@"Maximum X Axis value, which defines maximum historical values display");
            sb.Append(@" \line ");
            sb.Append(@"\b Refresh Rate: \b0 ");
            sb.Append(@"Defines the time between 2 points displayed in chart, it doesn't change refresh rate and not displayed values are stored in temp file");
            sb.Append(@" \line ");
            sb.Append(@"\b Update Scale: \b0 ");
            sb.Append(@"Updates the new defined settings in Chart widget");
            sb.Append(@" \line ");
            sb.Append(@"\b Clear Recieved Data: \b0 ");
            sb.Append(@"Clears all the data from chart and Temp file too!");
            sb.Append(@"}");

            form.SetText(sb.ToString());
        }
        private void timeControlsToolStripMenuItem1_Click(object sender, EventArgs e) {
            License form = new License();
            form.SetTitle("Help");
            form.Show();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\ansi");
            sb.Append(@"\b Time [ h : m : s ]: \b0 ");
            sb.Append(@"The time that the oven will be on after start formated in Hours :  Minutes : Seconds");
            sb.Append(@" \line ");
            sb.Append(@"\b Refresh Rate: \b0 ");
            sb.Append(@"The time in seconds between two temperatures requests from UART");
            sb.Append(@"}");

            form.SetText(sb.ToString());
        }
        //About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            About f = new About();
            f.Show();
        }
    }
    public class TestColorTable : ProfessionalColorTable {
        Color DarkGray = Color.FromArgb(33, 33, 33);

        public override Color MenuItemSelected {
            get { return DarkGray; }
        }

        public override Color MenuBorder {  //DropDown menu border Color 
            get { return DarkGray; }
        }
        public override Color MenuItemBorder { //Item border
            get { return Color.White; }
        }

        //Mouse hover Select
        public override Color MenuItemSelectedGradientBegin {
            get { return Color.Black; }
        }
        public override Color MenuItemSelectedGradientEnd {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientBegin {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientEnd {
            get { return Color.Black; }
        }
    }

    public class MyRenderer : ToolStripProfessionalRenderer {
        public MyRenderer(ProfessionalColorTable professionalColorTable) : base(professionalColorTable) { }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e) {
            if (!e.Vertical || (e.Item as ToolStripSeparator) == null) {
                ToolStripSeparator toolStripSeparator = (ToolStripSeparator)e.Item;
                int width = toolStripSeparator.Width;
                int height = toolStripSeparator.Height;
                Color foreColor = Color.LightGray;
                Color backColor = Color.FromArgb(66, 66, 66); ;

                // Fill the background.
                e.Graphics.FillRectangle(new SolidBrush(backColor), 0, 0, width, height);

                // Draw the line.
                e.Graphics.DrawLine(new Pen(foreColor), 4, height / 2, width - 4, height / 2);
            } else
                base.OnRenderSeparator(e);
        }
    }
}
