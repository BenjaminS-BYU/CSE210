// Added a way to put in your own scripture 
// Also shows you how many words are left to memorizes


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");

        // Get scripture reference
        Console.Write("Book: ");
        string book = Console.ReadLine();

        Console.Write("Chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Verse: ");
        int verse = int.Parse(Console.ReadLine());

        Console.Write("End verse (press Enter if none): ");
        string endInput = Console.ReadLine();
        int endVerse = string.IsNullOrEmpty(endInput) ? verse : int.Parse(endInput); // Thanks ChatGPT

        // Get scripture text
        Console.Write("Scripture text: ");
        string text = Console.ReadLine();

        // Create objects
        Reference reference = new(book, chapter, verse, endVerse);
        Scripture scripture = new(reference, text);

        Random rng = new();
        int totalWordsHidden = 0;
        int totalWords = scripture.TotalWords();

        // Main loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nWords hidden: {totalWordsHidden}/{totalWords}");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Great job memorizing!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            int toHide = rng.Next(1, 5); // Hide 1–4 words
            int actuallyHidden = scripture.HideRandomWords(toHide);
            totalWordsHidden += actuallyHidden;
        }

        Console.WriteLine("\nThank you for using the Scripture Memorizer!");
    }
}
