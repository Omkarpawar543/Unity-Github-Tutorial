using System;

namespace Avgof3numbers
{
    class Program1
    {
        static void Main(string[] args)
        {
            double numx;
            double numy;
            double numz;

            Console.Write("Input a number: ");
            numx = Convert.ToDouble(Console.ReadLine() );

            Console.Write("Input a second number: ");
            numy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a third number: ");
            numz = Convert.ToDouble(Console.ReadLine());

            double Result = (numx + numy + numz)/3;
            Console.WriteLine("The Result is " + Result);

            Console.ReadKey();

        }
    }
}