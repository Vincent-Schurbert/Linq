using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class FindeMinimum
    {
        public int Execute(int[] zahlen)
        {
            if (zahlen.Length == 0 || zahlen == null)
                throw new ArgumentException("Das Minimum in einem leeren Array? Denk mal mit!");

            var minimum = zahlen[0];

            for (int i = 1; i < zahlen.Length; i++)
            {
                if (zahlen[i] < minimum)
                    minimum = zahlen[i];
            }

            return minimum;
        }
    }
}
