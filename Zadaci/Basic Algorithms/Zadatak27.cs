
/*
Zadatak 25
Write a C# Sharp program to compare two given strings and return the number of
 the positions where they contain the same length 2 substring

*/
public static class CompareTwoStrings
{
    public static int Get(string str1, string str2)
    {
        string temp1 = "";
        string temp2 = "";
        int counter = 0;
        for (int i = 0; i < str1.Length - 1; i++)
        {
            for (int j = 0; j < str2.Length - 1; j++)
            {
                temp1 = str1.Substring(i, 2);
                temp2 = str2.Substring(j, 2);
                if (temp1.Equals(temp2))
                {
                    counter++;
                    continue;
                }


            }



        }

        return counter;
    }

}
