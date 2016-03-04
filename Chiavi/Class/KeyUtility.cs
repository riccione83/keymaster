using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chiavi
{
    class KeyUtility
    {
        int[,,] position;
        int numOfKeyPerBox; //= 2;   //Numero di chiavi che si possono inserire in un cassetto
        int numOfBoxPerRow; //= 10;   //Numero di cassetti per ogni riga
        int numOfRow; //= 10;         //numero di file di cassetti (righe per armadio)
        int numOfBox;// = 3;          //Numero di armadi (questo valore è espresso * 2 visto che hanno due facce

        public int getNumOfBox() {
           return numOfBox;
        }

        public int getNumOfCols()
        {
            return numOfBoxPerRow;
        }
        public int getNumOfRows()
        {
            return numOfRow;
        }

        public KeyUtility()
        {
            Options opt = new Options();
            this.numOfKeyPerBox = opt.numOfKeyPerBox;   //Numero di chiavi che si possono inserire in un cassetto
            this.numOfBoxPerRow = opt.numOfBoxPerRow;   //Numero di cassetti per ogni riga
            this.numOfRow = opt.numOfRow;               //numero di file di cassetti (righe per armadio)
            this.numOfBox = opt.numOfBox;               //Numero di armadi (questo valore è espresso * 2 visto che hanno due facce


            position = new int[numOfBox * 2, numOfRow, numOfBoxPerRow];
            for (int face = 0; face < numOfBox * 2; face++)
            {
                for (int row = 0; row < numOfRow; row++)
                {
                    for (int box = 0; box < numOfBoxPerRow; box++)
                    {
                        position[face,row,box] = 0;
                    }
                }
            }
        }

        public string getFace(int face)
        {
            switch (face)
            {
                case 0: return "A1";
                case 1: return "A2";
                case 2: return "B1";
                case 3: return "B2";
                case 4: return "C1";
                case 5: return "C2";
                case 6: return "D1";
                case 7: return "D2";
                case 8: return "E1";
                case 9: return "E2";
                case 10: return "F1";
                case 11: return "F2";
                case 12: return "G1";
                case 13: return "G2";
                case 14: return "H1";
                case 15: return "H2";
                case 16: return "I1";
                case 17: return "I2";
                case 18: return "J1";
                case 19: return "J2";
                case 20: return "K1";
                case 21: return "K2";
                case 22: return "L1";
                case 23: return "L2";
                case 24: return "M1";
                case 25: return "M2";
                case 26: return "N1";
                case 27: return "N2";
                case 28: return "O1";
                case 29: return "O2";
                case 30: return "P1";
                case 31: return "P2";
                case 32: return "Q1";
                case 33: return "Q2";
                case 34: return "R1";
                case 35: return "R2";
                case 36: return "S1";
                case 37: return "S2";
                case 38: return "T1";
                case 39: return "T2";
                case 40: return "U1";
                case 41: return "U2";
                case 42: return "V1";
                case 43: return "V2";
                case 44: return "X1";
                case 45: return "X2";
                case 46: return "Y1";
                case 47: return "Y2";
                case 48: return "W1";
                case 49: return "W2";
                case 50: return "Z1";
                case 51: return "Z2";
                default: return "";
            }
        }

        public void refreshPositions(Keys keys)
        {
            position = new int[numOfBox * 2, numOfRow, numOfBoxPerRow];
            foreach(Key key in keys.keys)
            {
                string[] currentKey = key.Position.Split('-');
                if (currentKey.Length >= 3)
                {
                    int x = int.Parse(currentKey[0]);
                    int y = int.Parse(currentKey[1]);
                    int z = int.Parse(currentKey[2]);
                    position[x, y, z]++;
                }
            }
        }
        public void setInBoxSpace(int x, int y, int z)
        {
            position[x, y, z]++;
        }

        public int[] getFreeBoxSpace()
        {
            int[] pos = new int[3];

            for (int face = 0; face < numOfBox * 2; face++)
            {
                for (int row = 0; row < numOfRow; row++)
                {
                    for (int box = 0; box < numOfBoxPerRow; box++)
                    {
                        if (position[face, row, box] < numOfKeyPerBox)
                        {
                            pos[0] = face;
                            pos[1] = row;
                            pos[2] = box;
                            //position[face, row, box]++;
                            return pos;
                        }
                    }
                }
            }
            return pos;
        }
        public string searchFreeBoxSpace()
        {
            for (int face = 0; face < numOfBox * 2; face++)
            {
                for (int row = 0; row < numOfRow; row++)
                {
                    for (int box = 0; box < numOfBoxPerRow; box++)
                    {
                        if (position[face,row,box] < numOfKeyPerBox)
                        {
                            //position[face,row,box]++;
                            return getFace(face) + " - " + row.ToString() + " - " + box.ToString();
                        }
                    }
                }
            }
            return "";
        }
    }
}
