using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class GetHead
    {
        public int? Execute(int[] zahlen)
        {
            // erster Eintrag der Liste
            if (zahlen.Length == 0 || zahlen == null)
                return null;

            return zahlen[0];
        }
    }
}
