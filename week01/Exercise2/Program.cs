using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What are your grades? ");
        string userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out int grades))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        string letter;

        if (grades >= 90)
        {
            letter = "A";
        }
        else if (grades >= 80)
        {
            letter = "B";
        }
        else if (grades >= 70)
        {
            letter = "C";
        }
        else if (grades >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = grades % 10;
        string sign = "";

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"You have {letter}{sign} letter grade.");

        if (grades >= 60)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("You failed");
        }
    }
}