using System;

class Running : Activity
{
    private int _distance;

    public Running(string date, double duration, string type, int distance) : base(date, duration, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
}