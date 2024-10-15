namespace ques_20
{
   

public class Car
    {
        // Properties for Car
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Virtual method to calculate the cost
        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice; // Default implementation for other types of cars
        }
    }

    public class SportsCar : Car
    {
        // Override the CalculateCost method for SportsCar
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double taxRate = 0.10; // Fixed tax rate for sports cars
            int age = currentYear - Year; // Calculate the age of the car
            double totalTax = basePrice * taxRate * age; // Total tax calculation
            return basePrice + totalTax; // Total cost calculation
        }
    }

    public class SUV : Car
    {
        // Override the CalculateCost method for SUV
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double taxRate = 0.05; // Fixed tax rate for SUVs
            int age = currentYear - Year; // Calculate the age of the car
            double totalTax = basePrice * taxRate * age; // Total tax calculation
            return basePrice + totalTax; // Total cost calculation
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.Write("Choose the option: ");
            int choice = int.Parse(Console.ReadLine());

            Car car;
            switch (choice)
            {
                case 1: // Sports Car
                    car = new SportsCar();
                    break;
                case 2: // SUV Car
                    car = new SUV();
                    break;
                case 3: // None of the above
                    Console.Write("Enter the make: ");
                    string make = Console.ReadLine();
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the year the car was made: ");
                    int year = int.Parse(Console.ReadLine());
                    Console.Write("Enter the basic price: ");
                    double basePrice = double.Parse(Console.ReadLine());
                    Console.Write("Enter the current year: ");
                    int currentYear = int.Parse(Console.ReadLine());

                    car = new Car() { Make = make, Model = model, Year = year }; // Create base Car instance
                    double cost = car.CalculateCost(basePrice, currentYear);
                    Console.WriteLine($"The cost is {cost}");
                    return; // Exit after calculating cost for "None of the above"
                default:
                    Console.WriteLine("Invalid option.");
                    return; // Exit if invalid option is selected
            }

            // Gather details for SportsCar or SUV
            Console.Write("Enter the make: ");
            car.Make = Console.ReadLine();
            Console.Write("Enter the model: ");
            car.Model = Console.ReadLine();
            Console.Write("Enter the year the car was made: ");
            car.Year = int.Parse(Console.ReadLine());
            Console.Write("Enter the basic price: ");
            double basicPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter the current year: ");
            int currYear = int.Parse(Console.ReadLine());

            // Calculate and display the cost
            double totalCost = car.CalculateCost(basicPrice, currYear);
            if (car is SportsCar)
            {
                Console.WriteLine($"Sports car cost is {totalCost}");
            }
            else if (car is SUV)
            {
                Console.WriteLine($"SUV car cost is {totalCost}");
            }
        }
    }

}

