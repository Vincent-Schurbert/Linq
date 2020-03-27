using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class TachometerAdd
    {
        private Prepend prepend = new Prepend();
        public int[] TachometerAdd_Funktion(int[] Array1, int[] Array2) //Parameter für UnitTests
        {
            LängeRausFinden_Funktion(ref Array1, ref Array2);

            int[] Ergebnis_Array = new int[Array2.Length];

            for (int i = Array2.Length - 1; i > - 1; i--)
            {
                Ergebnis_Array[i] = Array1[i] + Array2[i];


                if (Ergebnis_Array[0] > 9)
                {
                    Ergebnis_Array[0] = Ergebnis_Array[0] - 10;
                    Ergebnis_Array = prepend.Funktion(Ergebnis_Array, 1);   
                }
            }
            return Ergebnis_Array;
        }
        private void LängeRausFinden_Funktion(ref int[] ErstesArray, ref int[] ZweitesArray)
        {
            if (ErstesArray.Length > ZweitesArray.Length)
            {
                var Differenz = ErstesArray.Length - ZweitesArray.Length;
                for (int i = 0; i < Differenz; i++)
                {
                    ZweitesArray = prepend.Funktion(ZweitesArray, 0);
                }
            }
            else
            {
                var Differenz1 = ZweitesArray.Length - ErstesArray.Length;
                for (int i = 0; i < Differenz1; i++)
                {
                    ErstesArray = prepend.Funktion(ErstesArray, 0);
                }
            }
        }


    }


}
