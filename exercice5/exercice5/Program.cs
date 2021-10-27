using System;

namespace exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
         string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            Console.WriteLine($"Bonjour{a}{b},nous sommes{date},comment allez-vous ?",a,b,date);
        }
    }
}
