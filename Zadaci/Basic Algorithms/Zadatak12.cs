
public static class StartsWithCsharp
{
    public static bool Get(string str)
    {
        str = str.ToLower();


        if (str.StartsWith("c#"))
        {
            return true;
        }



        return false;

    }

}
