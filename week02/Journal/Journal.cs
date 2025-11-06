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

    public void AddEntry(Entry newEntry)
    {
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
            if (parts.Length == 3)
            {
                Entry e = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(e);
            }
        }
        Console.WriteLine($"\nJournal loaded from {file}");
    }
}