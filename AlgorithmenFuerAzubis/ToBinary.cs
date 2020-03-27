using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class ToBinary
    {
        private Prepend prepend = new Prepend();
        public int[] ToBinary_Funktion(int DezimalZahl) //Parameter für UnitTests
        {
            int Rest;
            int[] Array = new int[] { };

            while (DezimalZahl >= 1)
            {
                Rest = DezimalZahl % 2;
                DezimalZahl = DezimalZahl / 2;

                Array = prepend.Funktion(Array, Rest);
            }
             return Array;
        }
    }
}
