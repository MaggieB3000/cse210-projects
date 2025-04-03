using System;

class Swimming : Activity
{
private int _laps;

public Swimming(string date, double duration, string type, int laps) : base(date, duration, type)
{
    _laps = laps;
}

public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
}