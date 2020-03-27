using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class Remove
    {
        public int[] Remove_Funktion(int[] Remove_Array, int Zahl) //Parameter für UnitTests
        {
            int Anzahl = 0;
            for (int i = 0; i < Remove_Array.Length; i++) //Geht durch die Schleife
            {
                if(Remove_Array[i] == Zahl) //Wenn Index eine Zahl
                {
                    Anzahl++;
                }
            }

            int[] Remove_Ergebnis = new int[Remove_Array.Length - Anzahl]; //Ergebnis = Array Länge - Anzahl Zahl

            int j = 0; //Neuer Index

            for (int i = 0; i < Remove_Array.Length; i++) //Geht durch die Schleife
            {
                

                if(Remove_Array[i] != Zahl) //Wenn Index keine Zahl
                {
                    Remove_Ergebnis[j] = Remove_Array[i]; //Überschreibt von Array zu Ergebnis
                    j++; //Neuer Index steigt jedes Mal

                }
                
            }
            return Remove_Ergebnis;


        }
    }
}
