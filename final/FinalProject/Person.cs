public class Person
{
    protected string name;
    protected double bodyWeight;
    protected int age;
    protected string gender; 
    protected double height;

    public Person()
    {
        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your bodyweight in lbs: ");
        bodyWeight = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your gender(m/f): ");
        gender = Console.ReadLine();

        Console.WriteLine("Please enter your height: ");
        height = float.Parse(Console.ReadLine());
    }
    public Person(string name, int age, double bodyWeight, string gender, double height)
    {
        this.name = name;
        this.age = age;
        this.bodyWeight = bodyWeight;
        this.gender = gender;
        this.height = height;
    }
    public virtual string display()
    {
        return $"Name: {name}, Age: {age}, Body Weight: {bodyWeight}, Gender: {gender}";
    }
}