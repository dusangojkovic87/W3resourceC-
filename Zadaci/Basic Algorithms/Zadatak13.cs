/*
Write a C# Sharp program to check if
 one given temperatures is less than 0 
 and the other is greater than 100.

*/
public static class CheckTemperature
{
    public static bool isLessThenZeroAndGreaterThenHundred(double t1, double t2)
    {

        if (t1 < 0 && t2 > 100 || t2 < 0 && t1 > 100)
        {
            return true;
        }


        return false;
    }

}
