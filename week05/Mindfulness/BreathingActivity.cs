public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Focus on your breathing...");
        int halfDuration = GetDuration() / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }

}