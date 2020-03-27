using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class PrimzahlenFinden
    {
        public int[] Execute(int[] zahlen)
        {

            int count = 0;
            for (int i = 0; i < zahlen.Length; i++)
            {
                bool istPrim = true;
                if (zahlen[i] == 1)
                {
                    istPrim = false;
                }
                for (int j = 2; j < zahlen[i]; j++)
                {

                    if (zahlen[i] % j == 0)
                    {
                        istPrim = false;
                    }
                }


                if (istPrim == true)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                bool istPrim = true;
                if (zahlen[i] == 1)
                {
                    istPrim = false;
                }
                for (int j = 2; j < zahlen[i]; j++)
                {

                    if (zahlen[i] % j == 0)
                    {
                        istPrim = false;
                    }
                }


                if (istPrim == true)
                {
                    result[index] = zahlen[i];
                    index++;
                }
            }

            return result;



        }


    }
}
