using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Chiavi
{
    class BarCodeReader
    {
        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
        public string receivedData;
        Form1 mainForm;

        SerialPort ComPort;
        bool PORT_STATE = false;

        public BarCodeReader(Form1 mainForm)
        {
           this.mainForm = mainForm;
           ComPort = new SerialPort();
           Open();
           ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
        }

        ~BarCodeReader()
        {
            Close();
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPort.ReadExisting().Replace("\r\n", string.Empty);
            if (InputData != String.Empty)
            {
                mainForm.barcodeData(InputData);
            }
        }

        public void Close()
        {
            PORT_STATE = false;
            ComPort.Close();
        }
        public void Open() 
        {
                PORT_STATE = true;
                ComPort.PortName = "COM3";
                ComPort.BaudRate = 9600;
                ComPort.DataBits = 8;
                ComPort.StopBits = System.IO.Ports.StopBits.One;
                // ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShaking.Text);
                ComPort.Parity = Parity.None;
                ComPort.Open();
        }
    }
}
