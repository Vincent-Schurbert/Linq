using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class TachometerInc
    {
        public int[] TachometerInc_Funktion(int[] Start_Array) //Parameter für UnitTests
        {
            int[] Ergebnis_Array = new int[Start_Array.Length];
            int Zahl;

            for (int i = Start_Array.Length - 1; Start_Array[i] < Start_Array[i] + 1; Start_Array[i]++)
            {

                Ergebnis_Array[i] = Start_Array[i];

                 if (Start_Array[i] > 9)
                 {
                    Start_Array[i] = 0;
                    Zahl = Start_Array[i - 1] + 1;

                    if (Start_Array[0] == 9)
                    {
                        Start_Array[i] = 9;
                    }
                 }
            }

            return Ergebnis_Array;
        }
    }
}
