class Car {

    public string model;
    public string make;
    public int year;
    public int milesPerGallon;
    public int gallons;
    public Person owner;
    //called a method, funciton defined inside a class
    public int TotalRange() {
        return gallons * milesPerGallon;
    }
    public void Display() {
        System.Console.WriteLine($"make {make} model {model} year {year} {owner.DisplayString()}: Total Range {TotalRange()} gallons {gallons} MPG {milesPerGallon}");
    }
}

class Person {

    public string name;
    public string phone;

    public string DisplayString() {
        return $"{name} {phone}";
    
    }

}