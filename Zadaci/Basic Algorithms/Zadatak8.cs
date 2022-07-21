public static class FirstTwoLettersOfString
{

    public static string fourCopiesOfTwoLetters(string str)
    {
        var firstTwoLetters = str.Substring(0, 2);
        return string.Concat(Enumerable.Repeat(firstTwoLetters, 4));
    }



}
