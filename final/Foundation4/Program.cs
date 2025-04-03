using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("4/3/25", 30, "Running", 15),
            new Cycling("4/14/25", 25, "Cycling", 20),
            new Swimming("4/7/25", 45, "Swimming", 40)
        };

         Console.WriteLine("Fitness Activity Tracker\n");

         foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}