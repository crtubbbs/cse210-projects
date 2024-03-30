abstract class Goal
{
    public string _CTName { get; set; }
    public int _CTPoints { get; set; }
    public int _CTTimesCompleted { get; set; }

    public Goal(string _CTName, int _CTPoints, int _CTTimesCompleted = 0)
    {
        this._CTName = _CTName;
        this._CTPoints = _CTPoints;
        this._CTTimesCompleted = _CTTimesCompleted;
    }

    public abstract void _CTAccomplish();
    public abstract string _CTGetGoalStatus();
    public abstract string _CTSerialize();
    public abstract int _CTScore { get; }
}