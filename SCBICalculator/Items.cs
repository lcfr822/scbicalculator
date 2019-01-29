using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCBICalculator
{
    public static class Items
    {
        public static List<BaseItem> baseItems = new List<BaseItem>();
        public static List<SupplyItem> supplyItems = new List<SupplyItem>();
        public static List<HardwareItem> hardwareItems = new List<HardwareItem>();
        public static List<FarmerItem> farmerItems = new List<FarmerItem>();
        public static List<GardenItem> gardenItems = new List<GardenItem>();
        public static List<FurnitureItem> furnitureItems = new List<FurnitureItem>();
        public static List<DonutItem> donutItems = new List<DonutItem>();
        public static List<FashionItem> fashionItems = new List<FashionItem>();
        public static List<FastFoodItem> fastFoodItems = new List<FastFoodItem>();
        public static List<HomeApplianceItem> homeApplianceItems = new List<HomeApplianceItem>();
    }

    public struct BaseItem
    {
        public readonly string name;
        public readonly int productionTime;

        public BaseItem(string newName, int newProdTime)
        {
            name = newName;
            productionTime = newProdTime;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct SupplyItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requirementCounts;

        public SupplyItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct HardwareItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredSupplies;
        public readonly int[] requirementCounts;

        public HardwareItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqSupplyIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredSupplies = newReqSupplyIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct FarmerItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredGardening;
        public readonly int[] requirementCounts;

        public FarmerItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqGardenIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredGardening = newReqGardenIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct GardenItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredSupplies;
        public readonly int[] requiredHardware;
        public readonly int[] requirementCounts;

        public GardenItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqSupplyIndeces, int[] newReqHardwareIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredSupplies = newReqSupplyIndeces;
            requiredHardware = newReqHardwareIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct FurnitureItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredSupplies;
        public readonly int[] requiredHardware;
        public readonly int[] requirementCounts;

        public FurnitureItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqSupplyIndeces, int[] newReqHardwareIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredSupplies = newReqSupplyIndeces;
            requiredHardware = newReqHardwareIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct DonutItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredFarmed;
        public readonly int[] requirementCounts;

        public DonutItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqFarmIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredFarmed = newReqFarmIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct FashionItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredSupplies;
        public readonly int[] requiredHardware;
        public readonly int[] requirementCounts;

        public FashionItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqSupplyIndeces, int[] newReqHardwareIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredSupplies = newReqSupplyIndeces;
            requiredHardware = newReqHardwareIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct FastFoodItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredFarmedItems;
        public readonly int[] requiredDonut;
        public readonly int[] requiredAppliance;
        public readonly int[] requirementCounts;

        public FastFoodItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqFarmIndeces, int[] newReqDonutIndeces, int[] newReqApplianceIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredFarmedItems = newReqFarmIndeces;
            requiredDonut = newReqDonutIndeces;
            requiredAppliance = newReqApplianceIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }

    public struct HomeApplianceItem
    {
        public readonly string name;
        public readonly int productionTime;
        public readonly int[] requiredItems;
        public readonly int[] requiredHardware;
        public readonly int[] requirementCounts;

        public HomeApplianceItem(string newName, int newProdTime, int[] newReqItemIndeces, int[] newReqHardwareIndeces, int[] newReqCounts)
        {
            name = newName;
            productionTime = newProdTime;
            requiredItems = newReqItemIndeces;
            requiredHardware = newReqHardwareIndeces;
            requirementCounts = newReqCounts;
        }

        public override string ToString()
        {
            TimeSpan span = TimeSpan.FromSeconds(productionTime);
            string returnString = name + "\n" + string.Format("{0:D2}:{1:D2}:{2:D2}", span.Hours, span.Minutes, span.Seconds);
            return returnString;
        }
    }
}
