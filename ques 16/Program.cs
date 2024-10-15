namespace ques_16
{
        public class Owner
        {
            // Protected field for owner's name
            protected string ownerName;
        }

        public class Car : Owner
        {
            // Internal fields for price and body style
            internal double price;
            internal string bodyStyle;

            // Public property for BodyStyle
            public string BodyStyle
            {
                get { return bodyStyle; }
                set { bodyStyle = value; }
            }

            // Method to validate the body style
            public bool ValidateBodyStyle(string bodyStyle)
            {
                return bodyStyle == "SUV" || bodyStyle == "Sedan";
            }

            // Method to calculate the price after discount
            public double CalculatePrice()
            {
                if (bodyStyle == "SUV")
                {
                    return price - (price * 0.10); // 10% discount for SUVs
                }
                else if (bodyStyle == "Sedan")
                {
                    return price - (price * 0.25); // 25% discount for Sedans
                }
                return 0; // No valid body style, return 0
            }

            // Method to set the owner's name
            public void SetOwnerName(string name)
            {
                ownerName = name;
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                // Create a new Car object
                Car car = new Car();

                // Get the owner name from the user
                Console.WriteLine("Enter the owner name:");
                string ownerName = Console.ReadLine();
                car.SetOwnerName(ownerName); // Set the owner's name

                // Get the car body style from the user
                Console.WriteLine("Enter the car body style:");
                string bodyStyle = Console.ReadLine();
                car.BodyStyle = bodyStyle; // Set the body style

                // Validate the body style
                if (!car.ValidateBodyStyle(car.BodyStyle))
                {
                    Console.WriteLine("Invalid Car Type");
                    return; // Exit if body style is invalid
                }

                // Get the price from the user
                Console.WriteLine("Enter the price:");
                car.price = double.Parse(Console.ReadLine());

                // Calculate the final price
                double finalPrice = car.CalculatePrice();

                // Display the result
                if (finalPrice > 0)
                {
                    Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${finalPrice}");
                }
                else
                {
                    Console.WriteLine("Invalid Car Type");
                }
            }
        }

    }

