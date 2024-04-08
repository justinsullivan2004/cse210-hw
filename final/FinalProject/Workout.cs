using System.Security.Cryptography.X509Certificates;

public class WorkoutPlan:RepCalc
{
    int muscleGroup1;
    public WorkoutPlan(string name, int bodyWeight, int height, string exercise, double weightLifted, double repsDone, int numberOfReps):base(name, bodyWeight, height, exercise, weightLifted, repsDone, numberOfReps)
    {
        Console.WriteLine("Enter which number you want to focus on: \n" + 
        "(1. Upper Body)\n" +
        "(2. Lower Body)");
        muscleGroup1 = int.Parse(Console.ReadLine());

        this.name = name;
        this.bodyWeight = bodyWeight;
        this.height = height;
    }

    private string mainWorkout()
    {
        if (muscleGroup1 == 1)
        {
            return $"Monday(10 reps each): " +
            $"BenchPress: {bodyWeight * .7} " +
            $"Incline Bench: {bodyWeight * .55}\n" +
            $"Tuesday(rest): \n" +
            $"Wednesday(10 reps each): " +
            $"DeadLift: {bodyWeight * 1.75} " + 
            $"Lat Pull Down: {bodyWeight * .65}\n" + 
            "Wednesday(rest): \n" +
            "Thursday(10 reps each): " + 
            $"Tricep Push Down: {bodyWeight * .25} " + 
            $"Lateral Raises: {bodyWeight * .15} " +
            $"Bicep Preacher Curls: {bodyWeight * .25} \n" + 
            "Can repeat or repeat at the start of the next week";
        }
        else if (muscleGroup1 == 2)
        {
            return $"Monday(10 reps each): " +
            $"Barbell Squat: {bodyWeight * .85} " +
            $"Lunges: {bodyWeight * .15}\n" +
            $"Tuesday(rest): \n" +
            $"Wednesday(10 reps each): " +
            $"DeadLift: {bodyWeight * 1.75} " + 
            $"Leg Press: {bodyWeight * .95}\n" + 
            "Wednesday(rest): \n" +
            "Can repeat or repeat at the start of the next week";
        }
        return "";
    }

    public override string display()
    {
        return $"{mainWorkout()}";
    }


}