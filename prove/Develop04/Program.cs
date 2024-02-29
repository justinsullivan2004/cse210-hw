using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        Shared share = new Shared();
        Breathing breathe = new Breathing();
        Reflection reflection = new Reflection();
        Listening listening = new Listening();

        int secondsChosen;
        bool repeat = true;

        while (repeat != false)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");

            int choice = int.Parse(Console.ReadLine());

            share.activityStatment(choice);
            if (choice != 4)
            {
                secondsChosen = int.Parse(Console.ReadLine());
                share.getShare(secondsChosen);
                if (choice == 1)
                {
                    breathe.breathingTest(1, 1, secondsChosen);
                }
                else if (choice == 2) 
                {
                    reflection.reflectionActivity(secondsChosen);
                }
                else if (choice == 3)
                {
                    listening.listeningActivity(secondsChosen);
                }
            share.activityEnding(choice, secondsChosen);
            }
            else
            {
                repeat = false;
            }  
        }
    }
}