using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<PromptWriter> prompts = ReadFromFile();
        foreach (PromptWriter p in prompts)
        {
            Console.WriteLine(p);
        }
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


    public static List<PromptWriter> ReadFromFile()
    {
        List<PromptWriter> prompts = new List<PromptWriter>();
        string filename = "journal_prompts.csv";

        return prompts;
    }
}