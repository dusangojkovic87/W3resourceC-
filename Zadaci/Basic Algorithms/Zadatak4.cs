/*
 Write a C# Sharp program to check a given integer and 
 return true if it is within 10 of 100 or 200.
*/
public static class inRange10of100or200
{

    public static bool isInRange(int n)
    {
        if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
            return true;
        return false;

    }


}
