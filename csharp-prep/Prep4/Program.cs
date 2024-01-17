using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int total = 0;

        List<int> numbers; 
        numbers = new List<int>();
        
        int user_numbers = -1;

        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (user_numbers != 0) 
        {

            System.Console.Write("Enter Number: ");
            user_numbers = int.Parse(Console.ReadLine());

            numbers.Add(user_numbers);

        }

        int biggest_number = numbers[0];

        foreach (int number in numbers) 
        {

            total += number;

            if (biggest_number < number)
            {
                biggest_number = number;
            }

        }
        
        float average = 0;

        average = ((float)total) / (numbers.Count - 1);

        System.Console.WriteLine($"The sum is: {total}");
        System.Console.WriteLine($"The average is: {average}");
        System.Console.WriteLine($"The largest number is: {biggest_number}");

    }
}