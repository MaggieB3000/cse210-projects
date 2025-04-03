using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, string type, int speed) : base(date, duration, type)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed/60)*_duration;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}