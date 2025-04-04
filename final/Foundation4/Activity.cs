using System;

abstract class Activity
{
    protected string _date;
    protected double _duration;

    private string _type;

    public Activity(string date, double duration, string type)
    {
        _date = date;
        _duration = duration;
        _type = type;
    }

    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        return (GetDistance() / _duration) * 60;
    }
    public virtual double GetPace()
    {
        return _duration / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_type} ({_duration} min): Distance {GetDistance(),3:F2} km, Speed: {GetSpeed(),3:F2} kph, Pace: {GetPace(),3:F2} min per km";
    }
}