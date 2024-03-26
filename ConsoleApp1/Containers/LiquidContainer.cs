namespace ContainerManager.Containers
{
    public class LiquidContainer(double cargoWeight, double height, double weight, double depth, double carryingCapacity, LiquidClassifier safety) : Container(cargoWeight,height,weight,depth,carryingCapacity,_containerType + Count), IHazardNotifier
    {
        public LiquidClassifier Safety
        {
            get{return _safety;}
            set{if(CargoWeight == 0) _safety = value;}
        }
        private LiquidClassifier _safety = safety;
        private const string _containerType = "-L-";
        public void NotifyOfDanger(string message)
        {
            Console.WriteLine(message);
        }

        public override void Load(double mass)
        {
            if(Safety == LiquidClassifier.Dangerous && mass + CargoWeight > 0.50 * CarryingCapacity)
            {
                NotifyOfDanger("Recorded a dangerous attempt on a container.");
            }
            else if(Safety == LiquidClassifier.Safe && mass + CargoWeight > 0.90 * CarryingCapacity)
            {
                NotifyOfDanger("Recorded a dangerous attempt on a container.");
            }
            else
            {
                base.Load(mass);
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSafety: " + Safety;
        }
    }

    public enum LiquidClassifier
    {
        Safe,Dangerous
    }
}