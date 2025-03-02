using System;
using System.Collections.Generic;
using System.Threading;

class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    protected override void PerformActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountdown(4);
            Console.Write("\n\nNow breathe out...");
            ShowCountdown(6);
        }
    }
}