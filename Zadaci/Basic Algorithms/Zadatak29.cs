/*
Zadatak  39
Write a C# Sharp program to check if a triple is
 presents in an array of integers or not. If a value 
appears three times in a row in an array it is called a triple.
*/
public static class Triple
{

    public static bool isTriple(int[] arr)
    {
        for (int i = 0; i < arr.Length - 2; i++)
        {
            if (arr[i] == arr[i + 1] && arr[i + 1] == arr[i + 2])
            {
                return true;
            }



        }


        return false;

    }

}
