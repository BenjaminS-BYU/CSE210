using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What are your grades? ");
        string userInput = Console.ReadLine();

        int grades = int.Parse(userInput);

        if (grades >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (grades < 90 && grades >= 80)
        {
            Console.WriteLine("You have an B");
        }
        else if (grades < 80 && grades >= 70)
        {
            Console.WriteLine("You have an C");
        }
        else if (grades < 70 && grades >= 60)
        {
            Console.WriteLine("You have an D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }
        if (grades > 70)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}