using System.Text;

namespace ques_7
{
    internal class Program
    {
        
        // Method to find the exponential of a number
        public static StringBuilder FindExponential(int number)
        {
            // Create a StringBuilder object with the initial message
            StringBuilder result = new StringBuilder("Exponential is ");

            // Calculate the exponential (square of the number in this case)
            int exponential = number * number;

            // Append the result to the StringBuilder
            result.Append(exponential);

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
            // Get input for FindExponential method
            Console.WriteLine("Enter a number to find its exponential:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Call FindExponential method and display the result
            StringBuilder exponentialResult = FindExponential(number);
            Console.WriteLine(exponentialResult.ToString());

            // Get input for ReplaceWord method
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
    }

}

