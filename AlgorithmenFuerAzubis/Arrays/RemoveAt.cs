using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class RemoveAt
    {
        public int[] RemoveAt_Funktion(int[] RemoveAt_Array, int Remove_Index) //Parameter für UnitTests
        {
            int[] Remove_Ergebnis = new int[RemoveAt_Array.Length - 1]; //Index von RemoveAt_Array um 1 verringert + speichert alles

            for (int i = 0; i < Remove_Index; i++) //Geht durch die Schleife bis Remove_Index
            {
                Remove_Ergebnis[i] = RemoveAt_Array[i]; //Werte werden übergeben
            }

            for (int i = Remove_Index; i < Remove_Ergebnis.Length; i++) //Geht ab Index los, aber lässt den nächsten aus
            {
                Remove_Ergebnis[i] = RemoveAt_Array[i + 1]; //Werte werden übergeben, bei RemoveAt_Array wird 1 übersprungen
            }

            return Remove_Ergebnis; //Remove_Ergebnis wird ausgegeben


        }
        
    }
}
