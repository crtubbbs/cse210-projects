class Program_CT
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string _CTchoice = Console.ReadLine();
            Console.WriteLine();

            switch (_CTchoice)
            {
                case "1":
                    PerformBreathingActivity();
                    break;
                case "2":
                    PerformReflectionActivity();
                    break;
                case "3":
                    PerformListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }

    static void PerformBreathingActivity()
    {
        Console.Write("Enter the duration of the activity (in seconds): ");
        int _CTduration = int.Parse(Console.ReadLine());

        BreathingActivity_CT _CTbreathingActivity = new BreathingActivity_CT(_CTduration);
        _CTbreathingActivity.Start();
        _CTbreathingActivity.PerformBreathing();
        _CTbreathingActivity.End("Breathing");
    }

    static void PerformReflectionActivity()
    {
        Console.Write("Enter the duration of the activity (in seconds): ");
        int _CTduration = int.Parse(Console.ReadLine());

        ReflectionActivity_CT _CTreflectionActivity = new ReflectionActivity_CT(_CTduration);
        _CTreflectionActivity.Start();
        _CTreflectionActivity.Reflect();
        _CTreflectionActivity.End("Reflection");
    }

    static void PerformListingActivity()
    {
        Console.Write("Enter the duration of the activity (in seconds): ");
        int _CTduration = int.Parse(Console.ReadLine());

        ListingActivity_CT _CTlistingActivity = new ListingActivity_CT(_CTduration);
        _CTlistingActivity.Start();
        _CTlistingActivity.ListItems();
        _CTlistingActivity.End("Listing");
    }
}