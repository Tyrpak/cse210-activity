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
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking through your breathing in and out slowly. Clear your mind and focus on your breathing", 30);
                    breathing.DisplayStartingMessage();
                    int seconds = breathing.GetActivityTime();
                    breathing.Run(seconds);
                    breathing.DisplayEndingMessage();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30);
                    reflecting.DisplayStartingMessage();
                    seconds = reflecting.GetActivityTime();
                    reflecting.Run(seconds);
                    reflecting.DisplayEndingMessage();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30);
                    listing.DisplayStartingMessage();
                    seconds = listing.GetActivityTime();
                    listing.Run(seconds);
                    listing.DisplayEndingMessage();
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