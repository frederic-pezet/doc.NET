using System;

namespace exerciceboucles5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            int w = 0;
            while (w < week.Length)
            {
                Console.WriteLine($"{week[w]}");
                w++;
            }
        }
    }
}
