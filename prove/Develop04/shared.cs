using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Shared
{
    
    protected int desiredTime;

    public void getShare(int desiredTime)
    {

        this.desiredTime = desiredTime;

    }


    public void animation(int secondsAnimation) 
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(secondsAnimation);

        while (DateTime.Now <= futureTime)
        {
            
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");

        }

    }

    public void activityStatment(int choice)
    {

        if (choice == 1)
        {

            Console.WriteLine("Welcome to the Breathing Activity. ");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
            Console.WriteLine("How long in seconds would you like your session? ");

        }
        else if (choice == 2)
        {
            
            Console.WriteLine("Welcome to the Reflection Activity. ");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine("How long in seconds would you like your session? ");

        }
        else if (choice == 3)
        {
            
            Console.WriteLine("Welcome to the Listening Activity. ");
            Console.WriteLine();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("How long in seconds would you like your session? ");

        }
    }
    public void activityEnding(int choice, int desiredTime)
    {

        if (choice == 1)
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed another {desiredTime} seconds of breathing");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed another {desiredTime} seconds of reflecting");
        }
        else if (choice == 3)
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed another {desiredTime} seconds of listening");
        }

    }

}
