using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal _CTjournal = new Journal();
        string _CTchoice;
        do
        {
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            _CTchoice = Console.ReadLine();

            switch (_CTchoice)
            {
                case "1":
                    _CTjournal.WriteNewEntry();
                    break;
                case "2":
                    _CTjournal.DisplayJournal();
                    break;
                case "3":
                    _CTjournal.LoadJournalFromFile();
                    break;
                case "4":
                    _CTjournal.SaveJournalToFile();
                    break;
            }
        } while (_CTchoice != "5");
    }
}