using System.Text;
using System;
/*
 Write a C# Sharp program to exchange the first and
  last characters in a given string and return the new string.
*/
public class StringExchange
{
    public static string Exchange(string str)
    {

        if (str.Length == 1)
        {
            return str;
        }

        StringBuilder sb = new StringBuilder(str);

        var firstIndex = 0;
        var lastIndex = str.Length - 1;

        var firstLetter = str.ElementAt(0);
        var lastLetter = str.ElementAt(str.Length - 1);
        sb[firstIndex] = lastLetter;
        sb[lastIndex] = firstLetter;

        return sb.ToString();

    }

}
