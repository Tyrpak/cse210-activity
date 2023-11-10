using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        
        Journal journal = new Journal();
        PromptGenerator pg = new PromptGenerator();

        while (action != 5)
        {
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string dateInfo = GetDateTime();
                    string prompt = pg.GetRandomPrompt();

                    Entry entry = new Entry();
                    entry._date = dateInfo;
                    entry._promptText = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write("Please enter your entry here: ");
                    string userEntry = Console.ReadLine();
                    entry._entryText = userEntry;

                    journal.AddEntry(entry);

                    break;
                case 2:
                    // Display Journal Entries
                    journal.DisplayAll();
                    break;
                case 3:
                    // Load file
                    journal.LoadFromFile();
                    break;
                case 4:
                    // Save
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
    // Method to display choices to user
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
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
}