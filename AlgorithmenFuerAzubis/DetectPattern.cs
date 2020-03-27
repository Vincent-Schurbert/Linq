using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class DetectPattern
    {
        public int DetectPattern_Funktion(int[] ArrayMuster, int[] Array1) //Parameter für UnitTests
        {
            var Ergebnis = 0;
            var hilfsvar = 0;

            while (hilfsvar < Array1.Length)
            {
                for (int i = 0; i < Array1.Length - ArrayMuster.Length; i++)
                {
                    for (int j = 0; j < ArrayMuster.Length; j++)
                    {
                        if (Array1[i + j] == ArrayMuster[j])
                        {
                            Ergebnis = i + ArrayMuster.Length;
                            hilfsvar++;
                        }
                    }
                }
            }
            return Ergebnis;
        }
    }
}
