using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class Prime2
    {
        public int[] Execute(int[] zahlen)
        {
            int[] ergebnis = new int[AnzahlPrimzahlen(zahlen)];

            int ergebnisIndex = 0;
            for (int i = 0; i < zahlen.Length; i++)
                if (IsPrime(zahlen[i]))
                    ergebnis[ergebnisIndex++] = zahlen[i];

            return ergebnis;
        }
        bool IsPrime(int input)
        {
            if (input <= 1)
                return false;

            for (int i = 2; i < input; i++)
                if (input % i == 0)
                    return false;

            return true;
        }
        int AnzahlPrimzahlen(int[] zahlen)
        {
            int anzahlPrimezahlen = 0;

            for (int i = 0; i < zahlen.Length; i++)
                if (IsPrime(zahlen[i]))
                    anzahlPrimezahlen++;

            return anzahlPrimezahlen;
        }
    }
}
