/*
Zadatak 30
Write a C# Sharp program to create a string like "aababcabcd" 
from a given string "abcd".
*/
public static class JibleString
{
    public static string Get(string str)
    {

        var result = string.Empty;
        for (var i = 0; i < str.Length; i++)
        {
            result += str.Substring(0, i + 1);
        }
        return result;
    }

}
