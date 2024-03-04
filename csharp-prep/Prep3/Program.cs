using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        int magic = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int guess = -1;

        while (magic != guess)
        {
            Console.WriteLine("What is your guess?");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > magic)
            {
                Console.WriteLine("Lower!");
            }

            if (guess < magic)
            {
                Console.WriteLine("Higher!");
            }
            count++;
        }

        Console.WriteLine($"Congratulations! You guessed the magic number {magic}, in {count} attempts.");


    }
}
