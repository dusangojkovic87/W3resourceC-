/*
Zadatak 24
Write a C# Sharp program to convert the last 3 characters of a given string in upper case.
 If the length of the string has less than 3 then uppercase all the characters.
*/
public class ConvertLastThreeToUpper
{
    public static string Get(string str)
    {
        if (str.Length <= 3)
        {
            return str.ToUpper();
        }
        else
        {
            var text = str.Substring(0, str.Length - 3);
            var lasThrreeLetter = str.Substring(str.Length - 3, 3).ToUpper();
            var upperString = $"{text}{lasThrreeLetter}";
            return upperString;



        }

    }



}
