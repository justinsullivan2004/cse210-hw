using Microsoft.VisualBasic;

public class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected bool isCompleted = false;
    protected int totalPoints;

    public Goal()
    {
        Console.WriteLine("What is the name of your goal? ");
        name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal");
        points = int.Parse(Console.ReadLine());
    }

    public Goal(string name, string description, int points, bool isCompleted)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.isCompleted = isCompleted;
    }

    public virtual string Display()
    {

        return $"[{(isCompleted ? "X" : " ")}] - {name} - ({description}) - {points}";

    }
    public virtual void recordEvent()
    {
        isCompleted = true;
        totalPoints += points;
    }
    public virtual int DisplayPoints()
    {
        return totalPoints;
    }

    

}