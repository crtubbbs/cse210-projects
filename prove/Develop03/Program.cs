using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to input scripture reference
        Console.WriteLine("Enter the scripture reference (e.g., John 3:16):");
        string input = Console.ReadLine();

        // Parse the scripture reference
        if (TryParseScriptureReference(input, out _CTScriptureReference scriptureReference))
        {
            // Create a new scripture
            _CTScripture scripture = new _CTScripture(scriptureReference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

            // Display the complete scripture
            _CTDisplayScripture(scripture);

            // Prompt the user to press enter or type quit
            while (true)
            {
                Console.WriteLine("\nEnter 'e' to continue or type 'quit' to exit:");
                string _CTInput = Console.ReadLine().ToLower();

                if (_CTInput == "quit")
                    break;

                if (_CTInput == "e")
                {
                    // Hide a few random words
                    _CTHideRandomWords(scripture);

                    // Clear the console screen
                    Console.Clear();

                    // Display the complete scripture after hiding words
                    _CTDisplayScripture(scripture);

                    // Check if all words are hidden
                    if (scripture._CTAllWordsHidden())
                    {
                        Console.WriteLine("\nAll words in the scripture are hidden. Exiting the program.");
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid scripture reference format.");
        }
    }

    static void _CTDisplayScripture(_CTScripture _CTScripture)
    {
        Console.WriteLine($"Scripture Reference: {_CTScripture._CTReference}");
        Console.WriteLine($"Scripture Text:");

        foreach (var word in _CTScripture._CTWords)
        {
            Console.Write(word._CTIsHidden ? "***** " : $"{word._CTText} ");
        }

        Console.WriteLine();
    }

    static void _CTHideRandomWords(_CTScripture _CTScripture)
    {
        Random _CTRandom = new Random();

        // Calculate the number of words to hide (randomly between 1 to 3)
        int _CTWordsToHide = _CTRandom.Next(1, 4);

        // Generate random indices to hide words
        for (int i = 0; i < _CTWordsToHide; i++)
        {
            int _CTIndex = _CTRandom.Next(_CTScripture._CTWords.Count);
            _CTScripture._CTWords[_CTIndex]._CTIsHidden = true;
        }
    }

    static bool TryParseScriptureReference(string input, out _CTScriptureReference scriptureReference)
    {
        scriptureReference = null;

        // Split input by space
        string[] parts = input.Split(' ');

        if (parts.Length < 2)
            return false;

        string book = parts[0];
        string[] chapterAndVerse = parts[1].Split(':');

        if (chapterAndVerse.Length < 2)
            return false;

        if (!int.TryParse(chapterAndVerse[0], out int chapter))
            return false;

        string[] startAndEndVerse = chapterAndVerse[1].Split('-');

        if (!int.TryParse(startAndEndVerse[0], out int startVerse))
            return false;

        int endVerse = startVerse;

        if (startAndEndVerse.Length == 2 && !int.TryParse(startAndEndVerse[1], out endVerse))
            return false;

        scriptureReference = new _CTScriptureReference(book, chapter, startVerse, endVerse);
        return true;
    }
}
