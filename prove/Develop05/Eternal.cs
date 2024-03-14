class Eternal:Goal
{

    public Eternal():base() {

    }
    public Eternal(string name, string description, int points, bool isCompleted, int totalPoints):base(name, description, points, isCompleted)
    {
    }

    public override string Display()
    {

        return $"{base.Display()}";

    }
    public override void recordEvent()
    {
        totalPoints += points;
    }
    public override int DisplayPoints()
    {
        return base.DisplayPoints();
    }

}