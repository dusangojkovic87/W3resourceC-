using System.Linq;
/*
Write a C# Sharp program to check the largest number among
 three given integers. 
*/


public static class LargestOfThreeNumbers
{

    public static double Get(double a, double b, double c)
    {
        List<double> largest = new List<double>();
        largest.Add(a);
        largest.Add(b);
        largest.Add(c);


        return largest.Max();
    }

}
