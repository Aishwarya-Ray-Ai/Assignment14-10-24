namespace ques_10
{
    internal class Program
    {
       
        // Method to update the price of the product based on the product ID
        public static string UpdatePrice(string[] details, int id, double amount)
        {
            // Loop through each product in the array
            foreach (string product in details)
            {
                // Split the product details by colon
                string[] productInfo = product.Split(':');

                // Parse the ID from the product details
                int productId = int.Parse(productInfo[0]);

                // Check if the product ID matches the input ID
                if (productId == id)
                {
                    // Update the price
                    productInfo[2] = amount.ToString();

                    // Return the product name and updated price in the required format
                    return productInfo[1] + " " + productInfo[2];
                }
            }

            // If the ID is not found, return an empty string
            return "";
        }

        public static void Main(string[] args)
        {
            // Get the number of products from the user
            Console.WriteLine("Enter the number of products");
            int numberOfProducts = int.Parse(Console.ReadLine());

            // Declare an array to store the product details
            string[] productDetails = new string[numberOfProducts];

            // Get the product details from the user
            Console.WriteLine("Enter the product details");
            for (int i = 0; i < numberOfProducts; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            // Get the product ID to update
            Console.WriteLine("Enter the product id");
            int productId = int.Parse(Console.ReadLine());

            // Get the new price (amount) to update
            Console.WriteLine("Enter the amount to update");
            double newAmount = double.Parse(Console.ReadLine());

            // Call the UpdatePrice method and get the result
            string result = UpdatePrice(productDetails, productId, newAmount);

            // Check if the result is an empty string (invalid ID) and display the output accordingly
            if (result == "")
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }

}

