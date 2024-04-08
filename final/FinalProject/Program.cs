using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        string exercise = "";
        double weightLifted = 0;
        double repsDone = 0;
        int numberOfReps = 0;
        int tierChosen = 0;
        var trainers = new List<Trainer>();
        var clients = new List<Client>();
        var tier1 = new Tier("Jack Wellington", 1, 50);
        var tier2 = new Tier("Adam Welker", 2, 125);
        var tier3 = new Tier("Sam Sulek", 3, 250);
        trainers.Add(tier1);
        trainers.Add(tier2);
        trainers.Add(tier3);
        Menu menu = new Menu(tierChosen);
        Animation animation = new Animation();
        bool repeat = true;
        System.Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Please enter your body weight(lbs): ");
        int bodyWeight = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Please enter your height(in.): ");
        int height = int.Parse(Console.ReadLine());
        while (repeat == true)
        {
            Console.WriteLine(menu.display(tierChosen));
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1 & tierChosen > 0)
            {
                animation.animation1();
                var bodyComp = new BodyComp(name, bodyWeight, height);
                // Console.WriteLine(bodyComp.display());
                clients.Add(bodyComp);
                System.Console.WriteLine("The clients information has been added to the list. ");
            }
            else if (choice == 1 & tierChosen < 1)
            {
                System.Console.WriteLine("You don't have the right trainer for this. ");
            }
            else if (choice == 2 & tierChosen > 1)
            {
                Console.WriteLine("What exercise is this for: ");
                exercise = Console.ReadLine();
        
                Console.WriteLine("How much weight did you lift? ");
                weightLifted = double.Parse(Console.ReadLine());

                Console.WriteLine("How many reps did you do? ");
                repsDone = double.Parse(Console.ReadLine());
        
                Console.WriteLine($"Enter how many reps you want to acheive for {exercise}(2, 4, 6, 8, 10): ");
                numberOfReps = int.Parse(Console.ReadLine());

                animation.animation2();
                var repCalc = new RepCalc(name, bodyWeight, height, exercise, weightLifted, repsDone, numberOfReps);
                // Console.WriteLine(repCalc.display());
                clients.Add(repCalc);
                System.Console.WriteLine("The clients information has been added to the list. ");
            }
            else if (choice == 2 & tierChosen < 2)
            {
                System.Console.WriteLine("You don't have the right trainer for this. ");
            }
            else if (choice == 3 & tierChosen > 2)
            {
                animation.animation1();
                var workout = new WorkoutPlan(name, bodyWeight, height, exercise, weightLifted, repsDone, numberOfReps);
                // System.Console.WriteLine(workout.display());
                clients.Add(workout);
                System.Console.WriteLine("The clients information has been added to the list. ");
            }
            else if (choice == 3 & tierChosen < 3)
            {
                System.Console.WriteLine("You don't have the right trainer for this. ");
            }
            else if (choice == 4)
            {
                System.Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
                System.Console.WriteLine("Please enter your body weight(lbs): ");
                bodyWeight = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Please enter your height(in.): ");
                height = int.Parse(Console.ReadLine());
            }
            else if (choice == 5)
            {
                foreach (var t in trainers)
                {
                    Console.WriteLine($"{t.display()}");
                }
                Console.WriteLine("Which tier trainer do you choose(1, 2, 3): ");
                tierChosen = int.Parse(Console.ReadLine());
            }
            else if (choice == 6)
            {
                foreach (var c in clients)
                {
                    System.Console.WriteLine(c.display());
                }
            }
            else if (choice == 7)
            {
                repeat = false;
            }
            else
                System.Console.WriteLine("Please choose a correct choice. ");
        }
    }
}