using System;

public class SimpleGoal : Goal
{
    // Attributes
    private string _type = "Simple Goal:";
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points)
    {
        _isComplete = isComplete;
    }
    public Boolean IsComplete()
    {
        return _isComplete;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_isComplete}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_isComplete}");
    }
    public override void RecordEvent(List<Goal> goals)
    {
       _isComplete = true;
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

}