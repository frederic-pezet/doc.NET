using System;

namespace exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etes-vous un homme ou une femme ?");
            string gender = Console.ReadLine();
            Console.WriteLine("Quel age avez-vous ?");
            int age = int.Parse(Console.ReadLine());

            if (gender == "homme")
            {
                if (age > 18)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur");
                }
                else
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur");
                }
            }
            else
            {
                if (age > 18)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure");
                }
            }
            Console.ReadKey();
        }
        }
    }

