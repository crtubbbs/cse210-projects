using System;
class Journal
{
    private List<Entry> _CTEntries = new List<Entry>();
    private List<string> _CTPrompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void WriteNewEntry()
    {
        Console.WriteLine("\nWriting a new entry...");
        Console.WriteLine("Selecting a random prompt...");
        Random rnd = new Random();
        int index = rnd.Next(_CTPrompts.Count);
        string prompt = _CTPrompts[index];
        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        _CTEntries.Add(new Entry(prompt, response, date));
        Console.WriteLine("Entry saved successfully!");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (Entry entry in _CTEntries)
        {
            Console.WriteLine($"{entry._CTDate}: {entry._CTPrompt}\n{entry._CTResponse}\n");
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("\nEnter the file name to save the journal: ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _CTEntries)
            {
                writer.WriteLine($"{entry._CTDate}: {entry._CTPrompt}\n{entry._CTResponse}\n");
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }

    public void LoadJournalFromFile()
    {
        Console.Write("\nEnter the file name to load the journal: ");
        string fileName = Console.ReadLine();
        _CTEntries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new string[] { ": " }, StringSplitOptions.None);
                string date = parts[0];
                string prompt = parts[1];
                string response = reader.ReadLine();
                _CTEntries.Add(new Entry(prompt, response, date));
            }
        }
        Console.WriteLine("Journal loaded from file successfully!");
    }
}