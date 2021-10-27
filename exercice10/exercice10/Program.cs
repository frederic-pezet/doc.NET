using System;

namespace exercice10
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            int age2 = age;
            int Aage = int.Parse(Console.ReadLine());
            while (age > 18)
            {
                Console.WriteLine("Quelle est votre âge ?");
                Aage += int.Parse(Console.ReadLine());
            }
            if (age >= 18)
            {
             
            }
            Console.WriteLine($"Vous avez{Aage},Vous êtes majeur");
        }
    }
}
