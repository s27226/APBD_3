public class GasContainer(double cargoWeight, double height, double weight, double depth, double carryingCapacity, double pressure) : Container(cargoWeight,height,weight,depth,carryingCapacity,_containerType + Count), IHazardNotifier
{
    double Pressure{get;} = pressure;
    private const string _containerType = "-G-";
    public void NotifyOfDanger(string message)
    {
        Console.WriteLine("[" + SerialNumber + "]" + message);
    }

    public override void Empty()
    {
        CargoWeight = 0.05*CargoWeight;
    }
    //Jeśli masa ładunku przekroczy dopuszczalną ładowność -chcemy zwrócić błąd.
    //Zakładamy, że metoda w superklasie już spełnia ten punkt
}