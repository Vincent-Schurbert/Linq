using System;
using System.Collections.Generic;
using System.Text;
//Parameter für Test (altesArray, Zahl, Index)

namespace AlgorithmenFuerAzubis.Arrays
{
    public class insertat
    {
        public int[] InsertAt_Funktion(int[] InsertAt_Array, int InsertAt_Zahl, int Index) //Parameter für UnitTests
        {
            int[] Ergebnis = new int[InsertAt_Array.Length + 1]; //Index von InsertAt_Array um 1 erhöht + speichert alles in Ergebnis

            for (int i = 0; i < Index; i++)//Geht durch die Schleife bis Index und fügt dann die Zahl ein
            {
                Ergebnis[i] = InsertAt_Array[i];
            }
            Ergebnis[Index] = InsertAt_Zahl;//Zahl wird an Position Index hinzugefügt

            for (int i = Index; i < Ergebnis.Length - 1; i++)//Geht durch die Schleife, geht aber ab Index los, Länge muss um 1 verringert werden
            {
                 Ergebnis[i + 1] = InsertAt_Array[i];//Ergebnis-Array wird um 1 verschoben
            }

            return Ergebnis;//Ergebnis wird ausgegeben
        }

    }
    
}
