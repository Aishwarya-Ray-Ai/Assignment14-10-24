namespace ques_4
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            // Get the word from the user
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            // Variable to store the resulting converted word
            string convertedWord = "";

            // Loop through each character in the input string
            for (int i = 0; i < input.Length; i++)
            {
                // If the character is at an even index, convert it to uppercase
                if (i % 2 == 0)
                {
                    convertedWord += char.ToUpper(input[i]);
                }
                // If the character is at an odd index, convert it to lowercase
                else
                {
                    convertedWord += char.ToLower(input[i]);
                }
            }

            // Display the result
            Console.WriteLine(convertedWord);
        }
    }

}

