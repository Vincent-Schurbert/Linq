using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class Sort
    {
        public int[] Sort_Funktion(int[] Sort_Array) //Parameter für UnitTests
        {

            int Zahl; //Hilfszahl

            
            for (int i = 0; i < Sort_Array.Length - 1; i++) //Geht durch die Schleife komplett
            {
                 
                for (int j = i + 1; j < Sort_Array.Length; j++) //Geht durch die Schleife komplett, fängt aber bei i + 1 an
                {
                     
                    if (Sort_Array[i] < Sort_Array[j]) //Wenn Wert in Index i kleiner als Wert in Index j
                    {

                        //i und j werden getauscht
                        Zahl = Sort_Array[i]; //Hilfszahl = i
                        Sort_Array[i] = Sort_Array[j]; //i = j
                        Sort_Array[j] = Zahl; //j = Hilfszahl

                        //Zahl i wird immer mit den anderen Zahlen verglichen + verschoben
                    }
                    
                }
 
            }
            return Sort_Array;
        }
    }       // 1, 9, 6, 7, 5, 9
}
