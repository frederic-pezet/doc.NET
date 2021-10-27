using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrez votre poids");
            double poids = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrez votre taille");
            double tailles = double.Parse(Console.ReadLine());
            double imc = poids / Math.Pow(tailles, 2);
            Console.WriteLine($"L'imc est de {imc}");

            if (imc < 16.5)
            {
                Console.WriteLine("Dénutrition");
            }

            else if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("Maigreur");
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Corpulence normale");
            }

            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Surpoids");
            }

            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obésité modérée");
            }

            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obésité sévère");
            }

            else if (imc >= 40)
            {
                Console.WriteLine ("Obésité sévère");
            }
            
               
           
        }
    }
}
