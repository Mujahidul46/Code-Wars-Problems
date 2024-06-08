using System;

namespace ArrayOfMultiples
{
    class GetArrayOfMultiples
    {
        static void Main()
        {
            // Call the method to get an array of multiples
            int[] arrayOfMultiples = GenerateArrayOfMultiples(7, 5);

            // Display the array
            Console.WriteLine($"[{string.Join(", ", arrayOfMultiples)}]");

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static int[] GenerateArrayOfMultiples(int num, int length)
        { 
            // Store the array of multiples
            int[] arrayOfMultiples = new int[length];

            // Loop 'length' times as this is the number of multiples needed
            for (int i = 1; i <= length; i++)
            {
                // Calculate the multiple
                // Store this value in the array of multiples
                arrayOfMultiples[i - 1] = num * i;
            }

            // Return the array of multiples
            return arrayOfMultiples;
        }
    }
}