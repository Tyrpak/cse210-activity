using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string file = "MyJournal.txt";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    static string GetDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    public string GetEntryNumber()
    // function was for exceeding the core, but the foreach is not working
    {
        string currentTime = GetDateTime();
        int todaysNumberOfEntries = 1;
        
        foreach (Entry entry in _entries)
        {
            if (entry._date == currentTime){
                
            todaysNumberOfEntries++;
            };
        }
        
        string entryStrNumber = todaysNumberOfEntries.ToString();
        
        return entryStrNumber;
    }    

    public void SaveToFile()

    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._entryNumber}; {entry._promptText}; {entry._entryText}");
            }
        }
    }

    public void LoadFromFile()
    
    {
        List<string> readText = File.ReadAllLines(file).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._date = entries[0];
                entry._entryNumber = entries[1];
                entry._promptText = entries[2];
                entry._entryText = entries[3];

                AddEntry(entry);
            }
    }
}