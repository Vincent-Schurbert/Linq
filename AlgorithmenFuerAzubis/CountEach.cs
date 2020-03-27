using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class CountEach
    {
        private insertat insertat = new insertat();
        public int[] CountEach_Funktion(int[] Array1) //Parameter für UnitTests
        {
            var zählen = 1;
            var hilfsvar = 0;
            bool vorhanden = false;
            int[] Ergebnis_Array = new int[0];
            var hochzählen = 0;
            
            for (int j = 0; j < Array1.Length; j++)
            {
                for (int i = 0; i < Ergebnis_Array.Length; i++)
                {
                    if (Array1[j] != Ergebnis_Array[i])
                    {
                        vorhanden = false;
                    }
                    else 
                    {
                        vorhanden = true;
                        break;
                    }
                }
                
                if (vorhanden == false)
                {
                    Ergebnis_Array = insertat.InsertAt_Funktion(Ergebnis_Array, Array1[j], hochzählen++);

                }
                
            }

            for (int a = 0; a < hochzählen; a++)
            {
                hilfsvar = 0;

                for (int k = 0; k < Array1.Length; k++)
                {
                    if (Array1[k] == Ergebnis_Array[zählen - 1])
                    {
                        hilfsvar++;
                    }
                }
                Ergebnis_Array = insertat.InsertAt_Funktion(Ergebnis_Array, hilfsvar, zählen);
                zählen = zählen + 2;

            }
            return Ergebnis_Array;
        }
    }
}