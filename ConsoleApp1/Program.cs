using ContainerManager.Containers;

namespace ContainerManager
{
    public class Program
    {  
        public static void Main()
        {
            var container = new LiquidContainer(5,5,5,5,5,LiquidClassifier.Safe);
            var container2 = new LiquidContainer(5,5,5,5,5,LiquidClassifier.Safe);
            var ship = new ContainerShip(5,5,5);
            var ship2 = new ContainerShip(5,5,5);

            ship.ContainerList.Add(container);
            var list = new List<Container>
            {
                container2
            };
            ship.ContainerList = list;
            ship.ContainerList.Remove(container);
            ship.ContainerList.Clear();

            ship2.ContainerList.Add(container);
            ship.ContainerList.Add(container2);

            Console.WriteLine(container2);
            Console.WriteLine(ship);

        }
    }
}