public class Trainer
{
    protected string name;
    protected int tier;

    public Trainer (string name, int tier)
    {
        this.name = name;
        this.tier = tier;
    }
    private string qualifications()
    {
        if (tier == 1)
        {
            return "BMI test only";
        }
        else if (tier == 2)
        {
            return "BMI and rep calculations only";
        }
        else if (tier == 3) 
        {
            return "BMI, rep calculations, and workout plan";
        }
        return "";
    }
    public virtual string display()
    {
        return $"Name: {name} Tier: {tier}\n" +
        $"({qualifications()}) ";
    }
}