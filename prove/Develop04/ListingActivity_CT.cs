class ListingActivity_CT : Mindfulness
{
    private string[] _CTlistPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity_CT(int _CTduration) : base(_CTduration) { }

    public override void Start()
    {
        Console.WriteLine("Listing Activity:");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.Start();
    }

    public override void End(string _CTactivityName)
    {
        Console.WriteLine($"You have completed the {_CTactivityName} activity for {_CTduration} seconds.");
        base.End(_CTactivityName);
    }

    public void ListItems()
    {
        Console.WriteLine($"List as many items as you can in response to: {_CTlistPrompts[new Random().Next(_CTlistPrompts.Length)]}");
        Thread.Sleep(3000);
        Console.WriteLine("Start listing...");

        // Simulate user input, in a real program, you'd take actual user input.
        for (int i = 0; i < _CTduration; i++)
        {
            Console.WriteLine($"Item {i + 1}");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You listed {_CTduration} items.");
    }
}