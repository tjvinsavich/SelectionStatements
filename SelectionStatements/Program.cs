using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Nevermind."); 
            }
        }
    }
}
