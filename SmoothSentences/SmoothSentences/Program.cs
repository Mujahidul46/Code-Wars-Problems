using System;

namespace SmoothSentences
{
    class SmoothSentencesDetector
    {
        static void Main()
        {
            // Call the method to detect is a sentence is smooth
            bool isSmooth = IsSmooth("Marta appreciated deep perpendicular right trapezoids");

            // Display the result (true or false)
            Console.WriteLine(isSmooth);

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static bool IsSmooth(string sentence)
        {
            // Loop through each character in the sentence
            for (int i = 0; i < sentence.Length; i++)
            {
                // If at end of sentence...
                if (i == sentence.Length - 1)
                {
                    // Have not returned false yet, so must be smooth sentence
                    return true;
                }

                // If the next character is a space AND
                // the character at the start of the next word is NOT equal to the last letter of the current word...
                // Note: Letter comparison is case insensitive.
                if (sentence[i + 1].Equals(' ') && !(char.ToLower(sentence[i + 2]).Equals(char.ToLower(sentence[i]))))
                {
                    // Not a smooth sentence as at least one pair of words is not smooth, so return false
                    return false;
                }
            }
            // Smooth sentence found, so return true
            return true;
        }
    }
}