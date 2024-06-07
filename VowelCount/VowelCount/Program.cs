using System.Linq;

// Method 2 is better than method 1
namespace VowelCount
{
	class VowelCounter
	{
		static void Main()
		{
            // Store the strings
            string string1 = "abracadabra";

            // Call the vowel counter function and store the result
            int count = GetVowelCountMethod2(string1);

            // Display the result
            Console.WriteLine($"The number of vowels in '{string1}' is: {count}");

            // Prevent the console from closing immediately
            Console.WriteLine("\nPress <Enter> to close the console. Goodbye!");
            Console.ReadLine();
        }

		// Method 1 uses a for loop
		public static int GetVowelCountMethod1(string str)
		{
			// Set the vowel count to 0
			int vowelCount = 0;

			// For each character in the string...
			for (int i = 0; i < str.Length; i++) 
			{
				// If the character is a vowel...
				if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
				{
					// Add 1 to the vowel count
					vowelCount += 1;
				}
            }
			// Return the number of vowels
			return vowelCount;
		}

        // Method 2: Store the vowels in an array. This method is more maintanable that method 1.
        public static int GetVowelCountMethod2(string str)
        {
            // Set the vowel count to 0
            int vowelCount = 0;

            // Store the vowels inside an array
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // For each character in the string...
            for (int i = 0; i < str.Length; i++)
            {
                // If the character is in the vowels array...
                if (vowels.Contains(str[i]))
                {
                    // Add 1 to the vowel count
                    vowelCount += 1;
                }
            }
            // Return the number of vowels
            return vowelCount;
        }
    }
}