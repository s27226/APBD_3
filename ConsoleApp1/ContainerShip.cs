using System.Text;
using ContainerManager.Containers;

namespace ContainerManager
{
    public class ContainerShip(double maxSpeed, int maxContainers, int maxContainerSumWeight)
    {
        public List<Container> ContainerList {get; set;} = [];
        public double MaxSpeed {get;} = maxSpeed;
        public int MaxContainers {get;} = maxContainers;
        public double MaxContainerSumWeight {get;} = maxContainerSumWeight;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\t");
            foreach(Container container in ContainerList)
            {
                sb.Append(container);
            }
            string modified = sb.ToString().Replace("\n", "\n\t");
            return "MaxSpeed: " + MaxSpeed + "\nMaxContainers: " + MaxContainers + "\nMaxContainerSumWeight: " + MaxContainerSumWeight + "\n" + modified;
        }
    }
}