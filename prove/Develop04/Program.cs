using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        Console.Clear();
        
        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = Choices();

            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetActivityTime();
                    reflecting.GetReady();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetActivityTime();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Quit
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }

        static int Choices()
            {
                string choices = $@"
Menu Options
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit
Select a choice from the menu:  ";

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



    }

}