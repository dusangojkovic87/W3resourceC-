/*
Write a C# Sharp program to check if a given positive number is
 a multiple of 3 or a multiple of 7.
*/
public static class MultipleOf7or3
{

    public static bool isMultiple(int number)
    {
        if (number % 3 == 0 || number % 7 == 0)
        {
            return true;
        }


        return false;
    }

}
