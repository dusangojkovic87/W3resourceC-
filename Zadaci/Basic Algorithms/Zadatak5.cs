/*
Write a C# Sharp program to create a new string where 'if' is
 added to the front of a given string. If the string already begins with
 'if', return the string unchanged. 
*/


public static class CheckIf
{

    public static string ContainsIf(string str)
    {
        string firstTwo = str.Substring(0, 2);
        bool doesContainIf = String.Equals(firstTwo, "if", StringComparison.OrdinalIgnoreCase);
        if (doesContainIf)
        {
            return str;
        }
        else
        {
            return str.Insert(0, "if ");
        }


    }



}
