/*
(Zadatak 19)
Write a C# Sharp program to check which number
nearest to the value 100
 among two given integers. 
 Return 0 if the two numbers are equal

*/
public static class NearestTo100
{
    public static int Get(int a, int b)
    {
        if (a == b)
        {
            return 0;
        }

        if (a > 0 && a > b && a <= 100)
        {
            return a;
        }
        else
        {
            return b;
        }





    }

}
