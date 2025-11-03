using System;
using System.Collections.Generic;

class PromptWriter
{
    public List<string> _prompts = new List<string>();
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