using System;

namespace exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saississez la valeur du rayon");

            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimetre = (pi * r * 2);
            double surface = (pi * r * r);

            Console.WriteLine("Valeur du périmetre du cercle est" + perimetre);
            Console.WriteLine("Valeur du périmetre du cercle est" + surface);
        }
    }
}
