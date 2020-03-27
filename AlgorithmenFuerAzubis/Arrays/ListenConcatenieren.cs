using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Arrays
{
    public class ListenConcatenieren
    {
        public int[] Concatenate(int[] erstesArray, int[] zweitesArray)
        {
            // Vorbereiten der Funktion 
            var LängedesIndex = erstesArray.Length + zweitesArray.Length;
            var ersteAnnaeherung = erstesArray.Length;
            var ergebnis = new int[LängedesIndex];
            // erster Array in die neue Liste schreiben


            for (int i = 0; i < erstesArray.Length; i++)
            {
                ergebnis[i] = erstesArray[i];
            }
            // zweiten Array dazufügen 
            for (int i = 0; i < zweitesArray.Length; i++)
            {
                ergebnis[ersteAnnaeherung + i] = zweitesArray[i];
            }
            return ergebnis;
        }
    }
}
