using System;
// Methods from best to worst are method 3, then 2, and then 1.
class MyClass
{
    static void Main()
    {
        // Get the formatted phone number and store it 
        string formattedPhoneNumber = CreatePhoneNumberMethod3(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }); // => returns "(123) 456-7890"

        // Display the formatted phone number
        Console.WriteLine(formattedPhoneNumber);

        // Ensure program does not immediately close
        Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
        Console.ReadLine();
    }

    // Not ideal method because hard to maintain in future
    public static string CreatePhoneNumberMethod1(int[] numbers)
    {
        // Store the 3 distinct parts of the number in 3 variables.
        string first = $"{numbers[0]}{numbers[1]}{numbers[2]}"; // 123
        string second = $"{numbers[3]}{numbers[4]}{numbers[5]}"; // 456
        string third = $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}"; // 7890

        // Return the formatted string
        return $"({first}) {second}-{third}";
    }

    // Good method but quite long
    public static string CreatePhoneNumberMethod2(int[] numbers)
    {
        // Store the array of numbers as a string
        string stringNumbers = "";

        // Store the formatted string that we will keep adding to
        string formattedString = "";

        // Loop through the array of numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            // Add the numbers from the array into the string
            stringNumbers += numbers[i];
        }

        // stringNumbers holds something similar to "1234567890"

        // Loop through the string
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            // If at the beginning of the number, concatenate "(" and then the first digit
            if (i == 0) 
                formattedString += "(" + stringNumbers[i];
            // Otherwise, if at the second character, concatenate the digit and then ")" and then a space
            else if (i == 2) 
                formattedString += stringNumbers[i] + ") ";
            // Otherwise, if at the fifth character, print the digit and then "-"
            else if (i == 5) 
                formattedString += stringNumbers[i] + "-";
            // Otherwise, no special character needed so just concatenate the number itself to the formatted string
            else 
                formattedString += stringNumbers[i];
        }

        // Formatted string now holds something similar to "(123) 456-7890"
        return formattedString;
    }

    // Good concise method
    public static string CreatePhoneNumberMethod3(int[] numbers)
    {
        // Concatenate the numbers in the array so the commas are removed, and store it as a long
        long numberWithoutCommas = long.Parse(String.Concat(numbers));

        // Format the string, and then return it
        return numberWithoutCommas.ToString("(000) 000-0000");
    }
}