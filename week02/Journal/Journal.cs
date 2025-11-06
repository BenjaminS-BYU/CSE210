using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry()
    {
        PromptWriter pw = new PromptWriter();
        string prompt = pw.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.Write("Response: ");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();
        Console.Write("Mood: ");
        string mood = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response, date, mood);
        entries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry._promptText}|{entry._entryText}|{entry._date}");
            }
        }
        Console.WriteLine($"\nJournal saved to {file}");
    }
    
    public void LoadFromFile(string file)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                Entry e = new Entry(parts[0], parts[1], parts[2], parts[3]);
                entries.Add(e);
            }
        }
        Console.WriteLine($"\nJournal loaded from {file}");
    }
}