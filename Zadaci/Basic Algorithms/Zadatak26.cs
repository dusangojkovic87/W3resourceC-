/*
Zadatak 32
Write a C# Sharp program to check if one of the first 4 elements in 
an array of integers is equal to a given element.
*/
public static class FirstFourEqual
{
    public static bool Get(int[] arr, int num)
    {
        if (arr.Count() >= 4)
        {
            var fourEl = arr.Take(4);
            if (fourEl.Contains(num))
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
