public abstract class Vehicle
{
    public String description = "Unknown Vehicle";
    public String Description()
    {
        return description;
    }
    public abstract double Cost();
}

public abstract class Features : Vehicle
{
    public abstract String Description();
}

public class Benz : Vehicle
{
    override public double Cost()
    {
        return 900.90;
    }
}

public class YokohomaTyres : Features
{
    public Vehicle vehicle;
    public YokohomaTyres(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }

    public override double Cost()
    {
        return 70.9 + vehicle.Cost();
    }

    public override string Description()
    {
        return "thanks for using YokohomaTyres" + vehicle.Description();
    }
}

public class VenniceInterior : Features
{
    public Vehicle vehicle;
    public VenniceInterior(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }
    public override double Cost()
    {
        return this.vehicle.Cost() + 40.9;
    }

    public override string Description()
    {
        return "thanks for using VenniceInterior";
    }
}

