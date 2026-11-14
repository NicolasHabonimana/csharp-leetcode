public class Program
{
    public static void Main()
    {
        int[] ex = [1, 4, 5, 7, -1];

        Solution mySolution = new Solution();
        int[] output = Solution.MultiplyByLength(ex);
        Console.WriteLine(output);
    }
}