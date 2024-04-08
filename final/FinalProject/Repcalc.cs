public class RepCalc:Client
{
    protected double weightLifted;
    protected double repsDone;
    protected string exercise;
    protected int numberOfReps;
    public RepCalc(string name, int bodyWeight, int height, string exercise, double weightLifted, double repsDone, int numberOfReps):base(name, bodyWeight, height)
    {
        this.name = name;
        this.bodyWeight = bodyWeight;
        this.height = height;
        this.exercise = exercise;
        this.weightLifted = weightLifted;
        this.repsDone = repsDone;
        this.numberOfReps = numberOfReps;
    }

    private double maxCalculator()
    {
        double oneRepMax = weightLifted * (1 + (0.0333 * repsDone));
        return oneRepMax;
    }

    private string repDecision()
    {
        double variable = 0;
        if (numberOfReps == 2)
        {
            variable = .97;
        }
        else if (numberOfReps == 4) 
        {
            variable = .92;
        }
        else if (numberOfReps == 6) 
        {
            variable = .86;
        }
        else if (numberOfReps == 8) 
        {
            variable = .81;
        }
        else if (numberOfReps == 10)
        {
            variable = .75;
        }
        return $"For {exercise} you should complete {maxCalculator() * variable:0} for {numberOfReps}";
    }
    public override string display()
    {
        return $"{base.display()}\n" +
        $"Your one rep max for {exercise} is {maxCalculator():0}lbs approximetly\n" +
        $"{repDecision()} approximetly ";
    }
}