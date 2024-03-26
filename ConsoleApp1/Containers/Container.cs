public abstract class Container(double cargoWeight, double height, double weight, double depth, double carryingCapacity, string containerType)
{
    public double CargoWeight {get; protected set;} = cargoWeight;
    public double Height {get;} = height;
    public double Weight {get;} = weight;
    public double Depth {get;} = depth;
    public double CarryingCapacity {get;} = carryingCapacity;
    public string SerialNumber {get;} = "KON" + containerType;

    public static int Count
    {
        get{return ++_count;}
    }
    private static int _count = 0;

    public virtual void Empty()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double mass)
    {
        if(CargoWeight > CarryingCapacity)
        {
            throw new OverFillException();
        }
        CargoWeight += mass;
    }
    
}