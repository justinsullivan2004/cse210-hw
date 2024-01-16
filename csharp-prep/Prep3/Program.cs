using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int guess_number = 0;

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        while (guess_number != magic_number)
        {
            System.Console.WriteLine("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());

            if (guess_number > magic_number)
            {
                System.Console.WriteLine("Lower");
            }
            if (guess_number < magic_number)
            {
                System.Console.WriteLine("Higher");
            }
            else
            {
                System.Console.WriteLine("Congrats! You guessed it. ");
            }

        } 




    

    }
}