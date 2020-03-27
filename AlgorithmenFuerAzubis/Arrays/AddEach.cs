using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class AddEach
    {
        public int[] AddEach_Funktion(int[] erstes_Array, int[] zweites_Array) //Parameter für UnitTests
        {

            int[] ergebnis_Array = new int[erstes_Array.Length]; //Länge des 1. Array
            

            for (int i = 0; i < zweites_Array.Length; i++) //Geht durch bis 2. Array
            {

               if (zweites_Array.Length > erstes_Array.Length)
               {
                    ergebnis_Array = new int[zweites_Array.Length]; //Länge des 2.Array

                    for (int j = 0; j < erstes_Array.Length; j++) //Geht durch bis Länge des kurzen Arrays
                    {
                       
                        ergebnis_Array[j] = zweites_Array[j] + erstes_Array[j]; //Überschreibt die Werte

                        if (j == erstes_Array.Length - 1) //Wenn bis Länge des kurzen Array angelangt
                        {
                            for (int a = erstes_Array.Length; a < zweites_Array.Length; a++) //Geht ab kurzes Array bis lange Array
                            {
                                ergebnis_Array[a] = zweites_Array[a]; //kopiert die restlichen Werte von langes Array
                            }
                        }
                    }
                    
                    
               }
                else
                {

                    ergebnis_Array[i] = erstes_Array[i] + zweites_Array[i]; //Überschreibt die Werte

                    if (i == zweites_Array.Length - 1) //Wenn bis Länge des kurzen Array angelangt
                    {
                        for (int b = zweites_Array.Length; b < erstes_Array.Length; b++) //Geht ab kurzes Array bis lange Array
                        {
                            ergebnis_Array[b] = erstes_Array[b]; //kopiert die restlichen Werte von langes Array
                        }
                    }
                    
                }
                
            }
            return ergebnis_Array;

        }
        
    }
}
