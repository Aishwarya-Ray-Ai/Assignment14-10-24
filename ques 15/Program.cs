namespace ques_15
{
   


        public class Candy
        {
            // Properties for Candy details
            public string Flavour { get; set; }
            public int Quantity { get; set; }
            public int PricePerPiece { get; set; }
            public double TotalPrice { get; set; }
            public double Discount { get; set; }

            // Method to validate the flavour of the candy
            public bool ValidateCandyFlavour()
            {
                if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
                {
                    return true;
                }
                return false;
            }
        }

        public class Program
        {
            // Method to calculate the discounted price
            public static Candy CalculateDiscountedPrice(Candy candy)
            {
                // Calculate the total price before discount
                candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

                // Calculate discount based on the flavour
                switch (candy.Flavour)
                {
                    case "Strawberry":
                        candy.Discount = candy.TotalPrice - (candy.TotalPrice * 15 / 100);
                        break;
                    case "Lemon":
                        candy.Discount = candy.TotalPrice - (candy.TotalPrice * 10 / 100);
                        break;
                    case "Mint":
                        candy.Discount = candy.TotalPrice - (candy.TotalPrice * 5 / 100);
                        break;
                }

                return candy;  // Return the candy object with updated details
            }

            public static void Main(string[] args)
            {
                // Create a new Candy object
                Candy candy = new Candy();

                // Get the flavour from the user
                Console.WriteLine("Enter the flavour");
                candy.Flavour = Console.ReadLine();

                // Validate the flavour
                if (!candy.ValidateCandyFlavour())
                {
                    Console.WriteLine("Invalid flavour");
                    return;
                }

                // Get the quantity and price per piece from the user
                Console.WriteLine("Enter the quantity");
                candy.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the price per piece");
                candy.PricePerPiece = int.Parse(Console.ReadLine());

                // Calculate the discounted price
                candy = CalculateDiscountedPrice(candy);

                // Display the final output
                Console.WriteLine($"Flavour : {candy.Flavour}");
                Console.WriteLine($"Quantity : {candy.Quantity}");
                Console.WriteLine($"Price Per Piece : {candy.PricePerPiece}");
                Console.WriteLine($"Total Price : {candy.TotalPrice}");
                Console.WriteLine($"Discount Price : {candy.Discount}");
            }


        }
    }
