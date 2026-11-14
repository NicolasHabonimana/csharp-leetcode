public class Program
{
    public static void Main()
    {
       int[] ex = [1,3,6,7,11,9];

       Solution program = new Solution();
       int[] output = Solution.FindMinMax(ex);
       Console.WriteLine("Min: " + output[0]);
       Console.WriteLine("Max: " + output[1]);
    }
}