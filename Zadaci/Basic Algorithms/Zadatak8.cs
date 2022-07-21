/*
Write a C# Sharp program to create a new string which is 
4 copies of the 2 front characters of a given string.
 If the given string length is less than 2 return the original string. 

*/

public static class FirstTwoLettersOfString
{

    public static string fourCopiesOfTwoLetters(string str)
    {
        var firstTwoLetters = str.Substring(0, 2);
        return string.Concat(Enumerable.Repeat(firstTwoLetters, 4));
    }



}
