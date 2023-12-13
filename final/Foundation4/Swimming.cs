using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double CalculateSpeed()
    {
        double speed = Math.Round(CalculateDistance() / _minutes * 60);
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = Math.Round(_minutes / CalculateDistance());
        return pace;
    }
}