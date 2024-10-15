namespace ques_23
{
    

// Custom exception class for invalid cake flavors
public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message) { }
    }

    // Cake class to represent a cake order
    public class Cake
    {
        // Properties to hold cake details
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }

        // Method to validate cake order
        public bool CakeOrder()
        {
            // Check for valid flavor
            if (Flavour == "Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
            {
                // Check for valid quantity
                if (QuantityInKg > 0)
                {
                    return true; // Order is valid
                }
                else
                {
                    throw new Exception("Quantity must be greater than zero");
                }
            }
            else
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
            }
        }

        // Method to calculate the total price after discount
        public double CalculatePrice()
        {
            double discount = 0;

            // Determine discount based on the flavor
            if (Flavour == "Vanilla")
            {
                discount = 3; // 3% discount
            }
            else if (Flavour == "Chocolate")
            {
                discount = 5; // 5% discount
            }
            else if (Flavour == "Red Velvet")
            {
                discount = 10; // 10% discount
            }

            // Calculate total price and apply discount
            double totalPrice = QuantityInKg * PricePerKg;
            double discountedPrice = totalPrice - (totalPrice * discount / 100);
            return discountedPrice; // Return the discounted price
        }
    }

    // Main program class
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Prompt user for cake order details
                Console.WriteLine("Enter the flavour");
                string flavour = Console.ReadLine();
                Console.WriteLine("Enter the quantity in kg");
                int quantityInKg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price per kg");
                double pricePerKg = Convert.ToDouble(Console.ReadLine());

                // Create a Cake object with the provided details
                Cake cake = new Cake
                {
                    Flavour = flavour,
                    QuantityInKg = quantityInKg,
                    PricePerKg = pricePerKg
                };

                // Validate the cake order
                if (cake.CakeOrder())
                {
                    // Calculate the price after discount if the order is valid
                    double priceAfterDiscount = cake.CalculatePrice();
                    Console.WriteLine("Cake order was successful");
                    Console.WriteLine("Price after discount is " + priceAfterDiscount);
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message); // Handle invalid flavor exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // Handle other exceptions (e.g., quantity <= 0)
            }
        }
    }

}

