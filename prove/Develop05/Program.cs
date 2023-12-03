using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        GoalManager goals = new GoalManager();

        Console.Clear();  
        Console.Write("\nWelcome to the Eternal Quest Program\n");

        Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");

        static int MainMenu()
            {
                string mainMenu = $@"
Menu Options
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu:  ";

                Console.Write(mainMenu);
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
                    Console.WriteLine($"Unexpected error:  {exception.Message}");
                }
                return action;
            }

        int action = 0;
        while (action != 6)
        {
            action = MainMenu();

            switch (action)
            {
                case 1:
                    Console.Clear();  
                    int goalChoice = 0;

                    static int GoalMenu()
                        {
                            string goalMenu = $@"
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
What type of goal would you like to create?  ";

                            Console.Write(goalMenu);
                            string userInput = Console.ReadLine();
                            int goalChoice = 0;
                            try
                            {
                                goalChoice = int.Parse(userInput);
                            }
                            catch (FormatException)
                            {
                                goalChoice = 0;
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine($"Unexpected error:  {exception.Message}");
                            }
                            return goalChoice;
                        }

                    goalChoice = GoalMenu();

                    switch (goalChoice)
                        {
                            case 1:
                                Console.WriteLine("What is the name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);                        
                                break;
                            case 2:
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                break;
                            case 3:
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int target = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, target, bonus);
                                goals.AddGoal(clGoal);
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    break;
                case 2:
                    Console.Clear();  
                    Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");
                    goals.ListGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    Console.Clear();  
                    Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    Console.Clear();  
                    Console.Write($"\nYou have {goals.GetTotalPoints()} points.\n");
                    goals.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}