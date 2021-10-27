using System;

namespace exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string date = DateTime.Now.ToString("dddd dd MMMM yyyy");
            Console.WriteLine($"{a}{b}{date}", a, b, date);
        }
    }
}
