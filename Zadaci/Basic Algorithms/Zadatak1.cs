/*
Write a C# Sharp program to compute the sum of the two given integer values. 
If the two values are the same, then return triple their sum. 
*/


public static class SumIntegers
{
    public static int Calculate(int a, int b)
    {
        if (a == b)
        {
            return (a + b) * 3;
        }

        return a + b;
    }


}
