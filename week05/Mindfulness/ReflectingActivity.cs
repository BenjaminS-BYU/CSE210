public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "--- Think of a time when you overcame a significant challenge. ---",
        "--- Reflect on a moment when you felt truly at peace. ---",
        "--- Consider a situation where you helped someone in need. ---",
        "--- Recall an experience that made you feel proud of yourself. ---",
        "--- Think about a time when you learned something new about yourself. ---"
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply the lessons from this experience in the future?",
        "What positive emotions did you feel during this experience?",
        "How did this experience change your perspective?"
    };

    public ReflectingActivity()
    {
        
    }

    public void Run()
    {
        int duration = DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Take a moment to reflect on the prompt above.");
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
        int elapsed = 0;
        
        foreach (string question in _questions)
        {
            DisplayQuestion();
            ShowSpinner(10);
            elapsed += 10;
            if (elapsed >= duration)
            {
                break;
            }
        }
        Statistics.RecordActivity("Reflecting Activity", duration);
        DisplayEndingMessage();
        
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        
    }

    public void GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
        
    }

    public void DisplayPrompt()
    {
        GetRandomPrompt();
    }

    public void DisplayQuestion()
    {
        GetRandomQuestion();
    }
}