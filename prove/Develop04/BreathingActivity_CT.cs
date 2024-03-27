class BreathingActivity_CT : Mindfulness
{
    public BreathingActivity_CT(int _CTduration) : base(_CTduration) { }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity:");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.Start();
    }

    public override void End(string _CTactivityName)
    {
        Console.WriteLine($"You have completed the {_CTactivityName} activity for {_CTduration} seconds.");
        base.End(_CTactivityName);
    }

    public void PerformBreathing()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000);

        for (int i = 0; i < _CTduration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000);
        }
    }
}