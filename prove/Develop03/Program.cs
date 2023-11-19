using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference.ReferenceDisplay();
        
        Console.Write("\nPress enter to continue or type 'quit' to finish");
        
        GetReadKey();
    
    }

    private void GetReadKey()
    {
        string input = Console.Read();
        if (input == "quit")
        { 
            Environment.Exit(0);
        }
        else 
        {
            Word.GetNewHiddenWord();
        }
    }

}