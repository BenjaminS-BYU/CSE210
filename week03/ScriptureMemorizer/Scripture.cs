using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random(); // Shared Random instance

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] splitWords = text.Split(' ');
        foreach (string w in splitWords)
        {
            _words.Add(new Word(w));
        }
    }

    // Hides a specified number of words and returns the actual number hidden
    public int HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = _random.Next(_words.Count);
            Word word = _words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
        }
        return hiddenCount;
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word w in _words)
        {
            scriptureText += w.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }

    public int TotalWords()
    {
        return _words.Count;
    }

    public Reference GetReference()
    {
        return _reference;
    }
}
