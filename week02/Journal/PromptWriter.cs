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
        "What are you grateful for?"
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
