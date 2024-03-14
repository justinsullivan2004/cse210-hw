using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        bool cont = true;
        int numeration = 0;
        
        File files = new File();

        var goalList = new List<Goal>();
        while (cont == true)
        {
            // how to display points
            foreach (var g in goalList)
            {
                totalPoints = g.DisplayPoints();
            }
            System.Console.WriteLine($"You have a total of {totalPoints} points. ");
            System.Console.WriteLine();
            System.Console.Write("Menu Options:\n" +
            "   1. Create New Goal\n" +
            "   2. List Goals\n" +
            "   3. Save Goals\n" +
            "   4. Load Goals\n" +
            "   5. Record Event\n" +
            "   6. Quit\n" +
            "Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {

                System.Console.Write("The types of goals are:\n" +
                "   1. Simple Goal\n" +
                "   2. Eternal Goal\n" +
                "   3. Checklist Goal\n" +
                "Which type of goal would you like to create: ");

                int decision = int.Parse(Console.ReadLine());
                if (decision == 1)
                {
                    var simpleGoal = new Simple();
                    goalList.Add(simpleGoal);
                }
                else if (decision == 2)
                {
                    var eternalGoal = new Eternal();
                    goalList.Add(eternalGoal);
                }
                else if (decision == 3)
                {
                    //why aren't you executing
                    var checkpointGoal = new Checkpoint();
                    checkpointGoal.getTotalTimes();
                    checkpointGoal.getBonusPoints();
                    goalList.Add(checkpointGoal);
                }
            }
            
            else if (choice == 2)
            {
                numeration = 0;
                foreach (var g in goalList)
                {
                    numeration += 1;
                    System.Console.WriteLine($"{numeration}. {g.Display()}");
                }
            }
            else if (choice == 3)
            {
                files.SaveFile(goalList);
            }
            else if (choice == 4)
            {
                
                string[] loadedLines = File.DisplayFile(); 
                foreach (var line in loadedLines){
                    //convert line into goaal object
                        string[] parts = line.Split("-");

                        var completion = parts[0];
                        bool isCompleted = false;
                        if(completion.Contains('x'))
                        {
                            isCompleted = true;
                        }
                        string name = parts[1];
                        string description = parts[2];
                        int points = int.Parse(parts[3]);
                        var new_goal = new Goal(name, description, points, isCompleted);

                        goalList.Add(new_goal);
                }
            }
            else if (choice == 5)
            {
                numeration = 0;
                foreach (var g in goalList)
                {
                    numeration += 1;
                    System.Console.WriteLine($"{numeration}. {g.Display()}");
                }
                System.Console.WriteLine("What item do you want to complete? ");
                int editDecision = int.Parse(Console.ReadLine());
                numeration = 0;
                foreach (var g in goalList)
                {
                    numeration += 1;
                    if (numeration == editDecision)
                    {
                        g.recordEvent();
                    }
                }
            }
            else if (choice == 6)
            {
                cont = false;
            }
            else
            System.Console.WriteLine("Please choose an option shown. ");
            }
        }
    }
