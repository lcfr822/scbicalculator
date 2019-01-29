using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SCBICalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button backButton = new Button();
        List<Button> baseButtons = new List<Button>();

        public MainWindow()
        {
            InitializeComponent();

            backButton.Height = 25;
            backButton.Width = 280;
            backButton.Content = "BACK";
            backButton.FontWeight = FontWeights.Bold;
            backButton.Click += BackButton_Click;

            baseButtons.Add(SupplyButton);
            baseButtons.Add(HardwareButton);
            baseButtons.Add(FarmerButton);
            baseButtons.Add(FurnitureButton);
            baseButtons.Add(GardeningButton);
            baseButtons.Add(DonutButton);
            baseButtons.Add(FashionButton);
            baseButtons.Add(FastFoodButton);
            baseButtons.Add(AppliancesButton);

            InitializeItemLists();
        }

        private void InitializeItemLists()
        {
            Items.baseItems.Add(new BaseItem("Metal", 60)); // 0
            Items.baseItems.Add(new BaseItem("Wood", 180)); // 1
            Items.baseItems.Add(new BaseItem("Plastic", 540)); // 2
            Items.baseItems.Add(new BaseItem("Seeds", 1200)); // 3
            Items.baseItems.Add(new BaseItem("Minerals", 1800)); // 4
            Items.baseItems.Add(new BaseItem("Chemicals", 7200)); // 5
            Items.baseItems.Add(new BaseItem("Cloth", 10800)); // 6
            Items.baseItems.Add(new BaseItem("Sugar and Spices", 14400)); // 7
            Items.baseItems.Add(new BaseItem("Glass", 18000)); // 8
            Items.baseItems.Add(new BaseItem("Animal Feed", 21600)); // 9
            Items.baseItems.Add(new BaseItem("Electrical Components", 25200)); // 10

            Items.supplyItems.Add(new SupplyItem("Nails", 300, new int[] { 0 }, new int[] { 2 })); // 0
            Items.supplyItems.Add(new SupplyItem("Planks", 1800, new int[] { 1 }, new int[] { 2 })); // 1
            Items.supplyItems.Add(new SupplyItem("Bricks", 1200, new int[] { 4 }, new int[] { 2 })); // 2
            Items.supplyItems.Add(new SupplyItem("Cement", 3000, new int[] { 4, 5 }, new int[] { 2, 1 })); // 3
            Items.supplyItems.Add(new SupplyItem("Glue", 3600, new int[] { 2, 5 }, new int[] { 1, 2 })); // 4
            Items.supplyItems.Add(new SupplyItem("Paint", 3600, new int[] { 0, 4, 5 }, new int[] { 2, 1, 2 })); // 5

            Items.hardwareItems.Add(new HardwareItem("Hammer", 840, new int[] { 0, 1 }, null, new int[] { 1, 1 })); // 0
            Items.hardwareItems.Add(new HardwareItem("Measuring Tape", 1200, new int[] { 0, 2 }, null, new int[] { 1, 1 })); // 1
            Items.hardwareItems.Add(new HardwareItem("Shovel", 1800, new int[] { 0, 1, 2 }, null, new int[] { 1, 1, 1 })); // 2
            Items.hardwareItems.Add(new HardwareItem("Cooking Utensils", 2700, new int[] { 0, 1, 2 }, null, new int[] { 2, 2, 2 })); // 3
            Items.hardwareItems.Add(new HardwareItem("Ladder", 3600, new int[] { 0 }, new int[] { 1 }, new int[] { 2, 2 })); // 4
            Items.hardwareItems.Add(new HardwareItem("Drill", 7200, new int[] { 0, 2, 10 }, null, new int[] { 2, 2, 1 })); // 5

            Items.farmerItems.Add(new FarmerItem("Vegetables", 1200, new int[] { 3 }, null, new int[] { 2 })); // 0
            Items.farmerItems.Add(new FarmerItem("Flour Bag", 1800, new int[] { 3, 6 }, null, new int[] { 2, 2 })); // 1
            Items.farmerItems.Add(new FarmerItem("Fruit and Berries", 5400, new int[] { 3 }, new int[] { 1 }, new int[] { 2, 1 })); // 2
            Items.farmerItems.Add(new FarmerItem("Cream", 4500, new int[] { 9 }, null, new int[] { 1 })); // 3
            Items.farmerItems.Add(new FarmerItem("Corn", 3600, new int[] { 3, 4 }, null, new int[] { 1, 4 })); // 4
            Items.farmerItems.Add(new FarmerItem("Cheese", 6300, new int[] { 9 }, null, new int[] { 2 })); // 5
            Items.farmerItems.Add(new FarmerItem("Beef", 9000, new int[] { 9 }, null, new int[] { 3 })); // 6

            Items.furnitureItems.Add(new FurnitureItem("Chairs", 1200, new int[] { 1 }, new int[] { 0 }, new int[] { 0 }, new int[] { 2, 1, 1 })); // 0
            Items.furnitureItems.Add(new FurnitureItem("Tables", 1800, null, new int[] { 0, 1 }, new int[] { 0 }, new int[] { 2, 1, 1 })); // 1
            Items.furnitureItems.Add(new FurnitureItem("Home Textiles", 4500, new int[] { 6 }, null, new int[] { 1 }, new int[] { 2, 1 })); // 2
            Items.furnitureItems.Add(new FurnitureItem("Cupboard", 3375, new int[] { 8 }, new int[] { 1, 5 }, null, new int[] { 2, 2, 1 })); // 3
            Items.furnitureItems.Add(new FurnitureItem("Couch", 9000, new int[] { 6 }, new int[] { 4 }, new int[] { 5 }, new int[] { 3, 1, 1 })); // 4

            Items.gardenItems.Add(new GardenItem("Grass", 1800, new int[] { 3 }, null, new int[] { 2 }, new int[] { 1, 1 })); // 0
            Items.gardenItems.Add(new GardenItem("Tree Saplings", 5400, new int[] { 3 }, null, new int[] { 2 }, new int[] { 2, 1 })); // 1
            Items.gardenItems.Add(new GardenItem("Garden Furniture", 8100, new int[] { 2, 6 }, new int[] { 1 }, null, new int[] { 2, 2, 2 })); // 2
            Items.gardenItems.Add(new GardenItem("Fire Pit", 14400, null, new int[] { 2, 3 }, new int[] { 2 }, new int[] { 2, 2, 1 })); // 3
            Items.gardenItems.Add(new GardenItem("Lawn Mower", 7200, new int[] { 0, 10 }, new int[] { 5 }, null, new int[] { 3, 1, 1 })); // 4
            Items.gardenItems.Add(new GardenItem("Garden Gnomes", 5400, null, new int[] { 3, 4 }, null, new int[] { 2, 1 })); // 5

            Items.donutItems.Add(new DonutItem("Donuts", 2700, new int[] { 7 }, new int[] { 1 }, new int[] { 1, 1 })); // 0
            Items.donutItems.Add(new DonutItem("Green Smoothie", 1800, null, new int[] { 0, 2 }, new int[] { 1, 1 })); // 1
            Items.donutItems.Add(new DonutItem("Bread Roll", 3600, null, new int[] { 1, 3 }, new int[] { 2, 1 })); // 2
            Items.donutItems.Add(new DonutItem("Cherry Cheesecake", 5400, null, new int[] { 1, 2, 5 }, new int[] { 1, 1, 1 })); // 3
            Items.donutItems.Add(new DonutItem("Frozen Yogurt", 14400, new int[] { 7 }, new int[] { 2, 3 }, new int[] { 1, 1, 1 })); // 4
            Items.donutItems.Add(new DonutItem("Coffee", 3600, new int[] { 3, 7 }, new int[] { 3 }, new int[] { 2, 1, 1 })); // 5

            Items.fashionItems.Add(new FashionItem("Cap", 3600, new int[] { 6 }, null, new int[] { 1 }, new int[] { 2, 1 })); // 0
            Items.fashionItems.Add(new FashionItem("Shoes", 4500, new int[] { 2, 6 }, new int[] { 4 }, null, new int[] { 2, 2, 1 })); // 1
            Items.fashionItems.Add(new FashionItem("Watch", 5400, new int[] { 2, 5, 8 }, null, null, new int[] { 2, 1, 1 })); // 2
            Items.fashionItems.Add(new FashionItem("Business Suits", 12600, new int[] { 6 }, new int[] { 4 }, new int[] { 1 }, new int[] { 3, 1, 1 })); // 3
            Items.fashionItems.Add(new FashionItem("Backpack", 9000, new int[] { 2, 6 }, null, new int[] { 1 }, new int[] { 2, 2, 1 })); // 4

            Items.fastFoodItems.Add(new FastFoodItem("Ice Cream Sandwich", 840, null, new int[] { 3 }, new int[] { 2 }, null, new int[] { 1, 1 })); // 0
            Items.fastFoodItems.Add(new FastFoodItem("Pizza", 1440, null, new int[] { 1, 5, 6 }, null, null, new int[] { 1, 1, 1 })); // 1
            Items.fastFoodItems.Add(new FastFoodItem("Burgers", 2100, null, new int[] { 6 }, new int[] { 2 }, new int[] { 0 }, new int[] { 1, 1, 1 })); // 2
            Items.fastFoodItems.Add(new FastFoodItem("Cheese Fries", 1200, null, new int[] { 0, 5 }, null, null, new int[] { 1, 1 })); // 3
            Items.fastFoodItems.Add(new FastFoodItem("Lemonade Bottle", 3600, new int[] { 7, 8 }, new int[] { 2 }, null, null, new int[] { 2, 2, 1 })); // 4
            Items.fastFoodItems.Add(new FastFoodItem("Popcorn", 1800, null, new int[] { 4 }, null, new int[] { 4 }, new int[] { 2, 1 })); // 5

            Items.homeApplianceItems.Add(new HomeApplianceItem("BBQ Grill", 9900, new int[] { 0 }, new int[] { 3 }, new int[] { 3, 1 })); // 0
            Items.homeApplianceItems.Add(new HomeApplianceItem("Refrigerator", 12600, new int[] { 2, 5, 10 }, null, new int[] { 2, 2, 2 })); // 1
            Items.homeApplianceItems.Add(new HomeApplianceItem("Lighting System", 6300, new int[] { 5, 8, 10 }, null, new int[] { 1, 1, 1 })); // 2
            Items.homeApplianceItems.Add(new HomeApplianceItem("TV", 9000, new int[] { 2, 5, 10 }, null, new int[] { 2, 2, 2 })); // 3
            Items.homeApplianceItems.Add(new HomeApplianceItem("Microwave Oven", 7200, new int[] { 0, 8, 10 }, null, new int[] { 4, 1, 1 })); // 4
        }



        private void SupplyButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach(BaseItem bItem in Items.baseItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = bItem.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void HardwareButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (HardwareItem item in Items.hardwareItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void FarmerButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (FarmerItem item in Items.farmerItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void FurnitureButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (FurnitureItem item in Items.furnitureItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void GardeningButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (GardenItem item in Items.gardenItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void DonutButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (DonutItem item in Items.donutItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void FashionButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (FashionItem item in Items.fashionItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void FastFoodButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (FastFoodItem item in Items.fastFoodItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void AppliancesButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach (HomeApplianceItem item in Items.homeApplianceItems)
            {
                Button newButton = new Button();
                newButton.Height = 25;
                newButton.Width = 280;
                newButton.Content = item.name;
                ProductionListBox.Items.Add(newButton);
            }
            ProductionListBox.Items.Add(backButton);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionListBox.Items.Clear();
            foreach(Button button in baseButtons)
            {
                ProductionListBox.Items.Add(button);
            }
        }
    }
}
