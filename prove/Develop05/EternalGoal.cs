class EternalGoal : Goal
{
    public EternalGoal(string _CTName, int _CTPoints, int _CTTimesCompleted = 0) : base(_CTName, _CTPoints, _CTTimesCompleted) { }

    public override void _CTAccomplish()
    {
        _CTTimesCompleted++;
    }

    public override string _CTGetGoalStatus()
    {
        return $"{_CTName}: Eternal Goal [Completed: {_CTTimesCompleted} times]";
    }

    public override string _CTSerialize()
    {
        return $"{_CTName},{_CTPoints},{_CTTimesCompleted},Eternal";
    }

    public override int _CTScore => _CTPoints * _CTTimesCompleted;
}
