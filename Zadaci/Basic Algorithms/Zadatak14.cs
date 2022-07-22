
using System.Diagnostics.Contracts;
public static class isInRange100or200
{

    public static bool Get(int number1, int number2)
    {

        if (
           number1 >= 100 && number1 <= 100 ||
           number2 >= 100 && number2 <= 200 ||
           number2 >= 100 && number2 <= 100 ||
           number2 >= 100 && number2 <= 200
           )
        {
            return true;
        }


        return false;

    }

}
