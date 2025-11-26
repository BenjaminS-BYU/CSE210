public class ListingActivity : Activity
{
    private readonly List<string> _prompts = new List<string>()
    {
        "List as many things as you can that you are grateful for.",
        "List as many personal strengths as you can.",
        "List as many places you would like to visit.",
        "List as many achievements you are proud of."
    };

    public ListingActivity()
    {        
    }

    public void Run()
    {
        int count = 0;

        int duration = DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin listing your items. Press Enter after each item. Type 'done' to finish early.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            TimeSpan timeLeftSpan = endTime - DateTime.Now;
            int timeLeft = (int)timeLeftSpan.TotalSeconds;
            Console.Write($"{timeLeft} seconds left. > ");
            string input = Console.ReadLine();

            if (input == null)
                continue;

            if (input.Trim().ToLower() == "done")
                break;

            if (input.Trim() != "")
                count++;
        }
        Statistics.RecordActivity("Listing Activity", duration);

        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
