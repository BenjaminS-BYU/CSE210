public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Mindfulness Activity";
        _description = "This activity will help you relax and focus.";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char c in new char[] { '|', '/', '-', '\\' })
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(250);
                Console.Write('\b');
            }
        }
        
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}