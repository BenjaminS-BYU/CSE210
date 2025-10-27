using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        string userInput;

        do
        {
            int number = randomGenerator.Next(1, 100);
            int guessI = -1;

            Console.WriteLine("Try and guess the number between 1-100.");
            int count = 0;

            while (guessI != number)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                count += 1;

                if (!int.TryParse(guess, out guessI))
                {
                    Console.WriteLine("Please enter a valid positive whole number.");
                    continue;
                }

                if (guessI > number)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessI < number)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("Equal, you win!");
                    Console.WriteLine($"It took you {count} guess(es)");
                }
            }
            Console.Write("Would you like to play again? (y/n): ");
            userInput = Console.ReadLine().ToLower();
        } while (userInput == "y");

        Console.WriteLine("Thanks for playing!");
    }
} 