/*
Write a C# Sharp program to create a new string with the last char
 added at the front and back of a given string of length 1 or more
*/


public static class LastCharFrontandBack
{
    public static string GetNewString(string str)
    {

        var lastIndex = str.Length - 1;
        var lastLetter = str.ElementAt(lastIndex);
        var result = $"{lastLetter}{str}{lastLetter}";

        return result;
    }



}
