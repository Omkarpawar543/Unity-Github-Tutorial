using System;

namespace Avgof3numbers
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number between 1 and 5:");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1: 
                Console.WriteLine("One");
                break;

                case 2: 
                Console.WriteLine("Two");
                break;
                
                case 3: 
                Console.WriteLine("Three");
                break;

                case 4: 
                Console.WriteLine("Four");
                break;

                case 5: 
                Console.WriteLine("Five");
                break;
                
                default: 
                Console.WriteLine("Default");
                break;
                
            }
            
            Console.ReadKey();
        }
    }
}