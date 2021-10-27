using System;

namespace tp2
{
    class Program
    {
        static void Main(string[] args)
        {
             Random test = new Random();
             int number = test.Next(1,51);
            Console.WriteLine($"le nombre aléatoire est {number}");
            Console.WriteLine($"Entrez un chiffre entre 1 et 50");
            int number2 = int.Parse(Console.ReadLine());

            while (number != number2) { 
            if (number < number2) 
            {
                Console.WriteLine("Le nombre à deviner est plus petit");
              number2 = int.Parse(Console.ReadLine());
            }
            else if (number > number2)
            {
                Console.WriteLine("Le nombre à deviner est plus grand");
             number2 = int.Parse (Console.ReadLine());
            }

        }
            Console.WriteLine($"Bravo, vous avez trouvé");
    }
    }
}
