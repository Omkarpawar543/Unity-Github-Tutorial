using System;



namespace MyAwesomeMathQuiz

{

    class Program

    {

        static void Main(string[] args)

        {

            Random numberGen = new Random();



            int roll1 = 0;

            int roll2 = 1;

            int attempts = 0;



            Console.WriteLine("Press any key to roll both dices.");



            while(roll1 != roll2) {

                Console.ReadKey();



                roll1 = numberGen.Next(1, 7);

                roll2 = numberGen.Next(1, 7);

                Console.WriteLine("You rolled : " + roll1 + " and " + roll2);

                attempts++;

            }



            Console.WriteLine("It took u " + attempts + (" attempts to roll same numbers!"));



           Console.ReadKey();

        }

    }

}