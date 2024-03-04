using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");
        int sumofall = 0;

        int largest = -999;

        while (true)
        {       
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
                break;

            numbers.Add(number);

            sumofall = number + sumofall;

            if (number > largest)
                largest = number;
        }
        
        int numofitems = numbers.Count();

        int average =  sumofall / numofitems;


        Console.WriteLine($"The sum of these numbers is {sumofall}");
        Console.WriteLine($"The average of the numbers is {average}");
        Console.WriteLine($"The largest number is {largest}");
        // Console.WriteLine("Numbers entered:");
        // foreach (int num in numbers)
        // {
        //     Console.WriteLine(num);
        // }
    }
}
