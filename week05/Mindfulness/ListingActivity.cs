public class ListingActivity : Activity
{

    private List<string> _prompts = new List<string>()
    {
        "List as many things as you can that you are grateful for.",
        "List as many personal strengths as you can.",
        "List as many places you would like to visit.",
        "List as many achievements you are proud of."
    };
    private int _count;
    public ListingActivity()
    {
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("You may begin listing your items. Press Enter after each item. Type 'done' when you finish.");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "done")
            {
                break;
            }
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
        
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        string input;
        do
        {
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                userList.Add(input);
            }
        } while (!string.IsNullOrEmpty(input));
        return userList;
    }

}