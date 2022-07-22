/*
Write a C# Sharp program to count the number
 of two 5's are next to each other in an array of integers.
 Also count the situation where the second 5 is actually a 6. 

*/
public class Count5sNextToEachOther
{
    public static int Get(int[] arr)
    {
        int counter = 0;
        for (int i = 0; i < arr.Count() - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
            }

        }





        return counter;

    }

}
