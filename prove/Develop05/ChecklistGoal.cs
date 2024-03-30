class ChecklistGoal : Goal
{
    public int _CTTotalTimes { get; set; }

    public ChecklistGoal(string _CTName, int _CTPoints, int _CTTimesCompleted, int _CTTotalTimes) : base(_CTName, _CTPoints, _CTTimesCompleted)
    {
        _CTTotalTimes = _CTTotalTimes;
    }

    public override void _CTAccomplish()
    {
        _CTTimesCompleted++;
        if (_CTTimesCompleted == _CTTotalTimes)
        {
            Console.WriteLine($"Congratulations! You've completed the {_CTName} goal {_CTTotalTimes} times and earned a bonus of {_CTPoints} points.");
        }
    }

    public override string _CTGetGoalStatus()
    {
        return $"{_CTName}: Checklist Goal [Completed: {_CTTimesCompleted}/{_CTTotalTimes} times]";
    }

    public override string _CTSerialize()
    {
        return $"{_CTName},{_CTPoints},{_CTTimesCompleted},Checklist,{_CTTotalTimes}";
    }

    public override int _CTScore => _CTTimesCompleted == _CTTotalTimes ? _CTPoints * _CTTotalTimes + _CTPoints : _CTPoints * _CTTimesCompleted;
}
