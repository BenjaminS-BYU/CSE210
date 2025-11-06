using System;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry(string prompt, string response, string date, string mood)
    {
        _promptText = prompt;
        _entryText = response;
        _date = date;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine("------------------------------");
    }
}
