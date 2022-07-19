/*
Write a C# Sharp program to remove the character in a given position of a given string.
 The given position will be in the range 0.. string length -1 inclusive
  
*/
public static class RemoveChar
{
    public static string RemoveAtIndex(string str, int n)
    {
        if (n <= str.Length - 1)
        {

            return str.Remove(n, 1);
        }

        return str;

    }

}
