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
