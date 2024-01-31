using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Car car = new Car();

        var cars = new List<Car>();
        var owner = new Person();
        
        car.make = "Honda";
        car.model = "Civic";
        car.year = 2023;
        car.gallons = 10;
        car.milesPerGallon = 30;
        owner.name = "Bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);


        car = new Car();
        car.make = "Ford";
        car.model = "F-150";
        car.year = 2023;
        car.gallons = 30;
        car.milesPerGallon = 5;

        owner = new Person();
        owner.name = "Sue";
        owner.phone = "444-4444";
        car.owner = owner; 

        cars.Add(car);

        foreach (var c in cars) {
            // System.Console.WriteLine($"make {c.make} model {c.model}: Total Range {c.TotalRange()} gallons {c.gallons} MPG {c.milesPerGallon}");
            c.Display();
        }
    }



}
