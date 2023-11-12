using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        int action = 0;
        
        Journal journal = new Journal();
        PromptGenerator randomPrompt = new PromptGenerator();

        while (action != 5)
        {
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write an entry
                    string dateInfo = GetDateTime();
                    string prompt = randomPrompt.GetRandomPrompt();
                    string entryNumber = GetEntryNumber();

                    Entry entry = new Entry();
                    entry._date = dateInfo;
                    entry._entryNumber = entryNumber;
                    entry._promptText = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write("Please enter your entry here: ");
                    string userEntry = Console.ReadLine();
                    entry._entryText = userEntry;

                    journal.AddEntry(entry);

                    break;
                case 2:
                    // Display journal entries
                    journal.DisplayAll();
                    break;
                case 3:
                    // Load file
                    journal.LoadFromFile();
                    break;
                case 4:
                    // Save file
                    journal.SaveToFile();
                    break;
                case 5:
                    // Quit
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static int Choices()
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = 0;
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return action;
    }

    static string GetDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    static string GetEntryNumber()
    {
        string currentTime = GetDateTime();
        int todaysNumberOfEntries = 0;
        string entryStrNumber = "";
        
        List<Entry> _journalEntries = new List<Entry>();
        
        foreach (Entry entry in _journalEntries)
        {
            //entryStrNumber = "valami";
            if (entry._date == currentTime){
                
                todaysNumberOfEntries++;
                };
        }
        
        entryStrNumber = todaysNumberOfEntries.ToString();
        
        return entryStrNumber;
    }    
}