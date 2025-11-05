using System;
using System.Runtime.CompilerServices;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string response, string date)
    {
        _promptText = prompt;
        _entryText = response;
        _date = date;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("------------------------------");
    }
}