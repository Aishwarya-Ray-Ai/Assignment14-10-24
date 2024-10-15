namespace ques_13
{
    internal class Program
    {
      
        // Method to calculate the discounted price
        public static object CalculateDiscountedPrice(object totalCost)
        {
            // Unboxing the object type to double
            double cost = (double)totalCost;
            double discount = 0;

            // Calculate discount based on the total cost
            if (cost >= 100 && cost <= 500)
            {
                discount = cost * 0.05; // 5% discount
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = cost * 0.15; // 15% discount
            }
            else if (cost > 1000)
            {
                discount = cost * 0.30; // 30% discount
            }

            // Calculate the discounted price
            double discountedPrice = cost - discount;

            // Boxing the result back to an object type
            object result = discountedPrice;

            // Return the result as an object
            return result;
        }

        public static void Main(string[] args)
        {
            // Get the total cost from the user
            Console.WriteLine("Enter the total cost");
            double totalCost = double.Parse(Console.ReadLine());

            // Call the method to calculate the discounted price
            object discountedPrice = CalculateDiscountedPrice(totalCost);

            // Unbox and display the result
            Console.WriteLine($"Price after discount is {discountedPrice}");
        }
    

}
}
