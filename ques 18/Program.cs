namespace ques_18
{
    

public class Computer
    {
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }
    }

    public class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        public double DesktopPriceCalculation()
        {
            double processorCost = GetProcessorCost(Processor);
            double ramCost = RamSize * 200; // Ram price per GB
            double hardDiskCost = HardDiskSize * 1500; // Hard disk price per TB
            double graphicCardCost = GraphicCard * 2500; // Graphic Card price per GB
            double monitorCost = MonitorSize * 250; // Monitor price per inch
            double powerSupplyCost = PowerSupplyVolt * 20; // Power Supply price per volt

            return processorCost + ramCost + hardDiskCost + graphicCardCost + monitorCost + powerSupplyCost;
        }

        private double GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3":
                    return 1500;
                case "i5":
                    return 3000;
                case "i7":
                    return 4500;
                default:
                    return 0; // Invalid processor
            }
        }
    }

    public class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public double LaptopPriceCalculation()
        {
            double processorCost = GetProcessorCost(Processor);
            double ramCost = RamSize * 200; // Ram price per GB
            double hardDiskCost = HardDiskSize * 1500; // Hard disk price per TB
            double graphicCardCost = GraphicCard * 2500; // Graphic Card price per GB
            double displayCost = DisplaySize * 250; // Display price per inch
            double batteryCost = BatteryVolt * 20; // Battery price per volt

            return processorCost + ramCost + hardDiskCost + graphicCardCost + displayCost + batteryCost;
        }

        private double GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3":
                    return 2500;
                case "i5":
                    return 5000;
                case "i7":
                    return 6500;
                default:
                    return 0; // Invalid processor
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Desktop");
            Console.WriteLine("2. Laptop");
            Console.Write("Choose the option: ");
            int choice = int.Parse(Console.ReadLine());

            Computer computer = null;

            if (choice == 1)
            {
                computer = new Desktop();
                var desktop = (Desktop)computer;

                Console.Write("Enter the processor: ");
                desktop.Processor = Console.ReadLine();

                Console.Write("Enter the RAM size: ");
                desktop.RamSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the hard disk size: ");
                desktop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the graphic card size: ");
                desktop.GraphicCard = int.Parse(Console.ReadLine());

                Console.Write("Enter the monitor size: ");
                desktop.MonitorSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the power supply volt: ");
                desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

                double desktopPrice = desktop.DesktopPriceCalculation();
                Console.WriteLine($"Desktop price is {desktopPrice}");
            }
            else if (choice == 2)
            {
                computer = new Laptop();
                var laptop = (Laptop)computer;

                Console.Write("Enter the processor: ");
                laptop.Processor = Console.ReadLine();

                Console.Write("Enter the RAM size: ");
                laptop.RamSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the hard disk size: ");
                laptop.HardDiskSize = int.Parse(Console.ReadLine());

                Console.Write("Enter the graphic card size: ");
                laptop.GraphicCard = int.Parse(Console.ReadLine());

                Console.Write("Enter the display size: ");
                laptop.DisplaySize = int.Parse(Console.ReadLine());

                Console.Write("Enter the battery volt: ");
                laptop.BatteryVolt = int.Parse(Console.ReadLine());

                double laptopPrice = laptop.LaptopPriceCalculation();
                Console.WriteLine($"Laptop price is {laptopPrice}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }

}

