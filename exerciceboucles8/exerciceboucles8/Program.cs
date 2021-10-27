using System;

namespace exerciceboucles8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int b = 1;
            while(b < 20)
            {
                Console.WriteLine($"{pairs[b]}");
                b+=2;
            }
           
        }
    }
}
