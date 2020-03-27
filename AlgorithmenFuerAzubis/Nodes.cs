using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class Nodes<T>
    {
        
        public T value;
        public Nodes(Nodes<T> prev, T value, Nodes<T> next) //Konstruktor
        {
            Prev = prev;
            this.value = value;
            Next = next;
        }
        public Nodes<T> Next
        {
            get; set;
        }

        public Nodes<T> Prev
        {
            get; set;
        }


    }
}

