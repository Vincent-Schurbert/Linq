using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis
{
    public class Programm
    {

        public void MalZwei(int Zahl)
        {
            Console.WriteLine(Zahl * 2);
        }

        public void ZweiTypenVergleichen(object Objekt1, object Objekt2)
        {

        }

        public bool GrößerAls0(int Zahl)
        {
            if (Zahl > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            List<int> Liste = new List<int>();

            Liste.Add(0);
            Liste.Add(1);
            Liste.Add(2);
            Liste.Add(3);

            List<object> ListenObject = new List<object>();
            ListenObject.Add("Andy");
            ListenObject.Add(2);
            ListenObject.Add(0.3);

            //Liste.Clear();
            //Liste.Display();

            Programm p = new Programm();

            Predicate<int> predicate;
            predicate = p.GrößerAls0;

            Action<int> action;
            action = p.MalZwei;

            Comparison<object> comparison;
            //comparison = p.ZweiTypenVergleichen;

            List<int> Liste2 = new List<int>();
            Liste2.Add(4);
            Liste2.Add(5);
            Liste2.Add(6);

            //Liste.AddRange(Liste2);
            //Liste.Display();

            //Console.WriteLine(Liste.Find(predicate));

            //Console.WriteLine(Liste.FindLast(predicate)); 

            //Console.WriteLine(Liste.FindIndex(predicate));

            //Console.WriteLine(Liste.FindLastIndex(predicate));

            //Liste.FindAll(predicate); 

            //Console.WriteLine(Liste.Contains(2));

            //Liste.Remove(0);
            //Liste.Display();

            //Liste.RemoveAt(0); 
            //Liste.Display();

            //Liste.RemoveAll(predicate); 
            //Liste.Display();

            //Console.WriteLine(Liste.IndexOf(2));

            //Console.WriteLine(Liste.LastIndexOf(3));

            //Liste.Insert(2, 9); 
            //Liste.Display();

            //Console.WriteLine(Liste.ToArray());

            //Console.WriteLine(Liste.Exists(predicate));

            //Liste.ForEach(action);

            //Liste.Reverse();
            //Liste.Display();










        }
    }
}
