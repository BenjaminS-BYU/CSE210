using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqrNum = SquareNumber(num);
        DisplayResult(name, num, sqrNum);


    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        int number = 0;
        Console.Write("Please enter a number: ");
        string numStr = Console.ReadLine();
        if (!int.TryParse(numStr, out number))
        {
            Console.WriteLine("Invalid number.");
            return 0;
        }
        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int num, int sqrNum)
    {
        Console.WriteLine($"{name}, the square of {num} is {sqrNum}");
    }
}