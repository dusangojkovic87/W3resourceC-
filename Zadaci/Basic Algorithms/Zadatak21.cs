/*
Zadatak 27
Write a C# Sharp program to count the string "aa" in a 
given string and assume "aaa" contains two "aa"
*/
public static class CountAA
{
    public static int Get(string str)
    {

        int counter = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str.Substring(i, 2) == "aa")
            {
                counter++;
            }
        }
        return counter;


    }

}


