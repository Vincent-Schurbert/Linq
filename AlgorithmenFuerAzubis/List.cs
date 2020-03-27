using System;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class List<T>
    {
        Nodes<T> First;
        Nodes<T> Last;
        int nodeCount = 0;

        public void Add(T value) //ADD
        {
            if (First == null)
            {
                var neuNode = new Nodes<T>(null, value, null);
                Last = neuNode;
                First = neuNode;
            }
            else
            {
                var neuNode = new Nodes<T>(Last, value, null);
                neuNode.Prev = Last;
                Last.Next = neuNode;
                Last = neuNode;
            }

            nodeCount++;
        }

        public void AddRange(List<T> SecondListe) //ADDRANGE
        {
            var Knoten = SecondListe.First;

            while (Knoten != null)
            {
                Add(Knoten.value);
                Knoten = Knoten.Next;
            }

        }

        public void Clear() //CLEAR
        {
            First = null;
            Last = null;
            nodeCount = 0;
        }

        public T Find(Predicate<T> predicate) //FIND
        {
            var Knoten = First;

            while (Knoten != null)
            {
                if (predicate(Knoten.value))
                {
                    return Knoten.value;
                }
                else
                {
                    Knoten = Knoten.Next;
                }
            }
            return Knoten.value;
        }
        public T FindLast(Predicate<T> predicate) //FINDLAST
        {
            var Knoten = Last;

            while (Knoten != null)
            {
                if (predicate(Knoten.value))
                {
                    return Knoten.value;
                }
                else
                {
                    Knoten = Knoten.Prev;
                }
            }
            return Knoten.value;
        }

        public int FindIndex(Predicate<T> predicate) //FINDINDEX
        {
            var Knoten = First;
            int Index = 0;

            while (Knoten != null)
            {
                if (predicate(Knoten.value))
                {
                    return Index;
                }
                else
                {
                    Knoten = Knoten.Next;
                    Index++;
                }
            }
            return Index;
        }

        public int FindLastIndex(Predicate<T> predicate) //FINDLASTINDEX
        {
            var Knoten = Last;
            int Index = nodeCount - 1;

            while (Knoten != null)
            {
                if (predicate(Knoten.value))
                {
                    return Index;
                }
                else
                {
                    Knoten = Knoten.Prev;
                    Index--;
                }
            }
            return Index;
        }

        public List<T> FindAll(Predicate<T> predicate) //FINDALL
        {
            var Knoten = First;
            List<T> NeueListe = new List<T>();

            while (Knoten != null)
            {

                if (predicate(Knoten.value))
                {
                    NeueListe.Add(Knoten.value);
                    Knoten = Knoten.Next;
                }
                else
                {
                    Knoten = Knoten.Next;
                }

            }
            NeueListe.Display();
            return NeueListe;
        }

        public bool Contains(T Vergleichswert) //CONTAINS
        {
            bool IstDa = false;
            var Knoten = First; //beginnt bei First

            while (Knoten != null)
            {
                //.Equals = vergleichen
                if (Knoten.value.Equals(Vergleichswert)) //Wenn zutrifft
                {
                    IstDa = true;
                    return IstDa;
                }
                else
                {
                    Knoten = Knoten.Next; //Geht immer weiter und ist der neue Knoten 
                }

            }
            return IstDa;
        }

        public void Remove(T Löschwert) //REMOVE 
        {
            var Knoten = First;

            while (Knoten != null)
            {
                if (Knoten.value.Equals(Löschwert) && Knoten == Last)
                {
                    Knoten.Prev.Next = null;
                    return;

                }
                else if (Knoten.value.Equals(Löschwert) && Knoten == First)
                {
                    First = Knoten.Next;
                    return;
                }
                else if (Knoten.value.Equals(Löschwert))
                {
                    Knoten.Prev.Next = Knoten.Next;
                    Knoten.Next.Prev = Knoten.Prev;
                    return;
                }
                else
                {
                    Knoten = Knoten.Next;
                }
            }

        }

        public void RemoveAt(int Index) //REMOVEAT
        {
            int Zähler = 0;
            var Knoten = First;

            while (Knoten != null)
            {
                if (Index == Zähler && Knoten == Last)
                {
                    Knoten.Prev.Next = null;
                    return;
                }
                else if (Index == Zähler && Knoten == First)
                {
                    First = Knoten.Next;
                    return;
                }
                else if (Index == Zähler)
                {
                    Knoten.Prev.Next = Knoten.Next;
                    Knoten.Next.Prev = Knoten.Prev;
                    return;
                }
                else
                {
                    Knoten = Knoten.Next;
                    Zähler++;
                }

            }

        }

        public void RemoveAll(Predicate<T> predicate) //REMOVEALL
        {
            var Knoten = First;

            while (Knoten != null)
            {
                if (predicate(Knoten.value) && Knoten == Last)
                {
                    Knoten.Prev.Next = null;
                    Knoten = Knoten.Next;
                }
                else if (predicate(Knoten.value) && Knoten == First)
                {
                    First = Knoten.Next;
                    Knoten = Knoten.Next;
                }
                else if (predicate(Knoten.value))
                {
                    Knoten.Prev.Next = Knoten.Next;
                    Knoten.Next.Prev = Knoten.Prev;
                    Knoten = Knoten.Next;
                }
                else
                {
                    Knoten = Knoten.Next;
                }


            }

        }

        public int IndexOf(T Vergleichszahl) //INDEXOF
        {
            var Knoten = First;
            int Index = 0;
            int Zähler = 0;

            while (Knoten != null)
            {
                if (Knoten.value.Equals(Vergleichszahl))
                {
                    Index = Zähler;
                    return Index;
                }
                else
                {
                    Knoten = Knoten.Next;
                    Zähler++;
                }
            }
            return Index;

        }

        public int LastIndexOf(T Zahl) //LASTINDEXOF
        {
            int Zähler = nodeCount - 1; //10
            var Knoten = Last;
            int Index = 0;

            while (Knoten != null)
            {
                if (Knoten.value.Equals(Zahl))
                {
                    Index = Zähler;
                    return Index;
                }
                else
                {
                    Knoten = Knoten.Prev;
                    Zähler--;
                }
            }
            return Index;
        }

        public void Insert(int Index, T item) //INSERT 
        {
            var Knoten = First;
            int Zähler = 0;

            while (Knoten != null && Index - 1 >= Zähler)
            {
                if (Index - 1 == Zähler)
                {
                    var NewKnoten = new Nodes<T>(Knoten, item, Knoten.Next);
                    Knoten.Prev = NewKnoten;
                    Knoten.Next = NewKnoten;
                    Zähler++;
                }

                else
                {
                    Knoten = Knoten.Next;
                    Zähler++;
                }

            }
            return;

        }

        public T[] ToArray() //TOARRAY
        {
            var Knoten = First;
            T[] ToArray = new T[nodeCount];

            while (Knoten != null)
            {
                for (int i = 0; i < nodeCount; i++)
                {
                    ToArray[i] = Knoten.value;
                    Knoten = Knoten.Next;
                }
            }
            return ToArray;
        }

        public bool Exists(Predicate<T> predicate) //EXISTS
        {
            var Knoten = First;
            bool IstDrin = false;

            while (Knoten != null)
            {
                if (predicate(Knoten.value))
                {
                    IstDrin = true;
                    return IstDrin;
                }
                else
                {
                    Knoten = Knoten.Next;
                }
            }
            return IstDrin;
        }

        public void ForEach(Action<T> action) //FOREACH (MAL ZWEI)
        {
            var Knoten = First;

            while (Knoten != null)
            {
                action(Knoten.value);
                Knoten = Knoten.Next;
            }
            return;
        }

        public void Reverse() //REVERSE
        {
            var Knoten = First;

            while (Knoten != null)
            {
                var Vorgänger = Knoten.Prev;
                var Nachfolger = Knoten.Next;

                Knoten.Next = Vorgänger;
                Knoten.Prev = Nachfolger;

                Knoten = Knoten.Prev;
            }

            var Zwischenspeicher = First;
            First = Last;
            Last = Zwischenspeicher;
        }

        public void Sort() //SORT
        {
            var Knoten = First;

            while (Knoten != null)
            {

            }
        }





        public void Display()
        {
            Nodes<T> Start = First;
            if (Start == null)
            {
                Console.WriteLine("Die Liste ist Leer!");
            }
            else
            {
                while (Start != null)
                {
                    Console.WriteLine(Start.value);
                    Start = Start.Next; //Gibt den nächsten aus, wegen Schleife

                }
            }
        }

    }
}                    



