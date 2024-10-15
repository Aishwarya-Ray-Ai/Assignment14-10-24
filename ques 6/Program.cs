using System.Text;

namespace ques_6
{
    internal class Program
    {
       
        public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            // Find the index of the character in word1
            int index = word1.ToString().IndexOf(ch);

            // Check if the character is found
            if (index != -1)
            {
                // Insert word2 at the found index
                word1.Insert(index, word2);
            }

            // Return the modified word
            return word1;
        }

        public static void Main(string[] args)
        {
            // Get the input from the user
            Console.WriteLine("Enter the word 1");
            StringBuilder word1 = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter the character to search");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the word 2");
            string word2 = Console.ReadLine();

            // Call the WordInserting method and get the result
            StringBuilder result = WordInserting(word1, ch, word2);

            // Display the result
            Console.WriteLine(result.ToString());
        }
    }

}

