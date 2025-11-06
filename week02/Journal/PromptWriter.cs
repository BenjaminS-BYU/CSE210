using System;
using System.Collections.Generic;

class PromptWriter
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What challenge did you face?",
        "What did you learn?",
        "Who did you help today?",
        "What are you grateful for?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "When did I feel the most peace today and why?",
        "Who did I help today and how did it affect me?",
        "What moment today tested my patience or faith?",
        "What am I most grateful for right now?",
        "Where did I see beauty or goodness around me today?",
        "What decision today brought me closer to my goals or values?",
        "How did I show love or kindness today?",
        "What do I want to remember about today a year from now?",
        "What did I pray for, and how was that prayer answered—or still waiting?"
    };

    private Random _rand = new Random();

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            return "No prompts available.";
        }
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
