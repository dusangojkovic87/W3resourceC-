/*
Zadatak 28
Write a C# Sharp program to check if the first appearance of "a" in a 
given string is immediately followed by another "a". 
*/
public static class CheckA
{
    public static bool Get(string str)
    {

        var indexOfA = str.IndexOf("a");
        if (indexOfA != -1)
        {
            var s = str.Substring(indexOfA, 2);
            if (s.Equals("aa"))
            {
                return true;
            }
        }


        return false;

    }


}
