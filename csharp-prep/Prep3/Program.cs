using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess;

        do
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                if (guess < number)
                    {
                        Console.WriteLine("Higher");       

                    }
                else if (guess > number)
                    {
                        Console.WriteLine("Lower");       

                    }

            } while (guess != number);

        Console.Write("You guessed it!");

    }
}