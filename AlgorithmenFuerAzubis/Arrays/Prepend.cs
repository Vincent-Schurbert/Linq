using System;
using System.Collections.Generic;
using System.Text;
//Parameter für Test
//Result array mit +1 index
//durchläuft die Schleife und wird alles übergeben aber beginnt bei index 1
//Ergebnis[0] = Prepend_Zahl;

namespace AlgorithmenFuerAzubis
{
    public class Prepend
    {
        public int[] Funktion(int[] Prepend_Array, int Prepend_Zahl) //Parameter für UnitTests
        {
            int[] Ergebnis = new int[Prepend_Array.Length + 1]; //Index von Prepend_Array um 1 erhöht + speichert alles in Ergebnis

            for (int i = 1; i < Ergebnis.Length; i++) //Durchläuft die Schleife (Von Index zu Index)
            {
                Ergebnis[i] = Prepend_Array[i - 1]; //Werte werden übergeben, aber bei Prepend_Array muss bei Index 0 anfangen
            }
            Ergebnis[0] = Prepend_Zahl; //An Index 0 kommt die Zahl

            return Ergebnis;//Das Ergebnis-Array wird ausgegeben
        }
        
    }
}
