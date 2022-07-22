/*
Zadatak 22
Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character

*/
public class Contains4ZCharacters
{
    public static bool Get(string str)
    {
        var zCount = str.Count(x => x == 'z');
        if (zCount >= 2 && zCount <= 4)
        {
            return true;
        }



        return false;
    }

}
