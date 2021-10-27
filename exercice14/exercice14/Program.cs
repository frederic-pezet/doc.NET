using System;

namespace exercice14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel mois somme nous ?");
            string month = Console.ReadLine();

            if (month == "janvier" || month == " fevrier" || month == "decembre" || month == "01" || month == "02" || month == "12")
            {
                Console.WriteLine("hiver");
            }
            else if (month == "mars" || month == "03" || month == "avril" || month == "04" || month == "mai" || month == "05")
            {
                Console.WriteLine("printemps");
            }
            else if (month == "juin" || month == "06" || month == "juillet" || month == "07" || month == "aout" || month == "08")
            {
                Console.WriteLine("été");
            }
            else if (month == "septembre" || month == "09" || month == "octobre" || month == "10" || month == "novembre" || month == "11")
            {
                Console.WriteLine("automne");
            }
            else
            {
                Console.WriteLine("nous n'avons pas compris votre demande");
            }
            Console.ReadKey();

        }
    }
}
