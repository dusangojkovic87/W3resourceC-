
/*
 Write a C# Sharp program to check two given integers, and return true if one of them
  is 30 or if their sum is 30
*/


public static class Check30
{
    public static bool is30(int n, int m)
    {
        int sum = n + m;
        if (n == 30 || m == 30)
        {
            return true;
        }

        if (sum == 30)
        {
            return true;
        }



        return false;

    }

}
