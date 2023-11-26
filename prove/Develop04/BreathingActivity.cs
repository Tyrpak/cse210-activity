using System;

public class BreathingActivity : Activity
{
    private string _message1 = "Breathe in...";
    private string _message2 = "Now breathe out...";
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    
    public void Run(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  //insert blank line to start
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_message1}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message1.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message1}  ");  // last prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_message2}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_message2.Length + 2));  // Overwrite line
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_message2}  ");  // last prompt
        }
    }
}