using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activityList = new List<Activity>();
        
        Running running = new Running("September 5, 2023", 12, 2.4);
        activityList.Add(running);

        StationaryBicycles stationaryBicycles = new StationaryBicycles("December 7, 2023", 60, 21);
        activityList.Add(stationaryBicycles);

        Swimming swimming = new Swimming("August 21, 2023", 60, 50);
        activityList.Add(swimming);

        Console.WriteLine("Activities:");
        Console.WriteLine();

        foreach (Activity activity in activityList) 
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}