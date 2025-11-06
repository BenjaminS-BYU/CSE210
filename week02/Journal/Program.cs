using System;

// Added mood, and some formatting. 
// Also a safety for if the user types in a string instead of an int.
// Added a save feature after the user tries to leave the program to make sure they save their work.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int usersChoice = 0;

        while (usersChoice != 5)
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

            string choice = Console.ReadLine();
            if (!int.TryParse(choice, out usersChoice))
            {
                Console.WriteLine("\nThat input isn't supported, try again.\n");
                continue;
            }

            switch (usersChoice)
            {
                case 1:
                    journal.AddEntry();
                    break;

                case 2:
                    journal.DisplayAllEntries();
                    break;

                case 3:
                    Console.WriteLine("What file would you like to load from? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case 4:
                    Console.WriteLine("What file would you like to save to? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case 5:
                    Console.Write("Would you like to save your file? (y/n): ");
                    string saveQuestion = Console.ReadLine();
                    if (saveQuestion == "y")
                    {
                        Console.WriteLine("What file would you like to save to? ");
                        saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                    }
                    Console.WriteLine("\nGoodbye.");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.\n");
                    break;
            }
        }
    }
}
