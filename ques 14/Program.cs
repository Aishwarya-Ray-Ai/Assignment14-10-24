namespace ques_14
{
    internal class Program
    {
        
        // Method to replace duplicate characters with a special character
        public void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            // Loop through the array to find duplicate characters
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = i + 1; j < chars.Length; j++)
                {
                    // If a duplicate character is found, replace it with the special character
                    if (chars[i] == chars[j])
                    {
                        chars[j] = specialChar;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            // Get the array size from the user
            Console.WriteLine("Enter the array size");
            int size = int.Parse(Console.ReadLine());

            // Initialize the character array
            char[] chars = new char[size];

            // Get the characters from the user
            Console.WriteLine("Enter the characters");
            for (int i = 0; i < size; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            // Get the special character from the user
            Console.WriteLine("Enter the special character");
            char specialChar = char.Parse(Console.ReadLine());

            // Create an instance of the Program class and call the method
            Program program = new Program();
            program.ReplaceDuplicateWithSpecialChar(ref chars, specialChar);

            // Display the output array
            Console.WriteLine("Modified array:");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }
    

}
}
