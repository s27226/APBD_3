namespace ContainerManager.Containers
{
    public class CoolingContainer(double cargoWeight, double height, double weight, double depth, double carryingCapacity, string productType, int temperature) : Container(cargoWeight,height,weight,depth,carryingCapacity,_containerType + Count)
    {
        public string ProductType
        {
            get {return _productType;}
            set {if(CargoWeight == 0) _productType = value;}
        }
        private string _productType = productType;

        public int Temperature
        {
            get {return _temperature;}
            set
            {
                if(ProductTypes.ProductTypesMap.ContainsKey(ProductType) && value >= ProductTypes.ProductTypesMap[ProductType])
                {
                    _temperature = value;
                }
            } 
        }
        private int _temperature = temperature;
        private const string _containerType = "-C-";
        public override string ToString()
        {
            return base.ToString() + "\nProductType: " + ProductType + "\nTemperature: " + Temperature;
        }
    }

public class ProductTypes
{
    public static readonly Dictionary<string,double> ProductTypesMap = new Dictionary<string, double>{};
    static ProductTypes()
    {
        ProductTypesMap.Add("Bananas", 13.3);
        ProductTypesMap.Add("Chocolate", 18);
        ProductTypesMap.Add("Fish", 2);
        ProductTypesMap.Add("Meat", -15);
        ProductTypesMap.Add("Ice Cream", -18);
        ProductTypesMap.Add("Frozen Pizza", -30);
        ProductTypesMap.Add("Cheese", 7.2);
        ProductTypesMap.Add("Sausages", 5);
        ProductTypesMap.Add("Butter", 20.5);
        ProductTypesMap.Add("Eggs", 19);
    }

}
}