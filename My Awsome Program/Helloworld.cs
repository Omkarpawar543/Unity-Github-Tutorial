using System;

namespace Avgof3numbers
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Write("How many cool numbers you want:");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2,i);
                Console.WriteLine(result);
            }
            
            Console.ReadKey();
        }
    }
}