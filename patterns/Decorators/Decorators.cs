public abstract class Beverage
{

    public String description = "Unknown Beverage";

    public String GetDescription()
    {
        return description;
    }
    public abstract double Cost();
}

public abstract class CondimentDecorator : Beverage
{
    public abstract String GetDescription();
}

public class Espresso : Beverage
{

    public Espresso()
    {
        this.description = "Espresso";
    }

    override public double Cost()
    {
        return 1.99;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "ouse Blend Coffee";
    }
    override public double Cost()
    {
        return .89;
    }
}

public class Mocha : CondimentDecorator
{
    Beverage beverage;
    public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }
    override public String GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }
    override public double Cost()
    {
        return .20 + beverage.Cost();
    }
}