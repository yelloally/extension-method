using System;

public static class StringExtensions
{

    //define the extension method, which takes a string as its first parameter and returns a new string
    public static string Reverse(this string str)
    {
        //convert the string to a char array and reverse the order of the elements
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);

        //convert the char array back to a string and return the result
        return new string(charArray);
    }
    static void Main(string[] args)
    {
        //call the extension method on a string object
        string originalString = "hello";
        string reversedString = originalString.Reverse();

        // Output the result.
        Console.WriteLine(reversedString);
        //output
        //"olleh"

    }
}

   