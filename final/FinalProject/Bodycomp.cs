using System.Reflection.Metadata.Ecma335;

public class BodyComp:Person
{
    public BodyComp():base()
    {
    }
    public BodyComp(string name, int age, double bodyWeight, string gender, double height):base(name, age, bodyWeight, gender, height)
    {
    }

    private double bmiCalculator()
    {
        double bmi = bodyWeight * 703 / Math.Pow(height, 2.0);
        return bmi;
    }
    // private string bmiDescription()
    // {
    //     string chosenString;
    //     double bmi = bmiCalculator();
    //     if (bmi < 18.5) 
    //     {
    //         chosenString = $"Since your BMI of {bmi} is below 18.5, you are classified as underweight";
    //     }
    //     if (bmi >= 18.5 || bmi < 25) 
    //         {
    //         chosenString = $"Since your BMI of {bmi} is between 18.5 and 25, you are classified as normal weight";
    //         }
    //     if (bmi >= 25 || bmi < 30) 
    //     {
    //         chosenString = $"Since your BMI of {bmi} is between 25 and 30, you are classified as overweigh";
    //     }
    //     if (bmi >= 30) 
    //     {
    //         chosenString = $"Since your BMI of {bmi} is above 30, you are classified as obese";
    //     }
    //     return chosenString;      
    // }

    public override string display()
    {
        return $"Person Selected: \n{base.display()}\n" +
        $"{name} has a bmi of {bmiCalculator()}";
        // bmiDescription();
    }



}