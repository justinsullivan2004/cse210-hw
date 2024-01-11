using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("Whats your age?");

        var ageString = Console.ReadLine();
        System.Console.WriteLine($"My age is {ageString}.");
        System.Console.WriteLine("My age is " + ageString + ".");

        int age = int.Parse(ageString);

        if (age < 18) 
        {
            System.Console.WriteLine("You are a minor.");
        }
        else 
        {
            System.Console.WriteLine("you are old");
        }

    }
}