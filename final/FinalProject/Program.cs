using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        // var persons = new List<Person>();
        Menu menu = new Menu();
        Animation animation = new Animation();
        bool repeat = true;
        while (repeat == true)
        {
            Console.WriteLine(menu.menuDisplay());
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // foreach (var p in persons)
                // {
                    var bodyComp = new BodyComp();
                    Console.WriteLine(bodyComp.display());
                // }
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            // else if (choice == 5)
            // {
            //     Person person = new Person();
            //     persons.Add(person);      
            // }
            else if (choice == 6)
            {
                repeat = false;
            }
            else
                System.Console.WriteLine("Please choose a correct choice. ");
        }
    }
}