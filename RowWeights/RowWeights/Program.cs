using System;

namespace RowWeights
{
    class RowWeightsTotal
    {
        static void Main()
        {
            // Store the result from calling the RowWeights function
            int[] result = RowWeights([13, 27, 49]);

            // Display the result
            Console.WriteLine($"[{string.Join(", ", result)}]");

            // Ensure program doesn't close immediately
            Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
            Console.ReadLine();
        }

        public static int[] RowWeights(int[] weights)
        {
            // Store the total weights for team 1 and 2
            int totalWeightTeam1 = 0;
            int totalWeightTeam2 = 0;

            // For each weight in the array...
            for (int i = 0; i < weights.Length; i++)
            {
                // If i is even, add weight to team 1
                if (i % 2 == 0)
                    totalWeightTeam1 += weights[i];
                // If i is odd, add weight to team 2
                if (i % 2 == 1)
                    totalWeightTeam2 += weights[i];
            }

            // Return an array with the total weights of each team
            return new int[] { totalWeightTeam1, totalWeightTeam2 };
        }
    }
}