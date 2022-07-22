using System.Text;
/*
Write a C# Sharp program to create a new string 
taking the first 3 characters of a given string and
 return the string with the 3 characters added at both 
 the front and back. If the given string length is
 less than 3, use whatever characters are there

*/
public static class ThreeCharactersofString
{
    public static string Get(string str)
    {
        string appendedString;

        if (str.Length <= 3)
        {
            return appendedString = $"{str}{str}{str}";

        }

        var lastThreeChar = str.Substring(0, 3);

        appendedString = $"{lastThreeChar}{str}{lastThreeChar}";



        return appendedString;

    }
}
