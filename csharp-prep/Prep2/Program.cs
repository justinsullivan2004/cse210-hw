using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        String letter = "";

        System.Console.Write("What is your grade percentage? ");
        String user_grade_percentage = Console.ReadLine();
        int grade_percentage = int.Parse(user_grade_percentage);


        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else if (grade_percentage < 60)
        {
            letter = "F";
        }

        if (letter == "D" || letter == "F")
        {
            System.Console.WriteLine($"Your letter grade is {letter}, good luck next year!");
        }
        else 
        {
            System.Console.WriteLine($"Congrats! You passed with a {letter}");
        }

    }
}