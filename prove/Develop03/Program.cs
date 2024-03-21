using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object
        Scripture _CTScripture = new Scripture("John 3:16", "For God so loved the world...");

        // Hide words one by one until all words are hidden
        while (!_CTScripture._CTAllWordsHidden)
        {
            Console.Clear();
            _CTScripture._CTHideRandomWord();
            Console.WriteLine(_CTScripture._CTGetHiddenText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit...");
            string _CTInput = Console.ReadLine();
            if (_CTInput.ToLower() == "quit")
                break;
        }
        Console.WriteLine("Program ended.");
    }
}