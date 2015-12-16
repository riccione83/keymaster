using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Chiavi
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            Options options = new Options();
            txtNumOfKeyPerBox.Text = options.numOfKeyPerBox.ToString();
            txtNumOfBoxPerRow.Text = options.numOfBoxPerRow.ToString();
            txtNumOfRow.Text = options.numOfRow.ToString();
            txtNumOfBox.Text = options.numOfBox.ToString();
            txtComPort.Text = options.ComPort;
            txtComSpeed.Text = options.BaudSpeed.ToString();
            ckUseComPort.Checked = options.UseSerialPort;

            string[] serialPorts = SerialPort.GetPortNames();
            foreach (String serialName in serialPorts)
            {
                txtComPort.Items.Add(serialName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.numOfKeyPerBox = int.Parse(txtNumOfKeyPerBox.Text);
            options.numOfBoxPerRow = int.Parse(txtNumOfBoxPerRow.Text);
            options.numOfRow = int.Parse(txtNumOfRow.Text);
            options.numOfBox = int.Parse(txtNumOfBox.Text);
            options.ComPort = txtComPort.Text;
            options.BaudSpeed = int.Parse(txtComSpeed.Text);
            options.UseSerialPort = ckUseComPort.Checked;
            options.saveOptions();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

/*
const int numOfKeyPerBox = 2;
const int numOfBoxPerRow = 10;
const int numOfRow = 10;
const int numOfBox = 3;          
*/