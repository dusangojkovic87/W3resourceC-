using System.Text;
/*
Zadatak 29
Write a C# Sharp program to create a new string made of 
every other character starting with the first from a given string.
*/
public static class EveryOther
{

    public static string Get(string str)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < str.Length; i += 2)
        {
            sb.Append(str[i]);
            continue;

        }



        return sb.ToString();
    }

}
