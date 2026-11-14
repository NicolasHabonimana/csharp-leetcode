using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public class Solution
{
    public static int FindSum(int[] arr)
    {
        int sum = 0;
        for(int i=0; i < arr.Length; i++)
        {
            if(arr[i] < 0){arr[i] *= -1;}
        }
        foreach(int i in arr)
        {
            sum += i;
        }
        return sum;
    }
}
