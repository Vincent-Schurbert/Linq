using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class ToDecimal
    {
        public double ToDecimal_Funktion(int[] Array)
        {
            double Ergebnis = 0;
            double ZwischenErgebnis = 0;
            int Exponent = 0;
            

            for (int i = Array.Length - 1; i > - 1; i--)
            {
                ZwischenErgebnis = Array[i] * (Math.Pow(2, Exponent));
                if (Array[i] != 0)
                {
                    Ergebnis = Ergebnis + ZwischenErgebnis;
                }
                Exponent++; 
            }
              return Ergebnis;

             
        }
    }


   
}
