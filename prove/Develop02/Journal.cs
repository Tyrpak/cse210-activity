using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string file = "MyJournal.txt";

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("\n");
    }

    public void SaveToFile()

    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._promptText};: {entry._entryText}| ");
            }
        }
    }

    public void LoadFromFile()
    
    {
        List<string> readText = File.ReadAllLines(file).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string line in readText)
            {
                string[] entries = line.Split("| ");

                Entry entry = new Entry();

                entry._date = entries[0];
                entry._promptText = entries[1];
                entry._entryText = entries[2];

                _entries.Add(entry);
            }
    }

}