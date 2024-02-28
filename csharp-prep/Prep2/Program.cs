using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Please provide your score.");
        }

        int score = Convert.ToInt32(Console.ReadLine());

        char letter;

        if (score >= 90)
        {
            letter = 'A';
        }
        else if (score >= 80)
        {
            letter = 'B';
        }
        else if (score >= 70)
        {
            letter = 'C';
        }
        else if (score >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course.");
        }
    }
}
