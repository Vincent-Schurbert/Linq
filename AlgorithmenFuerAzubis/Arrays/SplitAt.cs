using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class SplitAt
    {
        public (int[], int[]) SplitAt_Funktion(int[] SplitAt_Array, int Index) //Parameter für UnitTests
        {
            //Nur bei der Hälfte spliten
            int[] ErstesArray = new int[Index + 1]; //Die Grenze + den Index
            int[] ZweitesArray = new int[SplitAt_Array.Length - ErstesArray.Length]; //Länge - 1. Array = 2. Array
            int j = 0;

            for (int i = 0; i < SplitAt_Array.Length; i++) //Durchläuft die Schleife komplett
            {
                if (i < Index + 1)
                {
                  ErstesArray[i] = SplitAt_Array[i]; //wird in ErstesArray überschrieben + Wert des Index

                }

                if (i > Index)
                {
                    ZweitesArray[j] = SplitAt_Array[i]; //Überschreibt von Array zu ErstesArray
                    j++; //Neuer Index steigt jedes Mal

                }
            }

            return (ErstesArray, ZweitesArray);
        }
    }
}
