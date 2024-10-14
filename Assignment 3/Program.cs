namespace Assignment3
{
    internal class Program
    {
      
        public static void Main(string[] args)
        {
            // Prompt and get input for int data type
            Console.WriteLine("Enter an integer value");
            int intValue = Convert.ToInt32(Console.ReadLine());

            // Prompt and get input for float data type
            Console.WriteLine("Enter a float value");
            float floatValue = float.Parse(Console.ReadLine());

            // Prompt and get input for double data type
            Console.WriteLine("Enter a double value");
            double doubleValue = double.Parse(Console.ReadLine());

            // Prompt and get input for long data type
            Console.WriteLine("Enter a long value");
            long longValue = long.Parse(Console.ReadLine());

            // Prompt and get input for string data type
            Console.WriteLine("Enter a string");
            string stringValue = Console.ReadLine();

            // Display the results
            Console.WriteLine($"int: {intValue}");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"string: {stringValue}");
        }
    }

}

