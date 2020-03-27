using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class normalize
    {
        public int[] normalize_Funktion(int[] random_Array, int schwellwert) //Parameter für UnitTests
        {
            int[] ergebnis = new int[random_Array.Length]; //Neues Array gleicher Länge

            int Rest;
            int Zahl;
            int ergebnis_Zahl;

            for (int i = 0; i < random_Array.Length; i++) //Geht durch die Schleife komplett
            {
                ergebnis[i] = random_Array[i]; //Werte werden übergeben

                if(random_Array[i] > schwellwert) //Wenn Wert größer als Schwellwert ist
                {
                    Rest = random_Array[i] - schwellwert;
                    Zahl = Rest / 2;
                    ergebnis_Zahl = schwellwert + Zahl;
                    ergebnis[i] = ergebnis_Zahl;
                    
                }

            }
            return ergebnis;
        }
    }
}
