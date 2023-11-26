using System;

public class Activity
{
    // Attributes
    public string _name;
    public string _description;
    public int _duration;

    private string _message = "You may begin in...";

    // Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!\n");
        ShowSpinner();
    }


    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _duration = userSeconds;
        return _duration;
    }
        
    public void ShowSpinner()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(100);
        }
    }

    public void ShowCountDown(int time)
    {
        Console.WriteLine();  
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message} {i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  "); 
    }

    

}