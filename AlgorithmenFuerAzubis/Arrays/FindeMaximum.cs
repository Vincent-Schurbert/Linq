using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class FindeMaximum
    {
        public int Execute(int[] zahlen)
        {
            if (zahlen.Length == 0 || zahlen == null)
                throw new ArgumentException("Das Maximum in einem leeren Array? Denk mal mit!");

            var maximum = zahlen[0];

            for (int i = 1; i < zahlen.Length; i++)
            {
                if (zahlen[i] > maximum)
                    maximum = zahlen[i];
            }

            return maximum;
        }
    }
}
