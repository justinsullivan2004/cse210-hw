using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();

        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int number_squared = SquareNumber(user_number);
        
        DisplayResult(user_name, number_squared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int user_number = int.Parse(Console.ReadLine());
        return user_number;
    }
    static int SquareNumber(int user_number)
    {
        int number_squared = user_number * user_number;
        return number_squared;
    }
    static void DisplayResult(string user_name, int number_squared)
    {
        Console.Write($"{user_name}, the square of your number is {number_squared}");
    }


}