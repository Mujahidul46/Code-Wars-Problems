using System;

class RemoveStringSpaces
{
    static void Main()
    {
        // Here are the test strings that we need to remove spaces from
        string inputStringTest1 = "8 j 8   mBliB8g  imjB8B8  jl  B";
        string inputStringTest2 = "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd";
        string inputStringTest3 = "8aaaaa dddd r     ";

        //////////////////////////////////// Method 1 - Replace method ////////////////////////////////////

        // Replace the spaces with empty characters
        string stringWithNoSpaces1 = inputStringTest1.Replace(" ", "");
        string stringWithNoSpaces2 = inputStringTest2.Replace(" ", "");
        string stringWithNoSpaces3 = inputStringTest3.Replace(" ", "");

        // Output the result
        Console.WriteLine($"String 1\n{inputStringTest1} --> {stringWithNoSpaces1}\n");
        Console.WriteLine($"String 2\n{inputStringTest2} --> {stringWithNoSpaces2}\n");
        Console.WriteLine($"String 3\n{inputStringTest3} --> {stringWithNoSpaces3}\n");

        /////////////////////////////////// Method 2 - ForEach Loop ////////////////////////////////////

        //removeSpacesUsingForEachLoop(inputStringTest1);
        //removeSpacesUsingForEachLoop(inputStringTest2);
        //removeSpacesUsingForEachLoop(inputStringTest3);

        /////////////////////////////////// Method 3 - For Loop ////////////////////////////////////

        //removeSpacesUsingForLoop(inputStringTest1);
        //removeSpacesUsingForLoop(inputStringTest2);
        //removeSpacesUsingForLoop(inputStringTest3);

        // Make sure console does not immediately close
        Console.WriteLine("Press <Enter> to close the window. Goodbye!");
        Console.ReadLine();
    }

    public static void removeSpacesUsingForEachLoop(string inputString)
    {
        // Store the string with no spaces here
        string stringWithNoSpaces = "";

        // Loop through each character in the string
        foreach (char character in inputString)
        {
            // If the character is not a space...
            if (character != ' ')
                // Append the character to a new string
                stringWithNoSpaces += character;
        }

        // Output the result
        Console.WriteLine($"String before:\n{inputString} --> {stringWithNoSpaces}\n");
    }

    public static void removeSpacesUsingForLoop(string inputString)
    {
        // Store the string with no spaces here
        string stringWithNoSpaces = "";

        // Loop through each character in the string
        for (int i = 0; i < inputString.Length; i++)
        {
            // If the character is not a space...
            if (inputString[i] != ' ')
                // Append the character to a new string
                stringWithNoSpaces += inputString[i];
        }

        // Output the result
        Console.WriteLine($"String before:\n{inputString} --> {stringWithNoSpaces}\n");
    }
}

