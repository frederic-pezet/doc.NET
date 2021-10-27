using System;

namespace exerciceboucles6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre" };
           foreach (string elements in months)
            {
                Console.WriteLine($"{elements}");
            }
        }
    }
}
