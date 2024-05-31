﻿using System;

class MyClass
{
    static void Main()
    {
        // Get the formatted phone number and store it 
        string formattedPhoneNumber = CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }); // => returns "(123) 456-7890"

        // Display the formatted phone number
        Console.WriteLine(formattedPhoneNumber);

        // Ensure program does not immediately close
        Console.WriteLine("\nPress <Enter> to close the program. Goodbye!");
        Console.ReadLine();
    }

    public static string CreatePhoneNumber(int[] numbers)
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
            if (i == 0) formattedString += "(" + stringNumbers[i];
            // Otherwise, if at the second character, concatenate the digit and then ")" and then a space
            else if (i == 2) formattedString += stringNumbers[i] + ") ";
            // Otherwise, if at the fifth character, print the digit and then "-"
            else if (i == 5) formattedString += stringNumbers[i] + "-";
            // Otherwise, no special character needed so just concatenate the number itself to the formatted string
            else formattedString += stringNumbers[i];
        }

        // Formatted string now holds something similar to "(123) 456-7890"
        return formattedString;
    }
}