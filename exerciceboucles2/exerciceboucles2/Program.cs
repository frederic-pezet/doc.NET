using System;

namespace exerciceboucles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine($"Bonjour, je suis le message n°{a}");
                ++a;
            }
        }
    }
}
