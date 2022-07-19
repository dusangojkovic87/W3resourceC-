/*
Write a C# Sharp program to get the absolute
 difference between n and 51. If n is greater than 51 return 
 triple the absolute difference.
*/

public class AbsoluteDiff
{
    public static int GetAbsoluteDiff(int n)
    {
        const int x = 51;


        if (n > 51)
        {
            return (n - x) * 3;

        }


        return x - n;
    }

}
