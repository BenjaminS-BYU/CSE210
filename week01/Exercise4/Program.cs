using System;
using System.Linq.Expressions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter numbers one at a time, type 0 to finish.");
        int newNum = -1;
        while (newNum != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out newNum))
            {
                Console.WriteLine("Invalid input, try again.");
                return;
            }

            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        }

        int sumOfNums = 0;
        int largest = 0;
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sumOfNums += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        double avgOfNums = numbers.Average();
        Console.WriteLine($"The sum is: {sumOfNums}");
        Console.WriteLine($"The average is: {avgOfNums}");
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
