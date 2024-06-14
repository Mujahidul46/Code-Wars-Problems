using System;

namespace CaseReversal
{
    class CaseReversalString
    {
        static void Main()
        {
            // Call the reverse case method
            string result = ReverseCase("Happy Birthday");

            // Display the result
            Console.WriteLine(result);

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static string ReverseCase(string str)
        {
            // Store the new string
            string strCaseReversed = "";

            // Loop through each character in the original string
            for (int i = 0; i < str.Length; i++)
            {
                // If the character is uppercase...
                if (char.IsUpper(str[i]))
                {
                    // Set the character to lower case and add it to the new string
                    strCaseReversed += char.ToLower(str[i]);
                }
                // Otherwise, if the character is lowercase...
                else if (char.IsLower(str[i]))
                {
                    // Set the character to uppercase case and add it to the new string
                    strCaseReversed += char.ToUpper(str[i]);
                }
                // Otherwise...
                else
                {
                    // If character is a space, or punctuation add that character to the string
                    strCaseReversed += str[i];
                }
            }
            // Return the string with the case reversed
            return strCaseReversed;
        }
    }
}