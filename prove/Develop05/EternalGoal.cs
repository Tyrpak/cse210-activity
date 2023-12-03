using System;

public class EternalGoal : Goal
{
    // Attributes
    private string _type = "Eternal Goal:";
    private bool _isComplete;


    // Constructors
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool isComplete) : base(type, name, description, points)
    {
        _isComplete = isComplete;
    }

    // Methods

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
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
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }


}