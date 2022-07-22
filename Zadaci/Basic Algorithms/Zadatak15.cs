/*
Write a C# Sharp program to check if a string 'yt' 
appears at index 1 in a given string.
 If it appears return a string without 'yt' 
 otherwise return the original string.
*/


public static class YtAppearsAtIndex1
{
    public static string Get(string str)
    {
        string temp = str.ToLower();



        var index = temp.IndexOf("yt");
        if (index == 1)
        {
            return str.Remove(1, 2);
        }



        return str;

    }

}
