using System;
using System.Collections.Generic;
using System.Linq;
namespace ques_5
{
    internal class Program
    {
      
        public static void Main(string[] args)
        {
            // Get the input string from the user
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            // Check if the input length is greater than 100
            if (input.Length > 100)
            {
                Console.WriteLine("Invalid length");
                return;
            }

            // Split the input string by ':' and convert each element to uppercase
            string[] words = input.Split(':').Select(w => w.ToUpper()).ToArray();

            // Dictionary to store the count of each word
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Count occurrences of each word
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Display the word counts in the required format
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }

}

