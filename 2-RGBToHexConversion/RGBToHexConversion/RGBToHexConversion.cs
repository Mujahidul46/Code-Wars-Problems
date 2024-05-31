using System;

/*
 * To go from RGB to hexadecimal, you divide the value by 16. The quotient is the first number, and the remainder is the
 * second number. If either values is greater or equal to 10, we display this as a letter rather than a double digit number.
 * 10=A
 * 11=B
 * 12=C
 * 13=D
 * 14=E
 * 15=F
 * Each RGB number (e.g. 255) corresponds to 2 hexadecimal characters (e.g. FF)
 * 
 * This website explains it well:
 * https://gristle.tripod.com/hexconv.html#:~:text=Given%20RGB%20values%2C%20where%20all,x%22%20%2B%20y%22%2F16
*/

class RGBToHexConversion
{
    static void Main ()
    {
        // Call the method to convert RGB to hex
        string hexString1 = RgbToHex(255, 255, 255);
        string hexString2 = RgbToHex(255, 255, 300);
        string hexString3 = RgbToHex(0, 0, 0);
        string hexString4 = RgbToHex(148, 0, 211);

        // Display the hex strings
        Console.WriteLine(hexString1);
        Console.WriteLine(hexString2);
        Console.WriteLine(hexString3);
        Console.WriteLine(hexString4);

        // Ensure that the console does not close immediately
        Console.WriteLine("\nPress <Enter> to close the program! Goodbye!\n");
        Console.ReadLine();
    }

    public static string RgbToHex(int r, int g, int b)
    {
        // Store the hex string here
        string hexString = "";

        // If the RGB values are greater than 255, set the value to 255
        if (r >= 255) r = 255;
        if (g >= 255) g = 255;
        if (b >= 255) b = 255;

        // If the RGB values are less than 0, set the value to 0
        if (r < 0) r = 0;
        if (g < 0) g = 0;
        if (b < 0) b = 0;

        // Store rgb values in an array
        int[] rgbValues = [r, g, b];

        // Loop through each of the 3 values in RGB array
        for (int i = 0; i < rgbValues.Length; i++)
        {
            // Get the quotient
            int quotient = (rgbValues[i] / 16);

            // Get the remainder
            int remainder = (rgbValues[i] % 16);

            // Make quotient a string
            string quotientInHex = quotient.ToString();

            // Make remainder a string
            string remainderInHex = remainder.ToString();

            // If quotient is greater or equal to 10...
            if (quotient >= 10)
            {
                // Convert the double digit integer to its corresponding letter
                quotientInHex = GetCharacterEquivalentForDoubleDigitInt(quotient);
            }
            // If remainder is greater or equal to 10...
            if (remainder >= 10)
            {
                // Convert the double digit integer to its corresponding letter
                remainderInHex = GetCharacterEquivalentForDoubleDigitInt(remainder);
            }

            // Append the quotient and remainder to the current version of the hex string
            hexString += quotientInHex;
            hexString += remainderInHex;
        }

        return hexString;
    }

    public static string GetCharacterEquivalentForDoubleDigitInt(int doubleDigitInt)
    {
        // If the doubleDigitInt is 10/11/12/13/14/15, replace them with the characters A/B/C/D/E/F respectively
        if (doubleDigitInt == 10) return "A";
        else if (doubleDigitInt == 11) return "B";
        else if (doubleDigitInt == 12) return "C";
        else if (doubleDigitInt == 13) return "D";
        else if (doubleDigitInt == 14) return "E";
        else if (doubleDigitInt == 15) return "F";
        // If an incorrect value (e.g. 9) has been passed to the function, return that integer as a string
        else return doubleDigitInt.ToString();
    }
}