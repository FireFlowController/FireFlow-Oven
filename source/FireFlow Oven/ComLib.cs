using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Management;

namespace FireFlow_Oven {

    public class comLib {
        public SerialPort comPort = new SerialPort();
        private string _CurrentPortName = string.Empty;
        private static string[,] _PortsData;

        //Return Available COM Ports Friendly Names and stores them in Port Data
        public static string[] GetPortNames() {
            List<string> list = new List<string>();
            _PortsData = DiscoverPorts();
            for (byte i = 0; i < _PortsData.GetLength(0); i++)
                list.Add(_PortsData[i, 1]);
            return list.ToArray();
        }

        //Discovers USB COM Ports and Emulated COM Ports and Returns Names and Frinedly Names
        public static string[,] DiscoverPorts() {

            string[] portnames = SerialPort.GetPortNames();
            string[,] Result = new string[portnames.Length, 2];

            List<string> data = new List<string>();

            //#1 get Every port name and instance   
            using (var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM MSSerial_PortName")) {
                List<ManagementBaseObject> Allports = searcher.Get().Cast<ManagementBaseObject>().ToList();

                int counter = 0;
                foreach (ManagementObject queryObj in Allports) {
                    Result[counter, 0] = (queryObj["PortName"].ToString());
                    Result[counter, 1] = (queryObj["InstanceName"].ToString());
                    counter++;
                }
            }

            //#2 get usb port names
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort")) {
                List<ManagementBaseObject> USBports = searcher.Get().Cast<ManagementBaseObject>().ToList();

                //Copy 2nd column with Instance Names
                string[] index = new string[portnames.Length];
                for (byte i = 0; i < portnames.Length; i++)
                    index[i] = Result[i, 1];

                foreach (ManagementObject queryObj in USBports) {
                    int pos = Array.IndexOf(index, queryObj["PNPDeviceID"].ToString() + "_0");
                    Result[pos, 1] = queryObj["Name"].ToString();
                }
            }

            for (int i = 0; i < Result.GetLength(0); i++) {
                int pos = Result[i, 1].IndexOf("\\");
                if (pos > -1)
                    Result[i, 1] = Result[i, 1].Substring(0, pos) + " (" + Result[i, 0] + ")";
            }

            return Result;
        }

        //Returns COM Port Name based on Friendly Name
        public static string getPortCOM(string Com_Friendly_Name) {
            string[] index = new string[_PortsData.GetLength(0)];
            for (byte i = 0; i < _PortsData.GetLength(0); i++)
                index[i] = _PortsData[i, 1];

            int pos = Array.IndexOf(index, Com_Friendly_Name);
            if (pos > -1)
                return _PortsData[pos, 0];
            else
                return string.Empty;
        }

        //Current port Init
        public void setPortCom(string PortCom) {
            comPort.PortName = PortCom;
            comPort.WriteTimeout = 2000; //millisecond
            comPort.ReadTimeout = 10000; //millisecond
        }
        public void setPortName(string PortName) {
            _CurrentPortName = PortName;
        }
        public void setBaudRate(int baudrate) {
            comPort.BaudRate = baudrate;
        }
        public void setDataBits(int databits) {
            comPort.DataBits = databits;
        }

        //Get Functions
        public string getPortName() => _CurrentPortName;

        //Current Port Handling
        public bool open() {
            if (comPort.IsOpen)
                close();
            try {
                comPort.Open();
            } catch (Exception) {
                return false;
            }
            return comPort.IsOpen;
        }
        public void close() {
            try {
                comPort.Close();
                comPort.Dispose();
            } catch (Exception) {
            }
        }
        public void clear() {
            comPort.DiscardInBuffer();
        }

        //Read Write Functions
        public string read() => comPort.ReadExisting();
        public string readLine() => comPort.ReadLine();
        public void write(string Data) => comPort.Write(Data);

    }
}