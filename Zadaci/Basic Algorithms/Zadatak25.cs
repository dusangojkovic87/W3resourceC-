/*
Zadatak 32
Write a C# Sharp program to check a specified number is present in a given array of integers.
*/
public class NumberInArrayCount
{

    public static bool Get(int[] arr, int number)
    {

        var numberAtIndex = Array.IndexOf(arr, number);
        if (numberAtIndex != -1)
        {
            if (numberAtIndex == number)
            {
                return true;
            }
        }


        return false;

    }

}
