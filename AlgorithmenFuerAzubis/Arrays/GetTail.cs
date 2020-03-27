using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class GetTail
    {
        public int[] Execute(int[] zahlen)
        {
            // neues array, aber um 1 kürzer
            var result = new int[zahlen.Length - 1];

            // alles kopieren, außer das erste Element
            for (int i = 1; i < zahlen.Length; i++)
                result[i - 1] = zahlen[i];

            return result;
        }
    }
}
