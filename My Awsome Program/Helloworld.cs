using System;

namespace Avgof3numbers
{
    class Program1
    {
        static void Main(string[] args)
        {
            int age;
            int height;

            Console.WriteLine("Please input the age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input height in (cms): ");
            height = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 && height >= 160) {
                Console.WriteLine("Now you can enter!");
            }else {
                Console.WriteLine("You don't meet requirements.");
            }
            
            Console.ReadKey();
        }
    }
}