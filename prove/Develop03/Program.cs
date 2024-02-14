using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // populating scripture class
        Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        // populating with second verse
        scripture.AddVerse(new Reference("John", 3, 17), "For God did not send his Son into the world to condemn the world, but to save the world through him.");

        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWord();
        }
    }
}