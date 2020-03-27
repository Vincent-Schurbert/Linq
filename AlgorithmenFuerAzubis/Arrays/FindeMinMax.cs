using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class FindeMinMax
    {
        public (int, int) Execute(int[] Zahlen)
        {
            // var min = -1;
            // var max = +1;

            // todo

            var Minimum = Zahlen[0];
            var Maximum = Zahlen[0];

            for (int i = 1; i < Zahlen.Length; i++)
            {
                if (Minimum > Zahlen[i])
                    Minimum = Zahlen[i];

                if (Maximum < Zahlen[i])
                    Maximum = Zahlen[i];

            }

            return (Minimum, Maximum);


        }
    
    }
}
