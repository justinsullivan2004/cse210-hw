public class Tier:Trainer
{
    private float price;
    public Tier(string name, int tier, float price):base(name, tier)
    {
        this.name = name;
        this.tier = tier;
        this.price = price;
    }
    
    public override string display()
    {
        return $"{base.display()} ${price}";
    }

}