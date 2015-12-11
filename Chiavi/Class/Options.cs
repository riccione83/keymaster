using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiavi
{
    class Options
    {
        string _comPort;
        int _baudSpeed;
        int _numOfKeyPerBox;         //Numero di chiavi che si possono inserire in un cassetto
        int _numOfBoxPerRow;         //Numero di cassetti per ogni riga
        int _numOfRow;               //numero di file di cassetti (righe per armadio)
        int _numOfBox;               //Numero di armadi (questo valore è espresso * 2 visto che hanno due facce
        bool _useSerialPort;

        //Variables
        public bool UseSerialPort
        {
            get { return _useSerialPort; }
            set { this._useSerialPort = value; }
        }
        public string ComPort
        {
            get { return _comPort; }
            set { this._comPort = value;  }
        }
        public int BaudSpeed
        {
            get { return _baudSpeed; }
            set { this._baudSpeed = value; }
        }
        public int numOfKeyPerBox
        {
            get { return _numOfKeyPerBox; }
            set { this._numOfKeyPerBox = value; }
        }
        public int numOfBoxPerRow
        {
            get { return _numOfBoxPerRow; }
            set { this._numOfBoxPerRow = value; }
        }
        public int numOfRow
        {
            get { return _numOfRow; }
            set { this._numOfRow = value; }
        }
        public int numOfBox
        {
            get { return _numOfBox; }
            set { this._numOfBox = value; }
        }

        public Options()
        {
            loadOptions();
        }

        public bool saveOptions()
        {
            using (StreamWriter wr = new StreamWriter("options.txt"))
            {
               wr.WriteLine(ComPort);
               wr.WriteLine(BaudSpeed);
               wr.WriteLine(UseSerialPort);
               wr.WriteLine(numOfKeyPerBox);
               wr.WriteLine(numOfBoxPerRow);
               wr.WriteLine(numOfRow);
               wr.WriteLine(numOfBox);
            }
            return false;
        }
        public void loadOptions()
        {
            if (File.Exists("options.txt"))
            {
                using (StreamReader rd = new StreamReader("options.txt"))
                {
                    ComPort = rd.ReadLine();
                    BaudSpeed = int.Parse(rd.ReadLine());
                    UseSerialPort = Boolean.Parse(rd.ReadLine());
                    numOfKeyPerBox = int.Parse(rd.ReadLine());
                    numOfBoxPerRow = int.Parse(rd.ReadLine());
                    numOfRow = int.Parse(rd.ReadLine());
                    numOfBox = int.Parse(rd.ReadLine());
                }
            }
            else
            {
                    //Load default values
                ComPort = "COM1";
                BaudSpeed =9600;
                numOfKeyPerBox = 2;
                numOfBoxPerRow = 10;
                numOfRow = 10;
                numOfBox = 3;
                UseSerialPort = false;
            }
        }
    }
}
