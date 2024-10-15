using System;
using System.Linq;
using System.Collections.Generic;

namespace ques_9
{
    internal class Program
    {
      
        public static void Main(string[] args)
        {
            // Get the input string from the user
            Console.WriteLine("Enter the string");
            string input = Console.ReadLine();

            // Split the input string by colon to get the words
            string[] words = input.Split(':');

            // Check if the length of words is greater than 15
            if (words.Length > 15)
            {
                Console.WriteLine("Invalid length");
            }
            else
            {
                // Dictionary to store the count of each word (in uppercase)
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                // Loop through the words and count occurrences (case insensitive)
                foreach (string word in words)
                {
                    string upperWord = word.ToUpper();

                    if (wordCount.ContainsKey(upperWord))
                    {
                        wordCount[upperWord]++;
                    }
                    else
                    {
                        wordCount[upperWord] = 1;
                    }
                }

                // Display the words in uppercase along with their counts
                foreach (var item in wordCount)
                {
                    Console.WriteLine($"{item.Key}:{item.Value}");
                }
            }
        }
    }

}

