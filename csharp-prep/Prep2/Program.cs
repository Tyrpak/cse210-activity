using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many points? ");
        string userInput = Console.ReadLine();
        int points = int.Parse(userInput);

        string grade = "";

        if (points >= 90)
            {
                grade = "A";
            }
        else if (points >= 80)
            {
                grade = "B";
            }
        else if (points >= 70)
            {
                grade = "C";
            }
        else if (points >= 60)
            {
                grade = "D";
            }
        else if (points < 60)
            {
                grade = "F";
            }

        Console.Write($"Your grade is: {grade}");

        if (points >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}