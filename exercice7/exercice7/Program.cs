using System;

namespace exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            double cote1 = double.Parse(Console.ReadLine());
            double cote2 = double.Parse(Console.ReadLine());

            double hypotenuse = Math.Sqrt((cote1 * cote1) + (cote2 * cote2));

            Console.WriteLine("La valeur de l'hypoténuse de ce triangle est =" + hypotenuse);
        }
    }
}
