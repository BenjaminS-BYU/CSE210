public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you overcame a significant challenge.",
        "Reflect on a moment when you felt truly at peace.",
        "Consider a situation where you helped someone in need.",
        "Recall an experience that made you feel proud of yourself."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How can you apply the lessons from this experience in the future?",
        "What emotions did you feel during this experience?"
    };

    public ReflectingActivity()
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Take a moment to reflect on the prompt above.");
        ShowSpinner(5);
        foreach (string question in _questions)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }
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