/*
Zadatak 23
Write a C# Sharp program to check if two given non-negative integers have the same last digit
*/
public static class SameLastDigit
{

    public static bool Get(int a, int b)
    {
        if (a >= 0 && b >= 0)
        {
            var aString = a.ToString();
            var bString = b.ToString();
            var lastDigitA = aString.ElementAt(aString.Length - 1);
            var lastDigitB = bString.ElementAt(bString.Length - 1);
            if (lastDigitA == lastDigitB)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        return false;
    }


}
