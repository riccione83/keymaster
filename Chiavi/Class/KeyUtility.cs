using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chiavi
{
    class KeyUtility
    {
        int[,,] position;
        const int numOfKeyPerBox = 1;   //Numero di chiavi che si possono inserire in un cassetto
        const int numOfBoxPerRow = 10;   //Numero di cassetti per ogni riga
        const int numOfRow = 10;         //numero di file di cassetti (righe per armadio)
        const int numOfBox = 3;          //Numero di armadi (questo valore è espresso * 2 visto che hanno due facce

        public KeyUtility()
        {
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
                            position[face,row,box]++;
                            return getFace(face) + " - " + row.ToString() + " - " + box.ToString();
                        }
                    }
                }
            }
            return "";
        }
    }
}
