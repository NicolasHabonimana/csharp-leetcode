public class Solution
{
    public static int[] MultiplyByLength(int[] arr)
    {
        int magnitude = arr.Length;
        int[] newArr = [];
        for(int i= 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i]*magnitude;
        }
        return newArr;
    }
}