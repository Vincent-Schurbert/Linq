using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class ReihenfolgeUmkehren
    {
        public int[] Execute(int[] zahlen)
        {
            int[] result = new int[zahlen.Length];

            int zeiger = 0;
            for (int start = zahlen.Length - 1; start >= 0; start--)
            {
                result[zeiger] = zahlen[start];
                zeiger++;
            }
            return result;
        }
    }
}
