using Microsoft.VisualBasic;

public class Client
{
    protected string name;
    protected double bodyWeight;
    protected double height;

    public Client(string name, double bodyWeight, double height)
    {
        this.name = name;
        this.bodyWeight = bodyWeight;
        this.height = height;
    }

    public virtual string display()
    {
        return $"Name: {name}, Body Weight: {bodyWeight}, Height: {height}";
    }
}