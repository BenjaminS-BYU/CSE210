// This is system import so we don't have to write System.Console every time
using System; 

class Program
{
    // Static means we don't have to create an instance of Program to run Main
    // Void means this method does not return any value
    // Main is the entry point of a C# application and the function name
    // string[] args is an array of strings that can hold command-line arguments
    // When the program starts, the Main method is called automatically
    // C# programs aren't run without a Main method and aren't run without being compiled first
    // Unlike Python, C# is a compiled language that needs to be transformed into machine code before it can be executed
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!!!");

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your color is {color}.");

        int x = 5;
        int y = 2;
        int z = 5;

        if (x > y || x == z)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("Equal");
        }
    }
}