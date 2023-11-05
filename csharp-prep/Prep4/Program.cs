using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        
        int newNumber = -1;

        while (newNumber != 0)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                newNumber = int.Parse(userInput);
                
                if (newNumber != 0)
                    {
                        numbers.Add(newNumber);
                    }

            } 

        int sum = 0;
        int maximum = 0;

        foreach (int number in numbers)
            {
                sum += number;

                if (number > maximum)
                    {
                        maximum = number;
                    }

            }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {sum}");

        Console.WriteLine($"The largest number is: {maximum}");

    }
}