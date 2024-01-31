using System;
using System.Net;
using System.Collections.Generic;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        var entryList = new List<string>();
        bool repeat = true;
        int choice = 0;
        String userEntry;

        //entry class
        Entry entry = new Entry();
        //journal class
        Journal journal = new Journal();
        while (repeat == true) {

            

            System.Console.WriteLine("1. Write a new entry");
            System.Console.WriteLine("2. Display the journal");
            System.Console.WriteLine("3. Save the journal to a file");
            System.Console.WriteLine("4. Load the journal from a file");
            System.Console.WriteLine("5. Exit");

            System.Console.Write("Choose an option (1-5): ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
            //writes entry
                Console.Clear();
                entry.getEntry(GetRandomPrompt());
                userEntry = entry.ConstructEntry(GetRandomPrompt());

                
                entryList.Add(userEntry);

            }
            if (choice == 2)
            {
            //displays journal
        
                foreach (var e in entryList)
                    {

                        System.Console.WriteLine(e);

                    }

            }            
            else if (choice == 3)
            {
            //save journal to file
                Console.Clear();
                journal.SaveFile(entryList);


            }            
            else if (choice == 4)
            {
                Console.Clear();
                //load journal from file
                Journal.DisplayFile();

            }            
            else if (choice == 5)
            {
            
                repeat = false;

            }
            else 
            {

                System.Console.WriteLine("Wrong input");

            }
        }

    }

    static string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }


}