using System;

namespace Avgof3numbers
{
    class Program1
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("18+4-1=");
            a = Convert.ToInt32(Console.ReadLine());

            if(a == 21) 
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                System.Environment.Exit(0); 
            }
            
            Console.WriteLine("15*5=");
            b = Convert.ToInt32(Console.ReadLine());

            if(b == 75) 
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine("18/2 + 12=");
            c = Convert.ToInt32(Console.ReadLine());

            if(c == 21) 
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                Console.WriteLine("Wrong!");
            }
            Console.ReadKey();
        }
    }
}