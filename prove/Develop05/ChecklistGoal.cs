using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _type = "Check List Goal:";
    private int _target;
    private int _bonus;
    private bool _isComplete;
    private int _amountCompleted;


    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, int target, int bonus) : base(type, name, description, points)
    {
        _isComplete = false;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool isComplete, int target, int bonus, int amountCompleted) : base(type, name, description, points)
    {
        _isComplete = isComplete;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget()
    {
        _amountCompleted = _amountCompleted + 1;
    }
     public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted()
    {

    }
     public int GetBonus()
    {
        return _bonus;
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
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetAmountCompleted()}/{GetTarget()}");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetAmountCompleted()}/{GetTarget()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_isComplete}; {GetTarget()}; {GetBonus()}; {GetAmountCompleted()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_isComplete}; {GetTarget()}; {GetBonus()}; {GetAmountCompleted()}");
    }
    public override void RecordEvent(List<Goal> goals)
    {
        SetTarget();
        int points = GetPoints();

        if (_amountCompleted == _target)
        {
            _isComplete = true;
            points = points + _bonus;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

}