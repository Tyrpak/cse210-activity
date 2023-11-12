using System;

public class Entry
{
    public string _date = "";
     public string _entryNumber = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry()
    {
    }
    
    public void Display()
    {
        Console.WriteLine($"\nJournal Entry Nr. #{_entryNumber} on {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

}