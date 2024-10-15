using System.Text;

namespace ques_8
{
    internal class Program
    {
        // Method to find the exponential of a number and return it in scientific notation
        public static StringBuilder FindExponential(int number)
        {
            // Create a StringBuilder object with the initial message
            StringBuilder result = new StringBuilder("Exponential is ");

            // Calculate the exponential (using Math.Exp to get the exponent of the number)
            double exponential = Math.Exp(number);

            // Append the result in scientific notation to the StringBuilder
            result.Append(exponential.ToString("E6")); // E6 for scientific notation with 6 decimal places

            // Return the StringBuilder object
            return result;
        }

        // Method to replace a word in the sentence with another word
        public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
            // Create a StringBuilder object initialized with the sentence
            StringBuilder result = new StringBuilder(sentence);

            // Replace the word1 with word2 in the sentence
            result.Replace(word1, word2);

            // Return the modified StringBuilder object
            return result;
        }

        public static void Main(string[] args)
        {
            // Display the options to the user
            Console.WriteLine("1. Find Exponential");
            Console.WriteLine("2. Replace Word");
            Console.WriteLine("Choose the option");

            // Get the user's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                // Find Exponential option
                Console.WriteLine("Enter the number:");
                int number = Convert.ToInt32(Console.ReadLine());

                // Call FindExponential method and display the result
                StringBuilder exponentialResult = FindExponential(number);
                Console.WriteLine(exponentialResult.ToString());
            }
            else if (choice == 2)
            {
                // Replace Word option
                Console.WriteLine("Enter a sentence:");
                string sentence = Console.ReadLine();

                Console.WriteLine("Enter the word to be replaced:");
                string word1 = Console.ReadLine();

                Console.WriteLine("Enter the new word:");
                string word2 = Console.ReadLine();

                // Call ReplaceWord method and display the result
                StringBuilder replacedSentence = ReplaceWord(sentence, word1, word2);
                Console.WriteLine(replacedSentence.ToString());
            }
            else
            {
                // Invalid choice
                Console.WriteLine("Invalid option. Please choose 1 or 2.");
            }
        }
    }

}

