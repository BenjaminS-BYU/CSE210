using System;

class Program
{
    
    static void Main(string[] args)
    {

        string usersChoice = "";
        while (usersChoice != "5")
        {
            Console.Write(
@"Welcome to the Journal Program!
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ");
            usersChoice = Console.ReadLine();

            if (usersChoice == "5")
            {
                Console.WriteLine("Goodbye.");
                Environment.Exit(0);
            }
        }
    }

}