using System;

namespace BinaryToInteger
{
	class ConvertBinaryToInt
	{
        static void Main()
        {
            // Store the integer arrays to test
            int[] Test1 = new int[] { 0, 0, 0, 1 };
            int[] Test2 = new int[] { 0, 0, 1, 0 };
            int[] Test3 = new int[] { 0, 1, 0, 1 };
            int[] Test4 = new int[] { 1, 0, 1, 1 };

            // Call the function to convert a binary array to an integer, and store results
            int result1 = binaryArrayToNumber(Test1);
            int result2 = binaryArrayToNumber(Test2);
            int result3 = binaryArrayToNumber(Test3);
            int result4 = binaryArrayToNumber(Test4);


            // Display the results
            Console.WriteLine($"[{string.Join(", ", Test1)}] --> {result1}");
            Console.WriteLine($"[{string.Join(", ", Test2)}] --> {result2}");
            Console.WriteLine($"[{string.Join(", ", Test3)}] --> {result3}");
            Console.WriteLine($"[{string.Join(", ", Test4)}] --> {result4}");


        }

        public static int binaryArrayToNumber(int[] binaryArray)
        {
            // Store the total
            double total = 0;

            // Create a separate reversed array that we will perform operations on
            // This ensures the original array is not modified
            int[] reversedArray = new int[binaryArray.Length];

            // Copy the binaryArray into the reversed array
            Array.Copy(binaryArray, reversedArray, binaryArray.Length);

            // Reverse the array
            Array.Reverse(reversedArray);

            // For each number in the reversed array...
            for (int i = 0; i < reversedArray.Length; i++)
            {
                // If the number is 1...
                if (reversedArray[i] == 1)
                {
                    // Raise 2 to the power of the current index (e.g. 2^^0 at start of array). Add this to the running total.
                    total += Math.Pow(2, i);
                }
            }

            // Return the total as an integer
            return Convert.ToInt32(total);
        }
    }
}