using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int total = 0;
        int count = 0;
        int average = 0;
        int previous_number = 0;
        int biggest_number = 0;

        List<int> numbers; 
        numbers = new List<int>();
        
        int user_numbers = -1;

        System.Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (user_numbers != 0) 
        {

            System.Console.WriteLine("Enter Number: ");
            user_numbers = int.Parse(Console.ReadLine());

            numbers.Add(user_numbers);

        }

        foreach (int number in numbers) 
        {

            total = total + number;
            count = count + 1;
            previous_number = number;

            if (previous_number > number)
            {
                biggest_number = number;
            }

        }

        average = total / count;

        System.Console.WriteLine($"The sum is: {total}");
        System.Console.WriteLine($"The average is {average}");
        System.Console.WriteLine($"The largest number is {biggest_number}");



    }
}