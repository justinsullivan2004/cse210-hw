class Checkpoint:Goal
{
    int totalTimes;
    int bonusPoints;
    int timesCompleted = 0;
    public Checkpoint():base() {

    }
    public Checkpoint(string name, string description, int points, bool isCompleted, int totalTimes, int bonusPoints):base(name, description, points, isCompleted)
    {
        this.isCompleted = isCompleted;
        this.totalTimes = totalTimes;
        this.bonusPoints = bonusPoints;
    }
    public int getBonusPoints()
    {
        Console.WriteLine("What is the bonus for completing this goal?");
        bonusPoints = int.Parse(Console.ReadLine());
        return bonusPoints;
    }
    public int getTotalTimes()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        totalTimes = int.Parse(Console.ReadLine());
        return totalTimes;
    }

    public override string Display()
    {

        return $"{base.Display()} - {timesCompleted}/{totalTimes}";

    }
    public override void recordEvent()
    {
        timesCompleted += 1;
        if (timesCompleted != totalTimes) 
        {
            totalPoints += points;
        }
        else if (timesCompleted == totalTimes) 
        {
            totalPoints += bonusPoints;
            isCompleted = true;
        }
    }
    public override int DisplayPoints()
    {
        return base.DisplayPoints();
    }

}