using System;
using System.ComponentModel;
using System.Linq;

namespace ShortestWord
{
    class ShortestWordLength
    {
        static void Main()
        {
            // Call the FindShort method and store the length of the shortest word
            int lengthOfShortestWord = FindShort("bitcoin take over the world maybe who knows perhaps");

            // Display the length of the shortest word
            Console.WriteLine(lengthOfShortestWord);

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static int FindShort(string stringOfWords)
        {
            // Store individual words inside an array
            string[] words = stringOfWords.Split(' ');

            // Store the shortest length found so far
            // This is initially set to a very large integer, so it is always smaller than the length of the longest word.
            int shortestLength = int.MaxValue;
            
            // For each word...
            foreach (string word in words)
            {
                // If the length of the word is shorter than the current shortest length...
                if (word.Length < shortestLength)
                    // Update the shortest length to the length of the current word
                    shortestLength = word.Length;
            }
            
            // Return the length of the shortest word
            return shortestLength;
        }
    }
}