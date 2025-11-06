using System;

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
                    WriteEntry(journal);
                    break;

                case 2:
                    journal.DisplayAllEntries();
                    break;

                case 3:
                    string loadFile = "save.txt";
                    journal.LoadFromFile(loadFile);
                    break;

                case 4:
                    string saveFile = "save.txt";
                    journal.SaveToFile(saveFile);
                    break;

                case 5:
                    Console.WriteLine("\nGoodbye.");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.\n");
                    break;
            }
        }
    }

    static void WriteEntry(Journal journal)
    {
        PromptWriter pw = new PromptWriter();
        string prompt = pw.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("Response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(prompt, response, date);
        journal.AddEntry(newEntry);
    }
}
