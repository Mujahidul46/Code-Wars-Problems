using System;

namespace IndexCapitalLetters
{
    class IndexAllCapitalLetters
    {
        static void Main()
        {
            // Call the method to get indices of all capital letters
            int[] indices = IndexOfCapitals("eDaBiT");

            // Display the result
            Console.WriteLine($"[{string.Join(", ", indices)}]");

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static int[] IndexOfCapitals(string str)
        {
            // Store the indices inside a list
            List<int> indices = new List<int>();

            // For each character in the string...
            for (int i = 0; i < str.Length; i++)
            {
                // If the character is uppercase...
                if (char.IsUpper(str[i]))
                {
                    // Add the index of the uppercase letter to the list
                    indices.Add(i);
                }
            }

            // Return an array of indices
            return indices.ToArray();
        }
    }
}