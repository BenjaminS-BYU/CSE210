public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        
    }

    public void Run()
{
    int duration = DisplayStartingMessage();
    Console.WriteLine("Focus on your breathing...");

    int elapsed = 0;

    while (elapsed < duration)
    {
        Console.WriteLine();
        Console.Write("Breathe in... ");
        ShowCountdown(5);
        Console.Beep(523, 400);
        Console.WriteLine();
        elapsed += 5;
        if (elapsed >= duration)
        {
            break;
        }
        Console.Write("Breathe out... ");
        ShowCountdown(5);
        Console.Beep(261, 500);
        Console.WriteLine();
        elapsed += 5;
    }
    Statistics.RecordActivity("Breathing Activity", duration);
    Console.Beep();
    DisplayEndingMessage();
}
}