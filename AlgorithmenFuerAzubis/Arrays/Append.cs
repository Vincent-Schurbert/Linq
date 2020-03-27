using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class Append
    {
        public int[] Execute(int[] Array, int Zahl) //Parameter für UnitTest
        {

            int[] Result = new int[Array.Length + 1]; //index von Array um 1 erhöht + speichert alles in Result

            for (int i = 0; i < Array.Length; i++) //Durchläuft die Schleife und macht das in Klammern
            {
                Result[i] = Array[i]; //Überschreibt die Werte am gleichen Index (Array nach Result)

            }
            Result[Result.Length - 1] = Zahl; /*an letzte Stelle die Zahl,
                                              Länge fängt bei 1 an zu zählen (Bei 9 Zahlen = 10)
                                              Index bei 0 an (Bei 9 Zahlen = 9)*/

            return Result; //Das Result-Array wird ausgegeben
        }
    }
}
