using System;

namespace HelloWorld
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.Title = "Omkar";
            
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*In Outscale's Game Jam*");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello my name is Jack! and you are...?");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Nice to meet you buddy");
            Console.WriteLine("Which game are you making for this Game Jam!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("I will go with some 2d combat types mostly!");
            Console.WriteLine("BTW.. All the best will meet you at the end of the Jam!!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bye!!");          
        }
    }
}