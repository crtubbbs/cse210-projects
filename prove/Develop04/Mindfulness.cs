using System;
using System.Threading;

class Mindfulness
{
    protected int _CTduration;

    public Mindfulness(int _CTduration)
    {
        this._CTduration = _CTduration;
    }

    public virtual void Start()
    {
        Console.WriteLine("Starting the activity...");
        Thread.Sleep(2000);
    }

    public virtual void End(string _CTactivityName)
    {
        Console.WriteLine($"Well done! You have completed the {_CTactivityName} activity.");
        Thread.Sleep(2000);
    }
}