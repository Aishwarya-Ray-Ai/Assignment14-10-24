namespace ques_3
{
    internal class Program
    {
        
    
        public static void Main(string[] args)
        {
            int outer = 1; // Initialize the outer loop counter

            // Outer do-while loop
            do
            {
                int inner = 1; // Initialize the inner loop counter
                do
                {
                    // Print the outer and inner loop values
                    Console.WriteLine($"{outer} {inner}");
                    inner++; // Increment the inner loop counter
                }
                while (inner <= 2); // Inner loop runs 2 times

                outer++; // Increment the outer loop counter
            }
            while (outer <= 5); // Outer loop runs 5 times
        }
    }

}

