class ReflectionActivity_CT : Mindfulness
{
    private string[] _CTprompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _CTquestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity_CT(int _CTduration) : base(_CTduration) { }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity:");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.Start();
    }

    public override void End(string _CTactivityName)
    {
        Console.WriteLine($"You have completed the {_CTactivityName} activity for {_CTduration} seconds.");
        base.End(_CTactivityName);
    }

    public void Reflect()
    {
        Console.WriteLine($"Think about: {_CTprompts[new Random().Next(_CTprompts.Length)]}");
        Thread.Sleep(3000);

        foreach (string _CTquestion in _CTquestions)
        {
            Console.WriteLine(_CTquestion);
            Thread.Sleep(3000);
        }
    }
}
