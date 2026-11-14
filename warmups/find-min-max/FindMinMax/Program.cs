using System.Numerics;

public class Solution
{
    public static int[] FindMinMax(int[] arr)
    {
        int MaxValue = arr[0];
        int MinValue = arr[0];

        foreach(int i in arr)
        {
            if(MaxValue < i){MaxValue = i;}
            if(MinValue > i){MinValue = i;}
        }
        return [MinValue, MaxValue];
    }
  
}