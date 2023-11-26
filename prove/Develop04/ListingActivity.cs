using System;
using System.Diagnostics;

public class ListingActivity : Activity
{
    // Attributes 
    private List<string> _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };
    private List<string> _count = new List<string>();
    
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run(int seconds)
    {
        GetListFromUser(seconds);
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void GetListFromUser(int seconds)
    {
        Console.WriteLine();  
        var question = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"\n--- {question} ---");
        ShowCountDown(5);
        
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.Write("> ");
            _count.Add(Console.ReadLine());
        }
        timer.Stop();
        int count = _count.Count;
        Console.WriteLine($"\nYou listed {count} items!");
    }





}